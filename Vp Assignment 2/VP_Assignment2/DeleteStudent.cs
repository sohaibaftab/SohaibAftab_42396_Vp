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
    public partial class DeleteStudent : Form
    {
        int j = 0, k = 0, d = 0, tmp = 0;
        String[] arr = new String[500];
        String[] uniq = new String[500];
        string filename = "C:\\Users\\sohaibaftab\\Desktop\\profile.txt";
        public DeleteStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] dee = new String[500];
            StreamReader read = new StreamReader(filename);

            do
            {
                arr[k] = read.ReadLine();
                k++;
            }
            while (!read.EndOfStream);
            for (int i = 0; i < k; i++)
            {
                if (delete.Text == arr[i])
                {
                    MessageBox.Show("Record found and Deleted");
                    i = i + 5;

                }
                else
                    dee[d] = arr[i];
                d++;

            }


            read.Close();
            StreamWriter write = File.CreateText(filename);
            for (int i = 0; i < k; i++)
            {
                write.WriteLine(dee[i]);

            }
            write.Close();

        }
    }
}
