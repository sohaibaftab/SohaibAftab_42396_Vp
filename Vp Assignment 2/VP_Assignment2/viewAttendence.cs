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
        public viewAttendence()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            StreamReader re = File.OpenText("C:\\Users\\sohaibaftab\\Desktop\\attendence.txt");
            do
            {

                textBox1.Text = re.ReadLine();
                

            }
            while (!re.EndOfStream);


        }
    }
}
