using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartHouseSimulator
{
    public partial class Login : Form
    {
        MainForm mainFrm=new MainForm();
        public Login()
        {
            //mainFrm = MF;
            //mainFrm.Show();
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower() == "admin" && textBox2.Text == "123456")
            {
                mainFrm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Username or password provided is not correct","Login Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
