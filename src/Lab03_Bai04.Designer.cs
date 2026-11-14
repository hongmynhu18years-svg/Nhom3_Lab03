namespace LAB03
{
    partial class Lab03_Bai04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab03_Bai04));
            pictureBoxMouseDown = new PictureBox();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            btnDaoPhoPiano = new Button();
            btnMai = new Button();
            btnGapLaiChiBau = new Button();
            btnTarot = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            txtCustomerName = new TextBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            lblThongBao = new Label();
            lnkAdmin_LinkClicked = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMouseDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxMouseDown
            // 
            pictureBoxMouseDown.BackgroundImage = (Image)resources.GetObject("pictureBoxMouseDown.BackgroundImage");
            pictureBoxMouseDown.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxMouseDown.Dock = DockStyle.Top;
            pictureBoxMouseDown.Location = new Point(0, 0);
            pictureBoxMouseDown.Name = "pictureBoxMouseDown";
            pictureBoxMouseDown.Size = new Size(1123, 49);
            pictureBoxMouseDown.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMouseDown.TabIndex = 1;
            pictureBoxMouseDown.TabStop = false;
            pictureBoxMouseDown.MouseDown += pictureBoxMouseDown_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(1059, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(52, 34);
            btnClose.TabIndex = 2;
            btnClose.TabStop = false;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximize.Location = new Point(1001, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(52, 34);
            btnMaximize.TabIndex = 3;
            btnMaximize.TabStop = false;
            btnMaximize.Text = "❐";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.Location = new Point(943, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(52, 34);
            btnMinimize.TabIndex = 4;
            btnMinimize.TabStop = false;
            btnMinimize.Text = "—";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnDaoPhoPiano
            // 
            btnDaoPhoPiano.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDaoPhoPiano.BackgroundImage = Properties.Resources.Screenshot_2026_10_15_013803;
            btnDaoPhoPiano.BackgroundImageLayout = ImageLayout.Stretch;
            btnDaoPhoPiano.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDaoPhoPiano.Location = new Point(306, 196);
            btnDaoPhoPiano.Name = "btnDaoPhoPiano";
            btnDaoPhoPiano.Size = new Size(105, 154);
            btnDaoPhoPiano.TabIndex = 1;
            btnDaoPhoPiano.UseVisualStyleBackColor = true;
            btnDaoPhoPiano.Click += btnDaoPhoPiano_Click;
            // 
            // btnMai
            // 
            btnMai.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMai.BackgroundImage = Properties.Resources.Screenshot_2026_10_15_014023;
            btnMai.BackgroundImageLayout = ImageLayout.Stretch;
            btnMai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMai.Location = new Point(448, 196);
            btnMai.Name = "btnMai";
            btnMai.Size = new Size(105, 154);
            btnMai.TabIndex = 2;
            btnMai.UseVisualStyleBackColor = true;
            btnMai.Click += btnMai_Click;
            // 
            // btnGapLaiChiBau
            // 
            btnGapLaiChiBau.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGapLaiChiBau.BackgroundImage = Properties.Resources.Screenshot_2026_10_15_014225;
            btnGapLaiChiBau.BackgroundImageLayout = ImageLayout.Stretch;
            btnGapLaiChiBau.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGapLaiChiBau.Location = new Point(591, 196);
            btnGapLaiChiBau.Name = "btnGapLaiChiBau";
            btnGapLaiChiBau.Size = new Size(105, 154);
            btnGapLaiChiBau.TabIndex = 3;
            btnGapLaiChiBau.UseVisualStyleBackColor = true;
            btnGapLaiChiBau.Click += btnGapLaiChiBau_Click;
            // 
            // btnTarot
            // 
            btnTarot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTarot.BackgroundImage = Properties.Resources.Screenshot_2026_10_15_014406;
            btnTarot.BackgroundImageLayout = ImageLayout.Stretch;
            btnTarot.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTarot.Location = new Point(730, 196);
            btnTarot.Name = "btnTarot";
            btnTarot.Size = new Size(105, 154);
            btnTarot.TabIndex = 4;
            btnTarot.UseVisualStyleBackColor = true;
            btnTarot.Click += btnTarot_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(265, 161);
            label1.Name = "label1";
            label1.Size = new Size(172, 22);
            label1.TabIndex = 9;
            label1.Text = "Đào, phở và piano";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(479, 161);
            label3.Name = "label3";
            label3.Size = new Size(42, 22);
            label3.TabIndex = 11;
            label3.Text = "Mai";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(574, 161);
            label4.Name = "label4";
            label4.Size = new Size(142, 22);
            label4.TabIndex = 12;
            label4.Text = "Gặp lại chị bầu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(749, 161);
            label5.Name = "label5";
            label5.Size = new Size(58, 22);
            label5.TabIndex = 13;
            label5.Text = "Tarot";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Tahoma", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(432, 9);
            label6.Name = "label6";
            label6.Size = new Size(275, 48);
            label6.TabIndex = 14;
            label6.Text = "Select Movie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(221, 87);
            label2.Name = "label2";
            label2.Size = new Size(205, 29);
            label2.TabIndex = 15;
            label2.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            txtCustomerName.BackColor = Color.MediumPurple;
            txtCustomerName.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCustomerName.ForeColor = SystemColors.Window;
            txtCustomerName.Location = new Point(432, 87);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(329, 29);
            txtCustomerName.TabIndex = 0;
            //txtCustomerName.Click += txtCustomerName_Click;
            txtCustomerName.TextChanged += txtCustomerName_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.BurlyWood;
            label7.Location = new Point(322, 365);
            label7.Name = "label7";
            label7.Size = new Size(494, 22);
            label7.TabIndex = 17;
            label7.Text = "Sử dụng phím Tab/Enter hoặc Click vào poster để chọn phim";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.cinema;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1123, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblThongBao
            // 
            lblThongBao.AutoSize = true;
            lblThongBao.BackColor = Color.Transparent;
            lblThongBao.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongBao.ForeColor = Color.OrangeRed;
            lblThongBao.Location = new Point(369, 129);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(0, 22);
            lblThongBao.TabIndex = 18;
            // 
            // lnkAdmin_LinkClicked
            // 
            lnkAdmin_LinkClicked.ActiveLinkColor = Color.BurlyWood;
            lnkAdmin_LinkClicked.AutoSize = true;
            lnkAdmin_LinkClicked.BackColor = Color.Transparent;
            lnkAdmin_LinkClicked.ForeColor = Color.Transparent;
            lnkAdmin_LinkClicked.LinkColor = Color.White;
            lnkAdmin_LinkClicked.Location = new Point(911, 400);
            lnkAdmin_LinkClicked.Name = "lnkAdmin_LinkClicked";
            lnkAdmin_LinkClicked.Size = new Size(180, 25);
            lnkAdmin_LinkClicked.TabIndex = 19;
            lnkAdmin_LinkClicked.TabStop = true;
            lnkAdmin_LinkClicked.Text = "⚙ Quản lý hệ thống";
            lnkAdmin_LinkClicked.Click += lnkAdmin_LinkClicked_Click;
            // 
            // Bai05
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1123, 450);
            Controls.Add(lnkAdmin_LinkClicked);
            Controls.Add(lblThongBao);
            Controls.Add(label7);
            Controls.Add(txtCustomerName);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnTarot);
            Controls.Add(btnGapLaiChiBau);
            Controls.Add(btnMai);
            Controls.Add(btnDaoPhoPiano);
            Controls.Add(btnMinimize);
            Controls.Add(btnMaximize);
            Controls.Add(btnClose);
            Controls.Add(pictureBoxMouseDown);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bai05";
            Text = "Bai05";
            Load += Bai05_Load;
            Shown += Bai05_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBoxMouseDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxMouseDown;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
        private Button btnDaoPhoPiano;
        private Button btnMai;
        private Button btnGapLaiChiBau;
        private Button btnTarot;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label2;
        private TextBox txtCustomerName;
        private Label label7;
        private PictureBox pictureBox1;
        private Label lblThongBao;
        private LinkLabel lnkAdmin_LinkClicked;
    }
}