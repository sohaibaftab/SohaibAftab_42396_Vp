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

namespace Vp_semester_Project
{
    public partial class Main : Form
    {
        private int result=0;
        public Main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Anemometer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Altimeter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Ammeter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Audiometer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (Barometer.Checked == true)
            {
                result += 10;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage11_Click(object sender, EventArgs e)
        {

        }

        private void tabPage12_Click(object sender, EventArgs e)
        {

        }

        private void tabPage13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Wattmeter.Checked==true)
            {
                result += 10;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Periscope.Checked==true)
            {
                result+=10;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (union.Checked == true)
            {
                result += 10;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (BitMap.Checked == true)
            {
                result += 10;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (ServiceAccessPoint.Checked == true)
            {
                result += 10;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (PortableDocumentFormat.Checked == true)
            {
                result += 10;
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {

            if (ten.Checked == true)
            {
                result += 10;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (False.Checked == true)
            {
                result += 10;
            }
            MessageBox.Show("result," + result);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (five.Checked == true)
            {
                result += 10;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (oneSixtyTwo.Checked == true)
            {
                result += 10;
            }
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (c.Checked == true)
            {
                result += 10;
            }

        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (ANS.Checked == true)
            {
                result += 10;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (D.Checked == true)
            {
                result += 10;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {

            if (Abbreviate.Checked == true)
            {
                result += 10;
            }
        }

        private void tabPage19_Click(object sender, EventArgs e)
        {
            
        }
    }
}
