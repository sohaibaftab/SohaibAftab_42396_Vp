using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vp_semester_Project
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\sohaibaftab\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From AdminLogin where userName ='" + textBox1.Text + "'and password='" + textBox2.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Admin admen = new Admin();
                    admen.Show();
                }
                else
                    MessageBox.Show("invalid");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainLogin back = new MainLogin();
            back.Show();
        }
    }
}
