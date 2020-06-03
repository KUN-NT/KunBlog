using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateModelTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string result=DataHelper.ConnDataBase($"server={txtIP.Text};user id={txtUser.Text};password={txtPassword.Text};database={txtDataBase.Text}");
            if (result == "Y")
            {
                TableHome home = new TableHome(txtDataBase.Text);
                home.Show();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtIP.Text = "127.0.0.1";
            txtPort.Text = "3306";
            txtUser.Text = "root";
            txtPassword.Text = "123456";
            txtDataBase.Text = "blog_sdm";
        }
    }
}
