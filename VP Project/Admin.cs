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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\sohaibaftab\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string str = "insert into Questions(questions,optionOne,optionTwo,OptionThree,optionFour,Answer) VALUES('" + Question.Text + "','" + A.Text + "','" + B.Text + "','" + C.Text + "','" + D.Text + "','" + Answer.Text+ "')";
            SqlCommand comand = new SqlCommand(str, con);
            comand.ExecuteNonQuery();
            con.Close();
        }
    }
}
