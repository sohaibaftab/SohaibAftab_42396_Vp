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
using System.Text.RegularExpressions;

namespace Vp_semester_Project
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void SingUp_Click(object sender, EventArgs e)
        {
            Regex mail = new Regex("^(a-zA-Z0-9){1,25}@(a-zA-Z0-9){1,15}.(a-zA-Z){2,3}$");
            if(mail.IsMatch(textBox5.Text))
            {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\sohaibaftab\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string str = "insert into register(userName,password,firstName,secondName,contact,email,fscMarks,matricMarks,address) VALUES('" + textBox1.Text + "','" + textBox9.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
            SqlCommand comand = new SqlCommand(str, con);
            comand.ExecuteNonQuery();
            con.Close();
            }
            else
                MessageBox.Show("Invalid Email Adress");
        }

        private void Registration_Load(object sender, EventArgs e)
        {


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
