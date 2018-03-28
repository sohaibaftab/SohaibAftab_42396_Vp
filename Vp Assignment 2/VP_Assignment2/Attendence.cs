using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VP_Assignment2
{
    public partial class Attendence : Form
    {
        int j = 0, k = 0, d = 0, tmp = 0;
        String[] arr = new String[500];
        String[] uniq = new String[500];
        string filename = "profile.txt";
        public Attendence()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] q = new String[500];
            int t = 0;
            StreamReader re = File.OpenText("profile.txt");

            do
            {
                re.ReadLine();
                arr[k] = re.ReadLine();
                re.ReadLine();
                re.ReadLine();
                re.ReadLine();
                re.ReadLine();
                k++;
            }
            while (!re.EndOfStream);

                for (int i = 0; i < k; i++)
                
                    if (arr[i] == Atten.Text)
                    {
                        
                        q[d] = Atten.Text;
                        d++;
                        
                        if (radioButton1.Checked==true)
                        {
                            q[d] = "A";
                        }
                        if (radioButton2.Checked==true)
                        {
                            q[d] = "P";
                        }
                        MessageBox.Show("Name found and attendence is marked");
                        Atten.Text = "";
                        

                    }
                
            

                re.Close();
                StreamWriter write = File.AppendText("attendence.txt");
                for (int i = 0; i < k; i++)
                {
                    write.WriteLine(q[i]);

                }
                write.Close();

            }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            main obj1 = new main();
            this.Hide();
            obj1.Show();
        }
    }
}
