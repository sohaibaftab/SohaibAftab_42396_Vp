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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewAttendence obj7 = new viewAttendence();
            obj7.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStudent obj2 = new AddStudent();
            obj2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchStudent obj3 = new SearchStudent();
            obj3.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteStudent obj4 = new DeleteStudent();
            obj4.Show();
            main obj = new main();
            obj.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Top3Cgpa obj4 = new Top3Cgpa();
            obj4.Show();
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Attendence obj6 = new Attendence();
            obj6.Show();
        }
    }
}
