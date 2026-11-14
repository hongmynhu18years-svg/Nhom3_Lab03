using System.Windows.Forms;
namespace LAB03
{
    partial class Lab03_Bai05_Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab03_Bai05_Client));
            label1 = new Label();
            ten_mon = new Label();
            anh_mon = new PictureBox();
            menu = new Label();
            tim = new Button();
            xoa = new Button();
            them = new Button();
            list_mon = new ListBox();
            rdoCongDong = new RadioButton();
            rdoNguoiDung = new RadioButton();
            txtNguoiDung = new TextBox();
            lblTenNguoiDung = new Label();
            txtNhapIPServer = new TextBox();
            lblNhapIP = new Label();
            ((System.ComponentModel.ISupportInitialize)anh_mon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(613, 100);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // ten_mon
            // 
            ten_mon.Anchor = AnchorStyles.None;
            ten_mon.BackColor = Color.Transparent;
            ten_mon.Font = new Font("Times New Roman", 10F);
            ten_mon.ForeColor = Color.SaddleBrown;
            ten_mon.Location = new Point(264, 100);
            ten_mon.Name = "ten_mon";
            ten_mon.Size = new Size(182, 52);
            ten_mon.TabIndex = 5;
            ten_mon.TextAlign = ContentAlignment.MiddleCenter;
            ten_mon.Click += ten_mon_Click;
            // 
            // anh_mon
            // 
            anh_mon.Anchor = AnchorStyles.None;
            anh_mon.BackColor = Color.Transparent;
            anh_mon.BackgroundImageLayout = ImageLayout.Stretch;
            anh_mon.Location = new Point(273, 186);
            anh_mon.Name = "anh_mon";
            anh_mon.Size = new Size(159, 144);
            anh_mon.SizeMode = PictureBoxSizeMode.StretchImage;
            anh_mon.TabIndex = 6;
            anh_mon.TabStop = false;
            anh_mon.Click += anh_mon_Click;
            // 
            // menu
            // 
            menu.Anchor = AnchorStyles.None;
            menu.AutoSize = true;
            menu.BackColor = Color.Transparent;
            menu.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            menu.ForeColor = Color.SaddleBrown;
            menu.Location = new Point(576, 146);
            menu.Name = "menu";
            menu.Size = new Size(68, 22);
            menu.TabIndex = 7;
            menu.Text = "MENU";
            menu.TextAlign = ContentAlignment.MiddleCenter;
            menu.Click += menu_Click;
            // 
            // tim
            // 
            tim.Anchor = AnchorStyles.None;
            tim.BackColor = Color.Transparent;
            tim.Cursor = Cursors.Hand;
            tim.FlatAppearance.BorderSize = 0;
            tim.FlatStyle = FlatStyle.Flat;
            tim.Font = new Font("Times New Roman", 15F);
            tim.ForeColor = Color.PapayaWhip;
            tim.Location = new Point(110, 109);
            tim.Name = "tim";
            tim.Size = new Size(66, 32);
            tim.TabIndex = 9;
            tim.Text = "Tìm";
            tim.UseVisualStyleBackColor = false;
            tim.Click += tim_Click;
            // 
            // xoa
            // 
            xoa.Anchor = AnchorStyles.None;
            xoa.BackColor = Color.Transparent;
            xoa.Cursor = Cursors.Hand;
            xoa.FlatAppearance.BorderSize = 0;
            xoa.FlatStyle = FlatStyle.Flat;
            xoa.Font = new Font("Times New Roman", 15F);
            xoa.ForeColor = Color.SaddleBrown;
            xoa.Location = new Point(118, 224);
            xoa.Name = "xoa";
            xoa.Size = new Size(66, 41);
            xoa.TabIndex = 10;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = false;
            xoa.Click += xoa_Click;
            // 
            // them
            // 
            them.Anchor = AnchorStyles.None;
            them.BackColor = Color.Transparent;
            them.Cursor = Cursors.Hand;
            them.FlatAppearance.BorderSize = 0;
            them.FlatStyle = FlatStyle.Flat;
            them.Font = new Font("Times New Roman", 15F);
            them.ForeColor = Color.SaddleBrown;
            them.Location = new Point(118, 336);
            them.Name = "them";
            them.Size = new Size(66, 32);
            them.TabIndex = 11;
            them.Text = "Thêm ";
            them.UseVisualStyleBackColor = false;
            them.Click += btnThem_Click;
            // 
            // list_mon
            // 
            list_mon.Anchor = AnchorStyles.None;
            list_mon.BackColor = Color.AntiqueWhite;
            list_mon.DrawMode = DrawMode.OwnerDrawFixed;
            list_mon.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            list_mon.FormattingEnabled = true;
            list_mon.Location = new Point(541, 171);
            list_mon.Name = "list_mon";
            list_mon.Size = new Size(140, 148);
            list_mon.TabIndex = 12;
            list_mon.DrawItem += list_mon_DrawItem;
            list_mon.SelectedIndexChanged += list_mon_SelectedIndexChanged;
            // 
            // rdoCongDong
            // 
            rdoCongDong.AutoSize = true;
            rdoCongDong.BackColor = Color.Linen;
            rdoCongDong.Checked = true;
            rdoCongDong.ForeColor = Color.SaddleBrown;
            rdoCongDong.Location = new Point(492, 19);
            rdoCongDong.Name = "rdoCongDong";
            rdoCongDong.Size = new Size(105, 24);
            rdoCongDong.TabIndex = 13;
            rdoCongDong.TabStop = true;
            rdoCongDong.Text = "Cộng đồng";
            rdoCongDong.UseVisualStyleBackColor = false;
            rdoCongDong.CheckedChanged += rdoCongDong_CheckedChanged;
            // 
            // rdoNguoiDung
            // 
            rdoNguoiDung.AutoSize = true;
            rdoNguoiDung.BackColor = Color.Linen;
            rdoNguoiDung.ForeColor = Color.SaddleBrown;
            rdoNguoiDung.Location = new Point(374, 19);
            rdoNguoiDung.Name = "rdoNguoiDung";
            rdoNguoiDung.Size = new Size(112, 24);
            rdoNguoiDung.TabIndex = 14;
            rdoNguoiDung.Text = "Người dùng";
            rdoNguoiDung.UseVisualStyleBackColor = false;
            rdoNguoiDung.CheckedChanged += rdoNguoiDung_CheckedChanged;
            // 
            // txtNguoiDung
            // 
            txtNguoiDung.Location = new Point(177, 16);
            txtNguoiDung.Name = "txtNguoiDung";
            txtNguoiDung.Size = new Size(191, 27);
            txtNguoiDung.TabIndex = 15;
            txtNguoiDung.TextChanged += txtNguoiDung_TextChanged;
            // 
            // lblTenNguoiDung
            // 
            lblTenNguoiDung.AutoSize = true;
            lblTenNguoiDung.BackColor = Color.AntiqueWhite;
            lblTenNguoiDung.Font = new Font("Times New Roman", 13F, FontStyle.Bold);
            lblTenNguoiDung.ForeColor = Color.SaddleBrown;
            lblTenNguoiDung.Location = new Point(72, 19);
            lblTenNguoiDung.Name = "lblTenNguoiDung";
            lblTenNguoiDung.Size = new Size(104, 20);
            lblTenNguoiDung.TabIndex = 16;
            lblTenNguoiDung.Text = "Tên của bạn";
            lblTenNguoiDung.Click += lblTenNguoiDung_Click;
            // 
            // txtNhapIPServer
            // 
            txtNhapIPServer.Location = new Point(554, 422);
            txtNhapIPServer.Name = "txtNhapIPServer";
            txtNhapIPServer.Size = new Size(191, 27);
            txtNhapIPServer.TabIndex = 17;
            txtNhapIPServer.TextChanged += txtNhapIPServer_TextChanged;
            // 
            // lblNhapIP
            // 
            lblNhapIP.AutoSize = true;
            lblNhapIP.BackColor = Color.AntiqueWhite;
            lblNhapIP.Font = new Font("Times New Roman", 13F, FontStyle.Bold);
            lblNhapIP.ForeColor = Color.SaddleBrown;
            lblNhapIP.Location = new Point(424, 425);
            lblNhapIP.Name = "lblNhapIP";
            lblNhapIP.Size = new Size(124, 20);
            lblNhapIP.TabIndex = 18;
            lblNhapIP.Text = "Nhập IP server";
            lblNhapIP.Click += lblNhapIP_Click;
            // 
            // Lab03_Bai05
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(807, 452);
            Controls.Add(lblNhapIP);
            Controls.Add(txtNhapIPServer);
            Controls.Add(lblTenNguoiDung);
            Controls.Add(txtNguoiDung);
            Controls.Add(rdoNguoiDung);
            Controls.Add(rdoCongDong);
            Controls.Add(list_mon);
            Controls.Add(them);
            Controls.Add(xoa);
            Controls.Add(tim);
            Controls.Add(menu);
            Controls.Add(anh_mon);
            Controls.Add(ten_mon);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 13F);
            Margin = new Padding(4);
            Name = "Lab03_Bai05";
            Text = "Lab03_Bai05";
            Load += Lab03_Bai05_Load;
            ((System.ComponentModel.ISupportInitialize)anh_mon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label ten_mon;
        private PictureBox anh_mon;
        private Label menu;
        private Button tim;
        private Button xoa;
        private Button them;
        private ListBox list_mon;
        private RadioButton rdoCongDong;
        private RadioButton rdoNguoiDung;
        private TextBox txtNguoiDung;
        private Label lblTenNguoiDung;
        private TextBox txtNhapIPServer;
        private Label lblNhapIP;
    }
}