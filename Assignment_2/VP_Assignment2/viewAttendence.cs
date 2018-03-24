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

    public partial class viewAttendence : Form
    {
        int j = 0, k = 0, d = 0, tmp = 0;
        String[] arr = new String[500];
        String[] uniq = new String[500];
        string filename = "D:\\attendence.txt";
        public viewAttendence()
        {
            InitializeComponent();
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

                if (arr[i] == textBox1.Text)
                {
                    MessageBox.Show("Record Found\n" + arr[++i]);

                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main obj = new main();
            this.Hide();
            obj.Show();
        }
    }
}
