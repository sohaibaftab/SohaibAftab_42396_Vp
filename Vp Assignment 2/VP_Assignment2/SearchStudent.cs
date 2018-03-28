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
    public partial class SearchStudent : Form
    {
        int j = 0, k = 0, d = 0, tmp = 0;
        String[] arr = new String[500];
        String[] uniq = new String[500];
        string filename = "profile.txt";
        public SearchStudent()
        {
            InitializeComponent();
        }

        private void searchid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader re = File.OpenText(filename);

            do
            {
                arr[k] = re.ReadLine();
                k++;
            }
            while (!re.EndOfStream);
            for (int i = 0; i < k; i++)
            {

                if (arr[i] == searchid.Text)
                {
                    MessageBox.Show("Record Found");
                    sid.Text= arr[i];
                    sname.Text=arr[++i];
                    ssemster.Text= arr[++i];
                    scgpa.Text=arr[++i];
                    sdept.Text=arr[++i];
                    suniv.Text=arr[++i];

                }


            }
            re.Close();


        }

        private void sid_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
