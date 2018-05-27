using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vp_semester_Project
{
    public partial class MainLogin : Form
    {
        public MainLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin aLogin = new AdminLogin();
            aLogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login userLogin = new Login();
            userLogin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration();
            reg.Show();
        }

        private void MainLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
