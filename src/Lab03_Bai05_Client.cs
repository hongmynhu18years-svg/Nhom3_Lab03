using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03
{
    public partial class Lab03_Bai05_Client : Form
    {
        private string monAnHienTai = "";
        private string currentUser = "Người dùng ẩn danh";

        public Lab03_Bai05_Client()
        {
            InitializeComponent();
            txtNhapIPServer.KeyDown += txtNhapIPServer_KeyDown;
        }

        private async void Lab03_Bai05_Load(object sender, EventArgs e)
        {
            ten_mon.BringToFront();
            anh_mon.BringToFront();
            await LoadMenuAsync();
        }

        private async void txtNhapIPServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                await LoadMenuAsync();
            }
        }

        private async Task<Lab03_Bai05_packet> SendRequestAsync(string serverIP, Lab03_Bai05_packet packet, int timeoutSeconds = 10)
        {
            using (CancellationTokenSource cts = new CancellationTokenSource(TimeSpan.FromSeconds(timeoutSeconds)))
            using (TcpClient client = new TcpClient())
            {
                await client.ConnectAsync(serverIP, 8888, cts.Token);

                using (NetworkStream stream = client.GetStream())
                {
                    string jsonRequest = JsonSerializer.Serialize(packet);
                    byte[] requestData = Encoding.UTF8.GetBytes(jsonRequest);

                    await stream.WriteAsync(requestData.AsMemory(), cts.Token);
                    await stream.FlushAsync(cts.Token);

                    client.Client.Shutdown(SocketShutdown.Send);

                    using (MemoryStream ms = new MemoryStream())
                    {
                        byte[] buffer = new byte[8192];
                        int bytesRead;
                        while ((bytesRead = await stream.ReadAsync(buffer.AsMemory(), cts.Token)) > 0)
                        {
                            ms.Write(buffer, 0, bytesRead);
                        }

                        if (ms.Length == 0) return null;

                        string jsonResponse = Encoding.UTF8.GetString(ms.ToArray());
                        return JsonSerializer.Deserialize<Lab03_Bai05_packet>(jsonResponse);
                    }
                }
            }
        }

        private async Task LoadMenuAsync()
        {
            list_mon.Items.Clear();
            string serverIP = txtNhapIPServer.Text.Trim();

            if (string.IsNullOrEmpty(serverIP))
            {
                list_mon.Items.Add("Vui lòng nhập IP Server");
                list_mon.Items.Add("rồi nhấn Enter...");
                return;
            }

            list_mon.Items.Add("Đang kết nối Server...");

            try
            {
                Lab03_Bai05_packet p = new Lab03_Bai05_packet { Action = "GET_LIST" };
                Lab03_Bai05_packet response = await SendRequestAsync(serverIP, p, 3);

                list_mon.Items.Clear();
                if (response != null && response.Action == "LIST_RESULT" && !string.IsNullOrEmpty(response.TenMonAn))
                {
                    List<string> menuItems = JsonSerializer.Deserialize<List<string>>(response.TenMonAn);
                    foreach (string item in menuItems)
                    {
                        list_mon.Items.Add(item);
                    }
                }
            }
            catch
            {
                list_mon.Items.Clear();
                list_mon.Items.Add("Chưa kết nối được Server");
            }
        }

        private async void xoa_Click(object sender, EventArgs e)
        {
            string serverIP = txtNhapIPServer.Text.Trim();
            if (string.IsNullOrEmpty(serverIP))
            {
                MessageBox.Show("Vui lòng nhập IP của Server trước khi Xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (list_mon.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhấp chọn một món bên MENU để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string monCanXoa = list_mon.SelectedItem.ToString();
            if (monCanXoa.Contains("Vui lòng") || monCanXoa.Contains("Chưa kết nối") || monCanXoa.Contains("Đang kết nối"))
                return;

            DialogResult xacNhan = MessageBox.Show("Bạn có chắc chắn muốn xóa món '" + monCanXoa + "' không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (xacNhan == DialogResult.Yes)
            {
                if (sender is Button btnXoa) btnXoa.Enabled = false;

                try
                {
                    Lab03_Bai05_packet p = new Lab03_Bai05_packet
                    {
                        Action = "DELETE",
                        TenMonAn = monCanXoa
                    };

                    Lab03_Bai05_packet response = await SendRequestAsync(serverIP, p, 5);

                    if (response != null && response.Action == "DELETE_SUCCESS")
                    {
                        MessageBox.Show("Đã xóa thành công món: " + monCanXoa, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadMenuAsync();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy món ăn này trên Server để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể kết nối đến Server: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sender is Button xoa) xoa.Enabled = true;
                }
            }
        }

        private async void tim_Click(object sender, EventArgs e)
        {
            string serverIP = txtNhapIPServer.Text.Trim();
            if (string.IsNullOrEmpty(serverIP))
            {
                MessageBox.Show("Vui lòng nhập IP của Server trước khi Tìm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nguoiDongGop = txtNguoiDung.Text.Trim();
            bool isCongDong = rdoCongDong.Checked;

            if (!isCongDong && string.IsNullOrEmpty(nguoiDongGop))
            {
                MessageBox.Show("Vui lòng nhập tên của bạn để tìm món của chính mình!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (sender is Button btnTim) btnTim.Enabled = false;

            try
            {
                Lab03_Bai05_packet p = new Lab03_Bai05_packet
                {
                    NguoiDongGop = nguoiDongGop,
                    Action = isCongDong ? "RANDOM_ALL" : "RANDOM_MINE"
                };

                Lab03_Bai05_packet response = await SendRequestAsync(serverIP, p, 15);

                if (response != null)
                {
                    if (response.Action == "RESULT")
                    {
                        ten_mon.Text = $"{response.TenMonAn} (Bởi: {response.NguoiDongGop})";
                        ten_mon.ForeColor = Color.Black;

                        if (!string.IsNullOrEmpty(response.HinhAnhBase64))
                        {
                            try
                            {
                                byte[] imgBytes = Convert.FromBase64String(response.HinhAnhBase64);
                                using (MemoryStream ms = new MemoryStream(imgBytes))
                                {
                                    anh_mon.Image = new Bitmap(Image.FromStream(ms));
                                    anh_mon.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                            }
                            catch
                            {
                                anh_mon.Image = null;
                            }
                        }
                        else
                        {
                            anh_mon.Image = null;
                        }
                    }
                    else if (response.Action == "EMPTY")
                    {
                        MessageBox.Show("Không tìm thấy món ăn nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ten_mon.Text = "Chưa có món ăn";
                        anh_mon.Image = null;
                    }
                }
                await LoadMenuAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối tới Server: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sender is Button tim) tim.Enabled = true;
            }
            

        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            string serverIP = txtNhapIPServer.Text.Trim();
            if (string.IsNullOrEmpty(serverIP))
            {
                MessageBox.Show("Vui lòng nhập IP của Server trước khi Thêm đóng góp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Lab03_Bai05_Donggopmonan frmDongGop = new Lab03_Bai05_Donggopmonan(serverIP);
            frmDongGop.ShowDialog();

            await LoadMenuAsync();
        }

        private void list_mon_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            e.DrawBackground();
            StringFormat format = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            string tenMon = list_mon.Items[e.Index].ToString();
            using (Brush textBrush = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(tenMon, e.Font, textBrush, e.Bounds, format);
            }
            e.DrawFocusRectangle();
        }

        private void list_mon_SelectedIndexChanged(object sender, EventArgs e) { }
        private void ten_mon_Click(object sender, EventArgs e) { }
        private void anh_mon_Click(object sender, EventArgs e) { }
        private void menu_Click(object sender, EventArgs e) { }
        private void list_mon_Click(object sender, EventArgs e) { }
        private void txtNguoiDung_TextChanged(object sender, EventArgs e) { }
        private void rdoNguoiDung_CheckedChanged(object sender, EventArgs e) { }
        private void rdoCongDong_CheckedChanged(object sender, EventArgs e) { }
        private void lblTenNguoiDung_Click(object sender, EventArgs e) { }
        private void txtNhapIPServer_TextChanged(object sender, EventArgs e) { }
        private void lblNhapIP_Click(object sender, EventArgs e) { }
    }
}