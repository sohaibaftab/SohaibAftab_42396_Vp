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
    public partial class Top3Cgpa : Form
    {
        int j = 0, k = 0, d = 0, tmp = 0;
        String[] arr = new String[500];
        String[] uniq = new String[500];
        string filename = "D:\\profile.txt";
        public Top3Cgpa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader re = File.OpenText(filename);
            List<string> gpaList = new List<string>();
            string str;
            do
            {
                re.ReadLine();
                re.ReadLine();
                re.ReadLine();
                str = re.ReadLine();
                gpaList.Add(str);
                re.ReadLine();
                re.ReadLine();
                k++;
            }
            while (!re.EndOfStream);
            Array.Reverse(arr);
            gpaList.Sort();
            gpaList.Reverse();
            top1.Text= gpaList[0];
            top2.Text=gpaList[1];
            top3.Text=gpaList[2];


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            main obj1 = new main();
            this.Hide();
            obj1.Show();
        }
    }
}
