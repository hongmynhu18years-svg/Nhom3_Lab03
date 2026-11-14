namespace LAB03
{
    partial class Lab03_Bai05
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab03_Bai05));
            btnServer = new Button();
            btnClient = new Button();
            SuspendLayout();
            // 
            // btnServer
            // 
            btnServer.Anchor = AnchorStyles.None;
            btnServer.BackColor = Color.Transparent;
            btnServer.Cursor = Cursors.Hand;
            btnServer.FlatAppearance.BorderSize = 0;
            btnServer.FlatStyle = FlatStyle.Flat;
            btnServer.Font = new Font("Times New Roman", 25F, FontStyle.Bold);
            btnServer.ForeColor = Color.SaddleBrown;
            btnServer.Location = new Point(207, 260);
            btnServer.Name = "btnServer";
            btnServer.Size = new Size(244, 87);
            btnServer.TabIndex = 0;
            btnServer.Text = "Server";
            btnServer.UseVisualStyleBackColor = false;
            btnServer.Click += btnServer_Click;
            // 
            // btnClient
            // 
            btnClient.Anchor = AnchorStyles.None;
            btnClient.BackColor = Color.Transparent;
            btnClient.Cursor = Cursors.Hand;
            btnClient.FlatAppearance.BorderSize = 0;
            btnClient.FlatStyle = FlatStyle.Flat;
            btnClient.Font = new Font("Times New Roman", 25F, FontStyle.Bold);
            btnClient.ForeColor = Color.SaddleBrown;
            btnClient.Location = new Point(614, 260);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(244, 87);
            btnClient.TabIndex = 1;
            btnClient.Text = "Client";
            btnClient.UseVisualStyleBackColor = false;
            btnClient.Click += btnClient_Click;
            // 
            // Lab03_Bai05
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1029, 570);
            Controls.Add(btnClient);
            Controls.Add(btnServer);
            DoubleBuffered = true;
            Font = new Font("Times New Roman", 13F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Lab03_Bai05";
            Text = "Lab03_Bai05";
            ResumeLayout(false);
        }

        #endregion

        private Button btnServer;
        private Button btnClient;
    }
}