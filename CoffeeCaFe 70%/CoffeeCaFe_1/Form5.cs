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
        static int asd = 0;
        static string a = "";
        static string b = "";
        static string c = "";
        static string[] zxc=new string[1];
        public Form5()
        {
             
            InitializeComponent();
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str, str1,str2;
            int BE1, BE2, BE3, BE4, BE5, BE6, DE1, DE2, DE3;
            int SUM;
            
            str = "";
            str += " \r\n\nโต๊ะที่ : " + comboBox1.SelectedItem.ToString();
            Outdata.Text = str;

          
            str1 = "";
            str2 = "";
            if (B1.Checked == true)
            {
                str1 += " \r\n\nIced Latte   ";
                textBox12.Text += ("\r\n\n    ราคา 35 Baht");
                textBox2.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox1.Text)) + " แก้ว");
                BE1 = 35*(Convert.ToInt32(textBox1.Text));
                str2 += " \r\n\nIced Latte   ราคา 35 Baht" + "     จำนวน " + (Convert.ToInt32(textBox1.Text)) + " แก้ว";
                p += 1;
                a += ("35");
                b += ((textBox1.Text));
                c += ("\r\n\n  " + 35 * (Convert.ToInt32(textBox1.Text)));
               // int d = 35 * (Convert.ToInt32(textBox1.Text));
               // zxc[asd] = Convert.ToString(d);
               // asd += 1;
            }
            else
            {
                BE1 = 0;
            }
            if (B2.Checked == true)
            {
                str1 += " \r\n\nIced Cocoa   ";
                textBox12.Text += ("\r\n\n    ราคา 30 Baht");
                textBox2.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox7.Text)) + " แก้ว");
                BE2 = 30 * (Convert.ToInt32(textBox7.Text));
               str2 += " \r\n\nIced Cocoa   ราคา 30 Baht" + "     จำนวน " + (Convert.ToInt32(textBox7.Text)) + " แก้ว";
                p += 1;
                a += ("30");
                b += ((textBox7.Text));
                c += ("\r\n\n  " + 30 * (Convert.ToInt32(textBox7.Text)));
               // int k = 30 * (Convert.ToInt32(textBox7.Text));
              //  zxc[asd] = Convert.ToString(k);

              
            }
            else
            {
                BE2 = 0;
            }
            if (B3.Checked == true)
            {
                str1 += " \r\n\nIced Green Tea   ";
                textBox12.Text += ("\r\n\n    ราคา 40 Baht");
                textBox2.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox6.Text)) + " แก้ว");
                BE3 = 40*(Convert.ToInt32(textBox6.Text));
                str2 += " \r\n\nIced Green Tea   ราคา 40 Baht" + "     จำนวน " + (Convert.ToInt32(textBox6.Text)) + " แก้ว";
                p += 1;
                a += ("40");
                b += ((textBox6.Text));
                c += ("\r\n\n  " + 40 * (Convert.ToInt32(textBox6.Text)));
            }
            else
            {
                BE3 = 0;
            }
            if (HO1.Checked == true)
            {
                str1 += " \r\n\nHot americano   ";
                textBox12.Text += ("\r\n\n    ราคา 45 Baht");
                textBox2.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox3.Text)) + " แก้ว");
                BE4 = 45*(Convert.ToInt32(textBox3.Text));
                str2 += " \r\n\nHot americano   ราคา 45 Baht" + "     จำนวน " + (Convert.ToInt32(textBox3.Text)) + " แก้ว";
                p += 1;
                a += ("45");
                b += ((textBox3.Text));
                c += ("\r\n\n  " + 45 * (Convert.ToInt32(textBox3.Text)));
            }
            else
            {
                BE4 = 0;
            }
            if (HO2.Checked == true)
            {
                str1 += " \r\n\nHot Latte  ";
                textBox12.Text += ("\r\n\n    ราคา 50 Baht");
                textBox2.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox5.Text)) + " แก้ว");
                BE5 = 50*(Convert.ToInt32(textBox5.Text));
                str2 += " \r\n\nHot Latte  ราคา 50 Baht" + "     จำนวน " + (Convert.ToInt32(textBox5.Text)) + " แก้ว";
                p += 1;
                a += ("50");
                b += ((textBox5.Text));
                c += ("\r\n\n  " + 50 * (Convert.ToInt32(textBox5.Text)));
            }
            else
            {
                BE5 = 0;
            }
            if (HO3.Checked == true)
            {
                str1 += " \r\n\nHot Mocha   ";
                textBox12.Text += ("\r\n\n    ราคา 55 Baht");
                textBox2.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox4.Text)) + " แก้ว");
                BE6 = 55*(Convert.ToInt32(textBox4.Text));
                str2 += " \r\n\nHot Mocha   ราคา 55 Baht" + "     จำนวน " + (Convert.ToInt32(textBox4.Text)) + " แก้ว";
                p += 1;
                a += ("55");
                b += ((textBox4.Text));
                c += ("\r\n\n  " + 55 * (Convert.ToInt32(textBox4.Text)));
            }
            else
            {
                BE6 = 0;
            }
            if (CA1.Checked == true)
            {
                str1 += " \r\n\nCrepe Cake   ";
                textBox12.Text += ("\r\n\n    ราคา 50 Baht");
                textBox2.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox8.Text)) + " แก้ว");
                DE1 = 50*(Convert.ToInt32(textBox8.Text));
                str2 += " \r\n\nCrepe Cake   ราคา 50 Baht" + "     จำนวน " + (Convert.ToInt32(textBox8.Text)) + " แก้ว";
                p += 1;
                a += ("50");
                b += ((textBox8.Text));
                c += ("\r\n\n  " + 50 * (Convert.ToInt32(textBox8.Text)));
            }
            else
            {
                DE1 = 0;
            }
            if (CO2.Checked == true)
            {
                str1 += " \r\n\nPancakes   ";
                textBox12.Text += ("\r\n\n    ราคา 45 Baht");
                textBox2.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox10.Text)) + " แก้ว");
                DE2 = 45*(Convert.ToInt32(textBox10.Text));
                str2 += " \r\n\nPancakes   ราคา 45 Baht" + "     จำนวน " + (Convert.ToInt32(textBox10.Text)) + " แก้ว";
                p += 1;
                a += ("45");
                b += ((textBox10.Text));
                c += ("\r\n\n  " + 45 * (Convert.ToInt32(textBox10.Text)));
            }
            else
            {
                DE2 = 0;
            }
            if (CA3.Checked == true)
            {
                str1 += " \r\n\nRoll Cake   ";
                textBox12.Text += ("\r\n\n    ราคา 35 Baht");
                textBox2.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox9.Text)) + " แก้ว");
                DE3 = 35*(Convert.ToInt32(textBox9.Text));
                str2 += " \r\n\nRoll Cake   ราคา 35 Baht" + "     จำนวน " + (Convert.ToInt32(textBox9.Text)) + " แก้ว";
                p += 1;
                a += ("35");
                b += ((textBox9.Text));
                c += ("\r\n\n  " + 35 * (Convert.ToInt32(textBox9.Text)));
            }
            else
            {
                DE3 = 0;
            }


            Order.Text = str1;
            textBox14.Text = str2;
            SUM = BE1 + BE2 + BE3 + BE4 + BE5 + BE6 + DE1 + DE2 + DE3;
            Console.WriteLine(SUM);
            String SUMi = Convert.ToString(SUM);
            Sum.Text = SUMi;

            //MessageBox.Show("บันทึกรายการทั้งหมดและเป็นเงินทั้งสิ้น  " + Sum.Text, "CoffeeCafe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox14.Clear();
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
            textBox12.Clear();
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
            string pi = textBox12.Text;
            string aa = a;
            string bb = b;
            string cc = c;
            //string asdd = zxc;
            Form4 frm = new Form4(data,da,sen,ran,vas,pi,aa,bb,cc,zxc);
            frm.Show();
            this.Close();


           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string vasg = Convert.ToString(p);
            string vasj = vasg;
            string da = Sum.Text;
            string dat = Order.Text;
            string senm = b;
            string ccc = c;
            string aaa = a;
            string yy = textBox13.Text;
            string sad = textBox13.Text;
            Form6 fr = new Form6(da,dat,senm,ccc,vasj,aaa,yy,sad);
            fr.Show();
            this.Close();

        }
        public void GetData(string str)
        {
            textBox13.Text = str;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sa = textBox13.Text;
            Form11 gy = new Form11(sa);
            gy.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 frs = new Form9();
            frs.Show();
            this.Close();
        }
    }
}
