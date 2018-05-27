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
            try
            {
                Regex mail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (mail.IsMatch(email.Text))
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\sohaibaftab\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    string str = "insert into AddUser(userName,password,firstName,secondName,contact,email,fscMarks,matricMarks,address) VALUES('" + username.Text + "','" + password.Text + "','" + firstName.Text + "','" + secondName.Text + "','" + contactNo.Text + "','" + email.Text + "','" + fsc.Text + "','" + matric.Text + "','" + address.Text + "')";
                    SqlCommand comand = new SqlCommand(str, con);
                    comand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("student successfully added");
                    username.Text = "";
                    firstName.Text = "";
                    secondName.Text = "";
                    contactNo.Text = "";
                    email.Text = "";
                    fsc.Text = "";
                    matric.Text = "";
                    address.Text = "";
                }
                else
                    MessageBox.Show("Invalid Email Adress");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainLogin back = new MainLogin();
            back.Show();
        }
    }
}
