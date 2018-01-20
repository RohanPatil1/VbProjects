using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace TimeGone
{
    public partial class Form1 : Form
    {
        RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        public Form1()
        {
            reg.SetValue("Days_Left", Application.ExecutablePath.ToString());
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Parse("30/04/2018");
            DateTime dt2 = DateTime.Parse(DateTime.Now.ToString());
            int days = -(dt2 - dt1).Days;
            label2.Text = Convert.ToString(days);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form2 myform = new Form2();
            myform.Visible = true;
            this.Visible = false;
        }

        private void miniiii_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
