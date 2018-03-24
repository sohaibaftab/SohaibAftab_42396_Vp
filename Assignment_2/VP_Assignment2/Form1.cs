using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Assignment2
{

    public partial class Form1 : Form
    {
        int j = 0, k = 0, d = 0, tmp = 0;
        String[] arr = new String[500];
        String[] uniq = new String[500];
        string filename = "C:\\Users\\sohaibaftab\\Desktop\\profile.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form1 obj1 = new Form1();
            this.Hide();
            main obj = new main();
            obj.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
