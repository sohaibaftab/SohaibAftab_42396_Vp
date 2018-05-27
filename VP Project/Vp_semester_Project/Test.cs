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
        string RNumber;
        int quesInc=0,j=0,ansCheck=0,orignalAns=0,result=0,countQues=0,addQues=0,anss=0,duration = 20,QNumber=1;
        public Test( string  roll)
        {
            try
            {
                InitializeComponent();
                readData();
                questions.Text = ques[j++];
                optionA.Text = ques[j++];
                optionB.Text = ques[j++];
                optionC.Text = ques[j++];
                radioButton4.Text = ques[j++];
                Unchecked();
                label2.Text = addQues.ToString();
                RemaingingQuestions.Text = QNumber.ToString();
                qNo.Text = QNumber.ToString();
                RNumber = roll;
                table.Hide();
                QNumber++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }    

        public void readData()
        {
            try
            {

                string con = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\sohaibaftab\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30";
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from Questions ";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {

                            ques[quesInc++] = oReader["questions"].ToString();
                            ques[quesInc++] = oReader["optionOne"].ToString();
                            ques[quesInc++] = oReader["optionTwo"].ToString();
                            ques[quesInc++] = oReader["optionThree"].ToString();
                            ques[quesInc++] = oReader["optionFour"].ToString();
                            correctAns[orignalAns++] = oReader["Answer"].ToString();
                            duration += 20;
                            addQues++;
                        }

                        myConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                saveAnswer();
                Unchecked();
                questions.Text = ques[j++];
                optionA.Text = ques[j++];
                optionB.Text = ques[j++];
                optionC.Text = ques[j++];
                radioButton4.Text = ques[j++];
                countQues++;
                
                RemaingingQuestions.Text = QNumber.ToString();
                qNo.Text = QNumber.ToString();

                if (countQues == addQues)
                {
                    tabControl1.SelectedTab = tabPage3;  

                }
                QNumber++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }     

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
                ans[ansCheck] = optionA.Text;
            }
            if (optionB.Checked == true)
            {
                ans[ansCheck] = optionB.Text;
            }
            if (optionC.Checked == true)
            {
                ans[ansCheck] = optionC.Text;
            }
            if (radioButton4.Checked == true)
            {
                ans[ansCheck] = radioButton4.Text;
            }
            if (optionA.Checked && optionB.Checked && optionC.Checked && radioButton4.Checked == false)
            {
                ans[ansCheck] = "null";
            }
            ansCheck++;
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

        public float CalulateAggregate(float Fsc, float matric)
        {
           
            float fscpercentage = (Fsc / 1100) * 15;
            float MatricPercentage = ((matric) / 1050) * 10;
            float score = result;
            
            float resultPercenatge = (score / QNumber) * 75;
            float Aggregate = fscpercentage + MatricPercentage+score ;
            return  Aggregate;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                table.Show();
                string con = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\sohaibaftab\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30";
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from AddUser where RollNo='" + int.Parse(RNumber) + "'";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {

                            rollNumber.Text = oReader["RollNo"].ToString();
                            name.Text = oReader["firstName"].ToString();
                            fscMarks.Text = oReader["fscMarks"].ToString();
                            matricMarks.Text = oReader["matricMarks"].ToString();
                        }

                        myConnection.Close();
                    }
                    testScore.Text = result.ToString();
                    float f = float.Parse(fscMarks.Text);
                    float t = float.Parse(fscMarks.Text);
                    Aggregate.Text = (CalulateAggregate(f, t).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainLogin mainScreen = new MainLogin();
            mainScreen.Show();
        }

       
        
    }
}
