using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LAB03
{
    public partial class Lab03_Bai05 : Form
    {
        public Lab03_Bai05()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            Lab03_Bai05_server serverForm = new Lab03_Bai05_server();
            serverForm.Show();
            //this.Hide();
        }

        private void btnClient_Click(object sender, EventArgs e)
        { 
            Lab03_Bai05_Client clientForm = new Lab03_Bai05_Client();
            clientForm.Show();
            //this.Hide();
        }
    }
}
