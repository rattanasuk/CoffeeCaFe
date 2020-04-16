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
    public partial class Form5 : Form
    {
        static int p = 0;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str, str1;
            int BE1, BE2, BE3, BE4, BE5, BE6, DE1, DE2, DE3;
            int SUM;
            str = "";
            str += " \r\n\nโต๊ะที่ : " + comboBox1.SelectedItem.ToString();
            Outdata.Text = str;
            
            str1 = "";
            if (B1.Checked == true)
            {
                str1 += " \r\n\nIced Latte    ราคา 35 Baht  ";
                textBox2.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox1.Text)) + " แก้ว");
                BE1 = 35*(Convert.ToInt32(textBox1.Text));
                p += 1;
               
            }
            else
            {
                BE1 = 0;
            }
            if (B2.Checked == true)
            {
                str1 += " \r\n\nIced Cocoa    ราคา 30 Baht";
                textBox2.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox7.Text)) + " แก้ว");
                BE2 = 30*(Convert.ToInt32(textBox7.Text));
                p += 1;
            }
            else
            {
                BE2 = 0;
            }
            if (B3.Checked == true)
            {
                str1 += " \r\n\nIced Green Tea    ราคา 40 Baht";
                textBox2.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox6.Text)) + " แก้ว");
                BE3 = 40*(Convert.ToInt32(textBox6.Text));
                p += 1;
            }
            else
            {
                BE3 = 0;
            }
            if (HO1.Checked == true)
            {
                str1 += " \r\n\nHot americano    ราคา 45 Baht";
                textBox2.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox3.Text)) + " แก้ว");
                BE4 = 45*(Convert.ToInt32(textBox3.Text));
                p += 1;
            }
            else
            {
                BE4 = 0;
            }
            if (HO2.Checked == true)
            {
                str1 += " \r\n\nHot Latte    ราคา 50 Baht";
                textBox2.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox5.Text)) + " แก้ว");
                BE5 = 50*(Convert.ToInt32(textBox5.Text));
                p += 1;
            }
            else
            {
                BE5 = 0;
            }
            if (HO3.Checked == true)
            {
                str1 += " \r\n\nHot Mocha    ราคา 55 Baht";
                textBox2.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox4.Text)) + " แก้ว");
                BE6 = 55*(Convert.ToInt32(textBox4.Text));
                p += 1;
            }
            else
            {
                BE6 = 0;
            }
            if (CA1.Checked == true)
            {
                str1 += " \r\n\nCrepe Cake    ราคา 50 Baht";
                textBox2.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox8.Text)) + " แก้ว");
                DE1 = 50*(Convert.ToInt32(textBox8.Text));
                p += 1;
            }
            else
            {
                DE1 = 0;
            }
            if (CO2.Checked == true)
            {
                str1 += " \r\n\nPancakes    ราคา 45 Baht";
                textBox2.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox10.Text)) + " แก้ว");
                DE2 = 45*(Convert.ToInt32(textBox10.Text));
                p += 1;
            }
            else
            {
                DE2 = 0;
            }
            if (CA3.Checked == true)
            {
                str1 += " \r\n\nRoll Cake    ราคา 35 Baht";
                textBox2.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox9.Text)) + " แก้ว");
                DE3 = 35*(Convert.ToInt32(textBox9.Text));
                p += 1;
            }
            else
            {
                DE3 = 0;
            }


            Order.Text = str1;
            SUM = BE1 + BE2 + BE3 + BE4 + BE5 + BE6 + DE1 + DE2 + DE3;
            Console.WriteLine(SUM);
            String SUMi = Convert.ToString(SUM);
            Sum.Text = SUMi;

            //MessageBox.Show("บันทึกรายการทั้งหมดและเป็นเงินทั้งสิ้น  " + Sum.Text, "CoffeeCafe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order.Clear();
            Sum.Clear();
            Outdata.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            B1.Checked = false;
            B2.Checked = false;
            B3.Checked = false;
            HO1.Checked = false;
            HO2.Checked = false;
            HO3.Checked = false;
            CA1.Checked = false;
            CO2.Checked = false;
            CA3.Checked = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("แล้วพบกันใหม่โอกาศหน้าที่ร้าน CoffeeCafe", "CoffeeCafe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string vasg = Convert.ToString(p);
            string data = Order.Text;
            string da = Sum.Text+" Baht";
            string sen = textBox2.Text;
            string ran = textBox11.Text;
            string vas = vasg;
            Form4 frm = new Form4(data,da,sen,ran,vas);
            frm.Show();
            this.Close();


           
        }
    }
}
