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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void SingUp_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\sohaibaftab\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string str = "insert into singup(Id,firstName,secondName,contact,email,fscMarks,matricMarks,address) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
            SqlCommand comand = new SqlCommand(str, con);
            comand.ExecuteNonQuery();
            con.Close();
        }

        private void Registration_Load(object sender, EventArgs e)
        {


        }
    }
}
