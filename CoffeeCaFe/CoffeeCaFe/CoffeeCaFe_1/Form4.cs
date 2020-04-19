using System;
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
    public partial class Form4 : Form
    {
      


        public Form4(string data,string da,string sen,string ran,string vas)
        {
            InitializeComponent();
            textBox3.Text = data;
            textBox5.Text = "\r\n\n"+da;
            textBox6.Text = sen;
            
            Random rnd = new Random();
            textBox2.Text = "\r\n\n"+rnd.Next(1000, 9999).ToString();

            string a="";

            int sd = Convert.ToInt32(vas);
            for (int i = 0; i < sd; i++)
            {
                a=a+ "\r\n\n" + rnd.Next(10000, 99999).ToString();
                
            }
              textBox1.Text=a;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
        }
        

    }
}
