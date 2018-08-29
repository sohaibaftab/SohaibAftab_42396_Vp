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
    public partial class AddDataInShop : Form
    {
        public AddDataInShop()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\sohaibaftab\Documents\Pos.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {

            if ((txtNumericStringIsValid(textBox2.Text) == false) && ((txtNumericStringIsValid(textBox3.Text) == false)))
            {
                con.Open();
                string str = "insert into wharehouse(ProductName,Qty,Amount,size,color,ShelfNo) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                SqlCommand comand = new SqlCommand(str, con);
                comand.ExecuteNonQuery();
                getQty(textBox6.Text,textBox2.Text);
                MessageBox.Show("Record Inserted Successfully");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                
                con.Close();
            }
            else
                MessageBox.Show("You Enter Wrong Amount Or Quantity");
        }
        public bool txtNumericStringIsValid(string check)
        {
            if (check == string.Empty)
            {
                return true;
            }

            char[] testArr = check.ToCharArray();
            bool testBool = false;

            for (int i = 0; i < testArr.Length; i++)
            {
                if (!char.IsNumber(testArr[i]))
                {
                    testBool = true;
                }
            }

            return testBool;

        }
        public void getQty(string id,string NewQty)
        {
            string con = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\sohaibaftab\Documents\Pos.mdf;Integrated Security=True;Connect Timeout=30");
            
            int qid = int.Parse(id);
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                myConnection.Open();
                string oString = "select * from shelf where Id='" + qid + "'";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
               
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        string previousQty = oReader["Qty"].ToString();
                        int TotalQty =( int.Parse(NewQty) + int.Parse(previousQty));
                        updateTableQty(TotalQty, qid);

                    }

                }
                myConnection.Close();
            }
            
        }
        void updateTableQty(int rQty, int idd)
        {
            
              
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update shelf set Qty='" + rQty + "'where Id='" + idd + "'";
                cmd.ExecuteNonQuery();
                
                con.Close();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main open = new Main();
            open.Show();
        }

       
    }
}
