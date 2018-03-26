using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;

namespace VP_Assignment2
{
    public partial class AddStudent : Form
    {
        int j = 0, k = 0, d = 0, tmp = 0;
        String[] arr = new String[500];
        String[] uniq = new String[500];
        string filename = "C:\\Users\\sohaibaftab\\Desktop\\profile.txt";

        public AddStudent()
        {
            InitializeComponent();
        }
        public void addStudent()
        {
           

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            StreamWriter sl = File.AppendText(filename);

            sl.AutoFlush = true;
            sl.WriteLine(id.Text);
            sl.WriteLine(name.Text);
            sl.WriteLine(semster.Text);
            sl.WriteLine(cgpa.Text);
            sl.WriteLine(dept.Text);
            sl.WriteLine(univ.Text);
            sl.Close();
            this.Close();
            main obj = new main();
            obj.Show();
        }
    }
}
