﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeCaFe_1
{
    public partial class Form1 : Form
    {
        private Form12 f5;
        private Form3 f2;
        private Form10 f3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           f5 = new Form12();
            f5.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f2 = new Form3();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f3 = new Form10();
            f3.Show();
        }
    }
}
