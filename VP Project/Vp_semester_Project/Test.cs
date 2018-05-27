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
using System.Timers;
using System.Threading;


namespace Vp_semester_Project
{
    public partial class Test : Form
    {
        private string[] ques = new string[10000];
        private string[] ans = new string[10000];
        private string[] correctAns = new string[10000];
        int i=0,j=0,k=0,l=0,result=0,t=0,p=0,anss=0,duration = 20,QNumber=1;
        public Test()
        {
            InitializeComponent();
            readData();
            questions.Text = ques[j++];
            optionA.Text = ques[j++];
            optionB.Text = ques[j++];
            optionC.Text = ques[j++];
            radioButton4.Text = ques[j++];
            Unchecked();
            label2.Text = p.ToString();
            label3.Text = QNumber.ToString();
           
            qNo.Text = QNumber.ToString();
            



        }
        public void readData()
        {
            string con = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\sohaibaftab\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from Questions ";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while(oReader.Read())
                    {
                        
                            ques[i++] = oReader["questions"].ToString();
                            ques[i++] = oReader["optionOne"].ToString();
                            ques[i++] = oReader["optionTwo"].ToString();
                            ques[i++] = oReader["optionThree"].ToString();
                            ques[i++] = oReader["optionFour"].ToString();
                            correctAns[l++] = oReader["Answer"].ToString();
                            duration += 20;
                            p++;
                    }

                    myConnection.Close();
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
                 saveAnswer();    
                 Unchecked();
                questions.Text = ques[j++];
                optionA.Text = ques[j++];
                optionB.Text = ques[j++];
                optionC.Text = ques[j++];
                radioButton4.Text = ques[j++];
                t++;
                QNumber++;
                label3.Text = QNumber.ToString();
                qNo.Text = QNumber.ToString();
               
            if(t==p)
            {
                 
                
                tabControl1.SelectedTab = tabPage3;
                label4.Text=result.ToString();
                
            }
         

        }


        private void button4_Click(object sender, EventArgs e)
        {
            j = j-10;
            
            questions.Text = ques[j++];
            optionA.Text = ques[j++];
            optionB.Text = ques[j++];
            optionC.Text = ques[j++];
            radioButton4.Text = ques[j++];
            
        }

        public void Unchecked()
        {
            optionA.Checked = false;
            optionB.Checked = false;
            optionC.Checked = false;
            radioButton4.Checked = false;
        }
        public void saveAnswer()
        {
            if (optionA.Checked == true)
            {
                ans[k] = optionA.Text;
            }
            if (optionB.Checked == true)
            {
                ans[k] = optionB.Text;
            }
            if (optionC.Checked == true)
            {
                ans[k] = optionC.Text;
            }
            if (radioButton4.Checked == true)
            {
                ans[k] = radioButton4.Text;
            }
            if (optionA.Checked && optionB.Checked && optionC.Checked && radioButton4.Checked == false)
            {
                ans[k] = "null";
            }
            k++;
            if (ans[anss] == correctAns[anss])
            {
                result = result + 10;
                


            }
            
            anss++;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            duration--;
            label1.Text = duration.ToString();
            if (duration == 0)
            {
                MessageBox.Show("Time up!!");
                tabControl1.SelectedTab = tabPage3;
                timer1.Stop();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            tabControl1.SelectedTab = tabPage2;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

       
        
    }
}
