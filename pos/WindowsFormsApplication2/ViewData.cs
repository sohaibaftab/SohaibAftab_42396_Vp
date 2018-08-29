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
    public partial class ViewData : Form
    {
        public ViewData()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\sohaibaftab\Documents\Pos.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Shop")
            {
                con.Open();
                string str = "select * from wharehouse";
                SqlCommand comand = new SqlCommand(str, con);
                comand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter obj = new SqlDataAdapter(comand);
                obj.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            if (comboBox1.Text == "WareHouse")
            {
                con.Open();
                string str = "select * from stockWharehouse";
                SqlCommand comand = new SqlCommand(str, con);
                comand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter obj = new SqlDataAdapter(comand);
                obj.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            if (comboBox1.Text == "Shelf")
            {
                con.Open();
                string str = "select * from shelf";
                SqlCommand comand = new SqlCommand(str, con);
                comand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter obj = new SqlDataAdapter(comand);
                obj.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

        }
        public void searchData(string valueToFind)
        {
            try
            {
                if (comboBox1.Text == "Shop")
                {
                    con.Open();
                    string searchQuery = "SELECT * FROM wharehouse WHERE CONCAT(ProductName,ProductCode) LIKE '%" + valueToFind + "%'";
                    SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, con);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    con.Close();
                }
                if (comboBox1.Text == "WareHouse")
                {
                    con.Open();
                    string searchQuery = "SELECT * FROM stockWharehouse WHERE CONCAT(SackCode,SackType) LIKE '%" + valueToFind + "%'";
                    SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, con);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    con.Close();
                }
                
            }
            catch (Exception)
            { }


        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            searchData(Search.Text);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main open = new Main();
            open.Show();
        }




    }
}
