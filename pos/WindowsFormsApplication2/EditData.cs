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

namespace WindowsFormsApplication2
{
    public partial class EditData : Form
    {
        public EditData()
        {
            InitializeComponent();
        }
        int newSheldQt=0;
        string shelfid;
        string shelfQty;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\sohaibaftab\Documents\Pos.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Shop")
            {
                con.Open();
                sda = new SqlDataAdapter(@"select * from wharehouse", con);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            if (comboBox1.Text == "WareHouse")
            {
                con.Open();
                sda = new SqlDataAdapter(@"select * from stockWharehouse", con);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main open = new Main();
            open.Show();
        }
        
       
       
    }
}
