﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class DataEnter : Form
    {
        public DataEnter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDataInShop open = new AddDataInShop();
            open.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddToStock open = new AddToStock();
            open.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDataInShop open = new AddDataInShop();
            open.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddToStock open = new AddToStock();
            open.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main open = new Main();
            open.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditData open = new EditData();
            open.Show();
        }
    }
}
