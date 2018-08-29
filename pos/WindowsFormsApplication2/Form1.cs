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
    public partial class POS : Form
    {
        public POS()
        {
            
            
            InitializeComponent();
            totalDiscount.Text = "0";
            add();

        }
        int amount, total = 0, qty = 0, GrandTotal = 0, discount = 0, prod, iid = 0, remaingQty, Removeid = 0, removeAmount = 0, newSheldQty = 0, newRemoveSheldQty=0, removeQty=0;
        string pName, dataBaseqty,size,color,shelfId;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\sohaibaftab\Documents\Pos.mdf;Integrated Security=True;Connect Timeout=30");
        List<string> AuthorList = new List<string>();

// Add items using Add method 


        void add()
        {
            AuthorList.Add("Mahesh Chand");
            AuthorList.Add("Praveen Kumar");
        }
      
        DataTable dt = new DataTable();
        public void ShowData()
        {

            InitializeComponent();
            con.Open();
            string str = "select * from wharehouse";
            SqlCommand comand = new SqlCommand(str, con);
            comand.ExecuteNonQuery();

            SqlDataAdapter obj = new SqlDataAdapter(comand);
            obj.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchData(Search.Text);


        }
       
        public void searchData(string valueToFind)
        {
            try
            {
                con.Open();
                string searchQuery = "SELECT * FROM wharehouse WHERE CONCAT(ProductName,ProductCode) LIKE '%" + valueToFind + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                con.Close();
            }
            catch (Exception)
            { }
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];

                string id = selectedRow.Cells[0].Value.ToString();
                pName = selectedRow.Cells[1].Value.ToString();
                dataBaseqty = selectedRow.Cells[2].Value.ToString();
                AAmount.Text = selectedRow.Cells[3].Value.ToString();
                size = selectedRow.Cells[4].Value.ToString();
                color = selectedRow.Cells[5].Value.ToString();
                shelfId = selectedRow.Cells[6].Value.ToString();

                iid = int.Parse(id);
               
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
            
        }
     
      private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                discount = int.Parse(totalDiscount.Text);

                if (discount < prod && qty < (int.Parse(dataBaseqty)))
                {
                    
                    total = amount * qty - discount;
                    GrandTotal += total - discount;
                    grandTotal.Text = GrandTotal.ToString();
                    
                    getQtyOfShelf(shelfId);
                    
                    updateTable(qty);
                    remaingQty = (int.Parse(dataBaseqty)) - qty;
                    
                    updateTable(remaingQty);
                    searchData(Search.Text);
                    addDataGridView2();
                    clearBill();
                    totalDiscount.Text = "0";


                }
                else
                {
                    MessageBox.Show("Disount should not less then Amount or Your product quantity is greater then stock");
                    clearBill();
                }
            }
            catch (Exception )
            { }
            
            }
        void clearBill()
        {
            AAmount.Text = "";
          Quantity.Text = "";
            product.Text = "";
            amountByCoutomer.Text = "";
            totalDiscount.Text = "0";

            
        }

        private void Quantity_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                amount = int.Parse(AAmount.Text);
                    qty = int.Parse(Quantity.Text);
                    prod = amount * qty;
                    product.Text = prod.ToString();
                    
             
              
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {
                MessageBox.Show("overFlow error");
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string total=grandTotal.Text;
            string cash=amountByCoutomer.Text;
            string change=balance.Text;
            string date = Date.Text;

            Print open = new Print(AuthorList,total,cash,change,date);
            open.Show();

            clearBill();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Time.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Now.ToLongDateString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearBill();
        }

        void updateTable(int qty)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update wharehouse set Qty='" + qty + "'where ProductCode='" + iid + "'";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            { }
            

            
        }
        void addDataGridView2()
        {


            con.Open();
            string str = "insert into TempData(Id,ProductName,Qty,Product,Amount,size,color,discount,Total,shelfNo) VALUES('" + iid + "','" + pName + "','" + qty + "','" + product.Text + "','" + AAmount.Text + "','" + size + "','" + color + "','" + totalDiscount.Text + "','" + total + "','" + shelfId + "')";
            SqlCommand comand = new SqlCommand(str, con);
            comand.ExecuteNonQuery();
            con.Close();
            dataView2();

        }

        public void dataView2()
        {
            try{

            con.Open();
            string str = "select * from TempData";
            SqlCommand comand = new SqlCommand(str, con);
            comand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter obj = new SqlDataAdapter(comand);
            obj.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
            }
            catch (Exception)
            { }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string str = "delete  from TempData";
                SqlCommand comand = new SqlCommand(str, con);

                comand.ExecuteNonQuery();
                con.Close();
                dataView2();
                grandTotal.Text = "0";
                amount=total=qty=GrandTotal=discount=prod=iid =remaingQty=Removeid=removeAmount=newSheldQty=newRemoveSheldQty=removeQty =0;

            }
            catch (Exception)
            { }
            
   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try{
            foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            {
                int Did = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[9].Value);
                int Qtyid = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[8].Value);
                removeQty = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value);
                removeAmount = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[5].Value);
                int removeShelfid = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[10].Value);

                RemoveQtyOfShelf(removeShelfid);
                updateQty(Qtyid, removeQty);
                deleteSelected(Did);
                dataGridView2.Rows.RemoveAt(item.Index);
                searchData(Search.Text);
                

            }
            }
            catch (Exception)
            { }
        }

        void deleteSelected(int d)
        {
            try{
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete From TempData Where sr='" +d + "'";
            MessageBox.Show("Item Remove From Bill Successfully!");
            cmd.ExecuteNonQuery();
            con.Close();
            GrandTotal = GrandTotal - removeAmount;
            grandTotal.Text = (GrandTotal).ToString();
            }
            catch (Exception)
            { }
            


        }
        void updateQty(int qid, int removeQty)
        {
           
            try{

         string con = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\sohaibaftab\Documents\Pos.mdf;Integrated Security=True;Connect Timeout=30");

            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "select * from wharehouse where ProductCode='" + qid + "'";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        string previousQty = oReader["Qty"].ToString();                        
                        int TotalQty = removeQty + int.Parse(previousQty);
                        updateTableQty(TotalQty,qid);

                    }

                }

            }
            }
            catch (Exception)
            { }
            

           

        }
        void updateTableQty(int rQty, int idd)
        {
            try{
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update wharehouse set Qty='" + rQty + "'where ProductCode='" + iid + "'";
            cmd.ExecuteNonQuery();
            searchData(Search.Text);
            con.Close();
            }
            catch (Exception)
            { }
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataView2();
        }

        private void product_TextChanged(object sender, EventArgs e)
        {

        }

        private void grandTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void amountByCoutomer_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (int.Parse(amountByCoutomer.Text) >= GrandTotal)
                {
                    balance.Text = (int.Parse(amountByCoutomer.Text) - GrandTotal).ToString();
                }
                else
                {
                    balance.Text = "0";
                }
            }
            catch(Exception){}
        }

        public void getQtyOfShelf(string id)
        {
            string con = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\sohaibaftab\Documents\Pos.mdf;Integrated Security=True;Connect Timeout=30");
           
            int qid = int.Parse(id);
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                
                string oString = "select * from shelf where Id='" + qid + "'";
                myConnection.Open();
               
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        
                        string previousShelfQty = oReader["Qty"].ToString();

                        newSheldQty = (int.Parse(previousShelfQty) - int.Parse(Quantity.Text));
                        updateShelfQty(qid, newSheldQty);

                    }

                }
                
                //using (SqlDataReader oReader = oCmd.ExecuteReader())
                //{
                //    while (oReader.Read())
                //    {
                        
                //        string previousShelfQty = oReader["Qty"].ToString();
                //        newSheldQty = (int.Parse(previousShelfQty) - int.Parse(dataBaseqty));
                //        updateShelfQty(qid, newSheldQty);
                        


                //    }
                    
                //}
                
            }

        }
        public void RemoveQtyOfShelf(int rd)
        {
            string con = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\sohaibaftab\Documents\Pos.mdf;Integrated Security=True;Connect Timeout=30");

            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "select * from shelf where Id='" + rd + "'";
                myConnection.Open();
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        string newpreviousShelfQty = oReader["Qty"].ToString();
                        newRemoveSheldQty = (int.Parse(newpreviousShelfQty) + removeQty);                      
                        updateShelfQty(rd, newRemoveSheldQty);
                        

                    }

                }
            }
        }
        void updateShelfQty(int ad , int rQty)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update shelf set Qty='" + rQty + "'where Id='" + ad + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("come 12");
            MessageBox.Show(rQty.ToString());
            con.Close();


        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main open = new Main();
            open.Show();
        }






        }

        
    }

