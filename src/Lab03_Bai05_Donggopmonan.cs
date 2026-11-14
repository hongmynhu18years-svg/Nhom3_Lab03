using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03
{
    public partial class Lab03_Bai05_Donggopmonan : Form
    {
        // ==========================================
        // CẤU HÌNH SERVER
        // ==========================================

        private const int SERVER_PORT = 8888;
        private const int TIMEOUT_SECONDS = 30;
        private const int MAX_RESPONSE_SIZE = 50 * 1024 * 1024;

        private string duongDanAnhGoc = "";
        private string serverIP;

        // Nhận chuỗi IP từ Form chính truyền sang
        public Lab03_Bai05_Donggopmonan(string ip)
        {
            InitializeComponent();
            this.serverIP = ip;
        }

        // ==========================================
        // CHỌN HÌNH ẢNH MÓN ĂN
        // ==========================================

        private void add_picture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFile.Title = "Chọn hình ảnh món ăn";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    duongDanAnhGoc = openFile.FileName;

                    MessageBox.Show(
                        "Đã chọn ảnh: " + Path.GetFileName(duongDanAnhGoc),
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }

        // ==========================================
        // HÀM GỬI VÀ NHẬN JSON QUA TCP (DÙNG IP ĐỘNG)
        // ==========================================

        private async Task<Lab03_Bai05_packet> SendPacketAsync(Lab03_Bai05_packet packet)
        {
            using (CancellationTokenSource cts = new CancellationTokenSource(TimeSpan.FromSeconds(TIMEOUT_SECONDS)))
            using (TcpClient client = new TcpClient())
            {
                await client.ConnectAsync(this.serverIP, SERVER_PORT, cts.Token);

                using (NetworkStream stream = client.GetStream())
                {
                    string json = JsonSerializer.Serialize(packet);
                    byte[] requestData = Encoding.UTF8.GetBytes(json);

                    await stream.WriteAsync(requestData.AsMemory(), cts.Token);
                    await stream.FlushAsync(cts.Token);

                    client.Client.Shutdown(SocketShutdown.Send);

                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        byte[] buffer = new byte[8192];
                        int bytesRead;

                        while ((bytesRead = await stream.ReadAsync(buffer.AsMemory(), cts.Token)) > 0)
                        {
                            if (memoryStream.Length + bytesRead > MAX_RESPONSE_SIZE)
                            {
                                throw new Exception("Dữ liệu phản hồi vượt quá giới hạn cho phép.");
                            }
                            memoryStream.Write(buffer, 0, bytesRead);
                        }

                        if (memoryStream.Length == 0)
                        {
                            throw new Exception("Server không gửi dữ liệu phản hồi.");
                        }

                        string jsonResponse = Encoding.UTF8.GetString(memoryStream.ToArray());
                        Lab03_Bai05_packet? response = JsonSerializer.Deserialize<Lab03_Bai05_packet>(jsonResponse);

                        if (response == null)
                        {
                            throw new Exception("Không thể đọc dữ liệu phản hồi từ Server.");
                        }

                        return response;
                    }
                }
            }
        }

        // ==========================================
        // GỬI ĐÓNG GÓP MÓN ĂN
        // ==========================================

        private async void send_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TenNguoiDongGop.Text) ||
                string.IsNullOrWhiteSpace(txt_TenMonAnDongGop.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập đủ tên người và tên món!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            Button? btnSend = sender as Button;
            if (btnSend != null)
                btnSend.Enabled = false;

            try
            {
                string base64Image = "";

                if (!string.IsNullOrEmpty(duongDanAnhGoc) && File.Exists(duongDanAnhGoc))
                {
                    byte[] imageArray = await File.ReadAllBytesAsync(duongDanAnhGoc);
                    base64Image = Convert.ToBase64String(imageArray);
                }

                Lab03_Bai05_packet packet = new Lab03_Bai05_packet
                {
                    Action = "ADD",
                    TenMonAn = txt_TenMonAnDongGop.Text.Trim(),
                    NguoiDongGop = txt_TenNguoiDongGop.Text.Trim(),
                    HinhAnhBase64 = base64Image
                };

                Lab03_Bai05_packet response = await SendPacketAsync(packet);

                if (response.Action == "ERROR")
                {
                    MessageBox.Show(
                        response.TenMonAn,
                        "Từ chối đóng góp",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                MessageBox.Show(
                    "Đã gửi đóng góp tới Server thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                txt_TenNguoiDongGop.Clear();
                txt_TenMonAnDongGop.Clear();
                duongDanAnhGoc = "";

                await LoadDanhSachAsync();
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show(
                    "Kết nối Server quá thời gian chờ!",
                    "Timeout",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể gửi đóng góp đến Server.\n\nLỗi: " + ex.Message,
                    "Lỗi kết nối",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                if (btnSend != null && !btnSend.IsDisposed)
                    btnSend.Enabled = true;
            }
        }

        // ==========================================
        // TẢI DANH SÁCH MÓN ĂN ĐÓNG GÓP
        // ==========================================

        private async Task LoadDanhSachAsync()
        {
            try
            {
                Lab03_Bai05_packet packet = new Lab03_Bai05_packet
                {
                    Action = "GET_ALL_DETAILS"
                };

                Lab03_Bai05_packet response = await SendPacketAsync(packet);

                if (response.Action == "ERROR")
                {
                    throw new Exception(response.TenMonAn);
                }

                if (response.Action != "DETAILS_RESULT")
                {
                    throw new Exception("Server trả về dữ liệu không hợp lệ.");
                }

                if (string.IsNullOrWhiteSpace(response.TenMonAn))
                {
                    listView1.Items.Clear();
                    return;
                }

                using (JsonDocument doc = JsonDocument.Parse(response.TenMonAn))
                {
                    JsonElement root = doc.RootElement;

                    if (root.ValueKind != JsonValueKind.Array)
                    {
                        throw new Exception("Dữ liệu danh sách không đúng định dạng.");
                    }

                    List<ListViewItem> danhSach = new List<ListViewItem>();

                    foreach (JsonElement element in root.EnumerateArray())
                    {
                        string stt = GetJsonValue(element, "STT");
                        string nguoi = GetJsonValue(element, "NguoiDongGop");
                        string mon = GetJsonValue(element, "TenMonAn");
                        string time = GetJsonValue(element, "ThoiGian");

                        ListViewItem item = new ListViewItem(stt);
                        item.SubItems.Add(nguoi);
                        item.SubItems.Add(mon);
                        item.SubItems.Add(time);

                        danhSach.Add(item);
                    }

                    listView1.BeginUpdate();
                    try
                    {
                        listView1.Items.Clear();
                        listView1.View = View.Details;
                        listView1.Items.AddRange(danhSach.ToArray());
                    }
                    finally
                    {
                        listView1.EndUpdate();
                    }
                }
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show(
                    "Quá thời gian chờ khi tải danh sách!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách đóng góp.\n\nLỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ==========================================
        // HÀM ĐỌC GIÁ TRỊ TỪ JSON
        // ==========================================

        private string GetJsonValue(JsonElement element, string propertyName)
        {
            if (!element.TryGetProperty(propertyName, out JsonElement value))
            {
                return "";
            }

            if (value.ValueKind == JsonValueKind.Null)
                return "";

            return value.ToString();
        }

        // ==========================================
        // CHUYỂN TAB & FORM LOAD
        // ==========================================

        private async void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                await LoadDanhSachAsync();
            }
        }

        private async void Donggopmonan_Load(object sender, EventArgs e)
        {
            await LoadDanhSachAsync();
        }

        private void xem_danh_gia_Click(object sender, EventArgs e) { }
        private void tabPage1_Click(object sender, EventArgs e) { }
        private void TenNguoiDongGop_Click(object sender, EventArgs e) { }
        private void txt_TenNguoiDongGop_TextChanged(object sender, EventArgs e) { }
        private void TenMonAnDongGop_Click(object sender, EventArgs e) { }
        private void txt_TenMonAnDongGop_TextChanged(object sender, EventArgs e) { }
    }
}