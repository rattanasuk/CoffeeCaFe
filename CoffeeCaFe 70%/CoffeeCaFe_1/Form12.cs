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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("แล้วพบกันใหม่โอกาศหน้าที่ร้าน CoffeeCafe", "CoffeeCafe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
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
                str1 += " \r\n\nIced Latte   ราคา 35 Baht"+ "     จำนวน " + (Convert.ToInt32(textBox7.Text)) + " แก้ว";
                Sum.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox7.Text)) + " แก้ว");
                BE1 = 35 * (Convert.ToInt32(textBox7.Text));             
            }
            else
            {
                BE1 = 0;
            }
            if (B2.Checked == true)
            {
                str1 += " \r\n\nIced Cocoa   ราคา 30 Baht" + "     จำนวน " + (Convert.ToInt32(textBox2.Text)) + " แก้ว";
                Sum.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox2.Text)) + " แก้ว");
                BE2 = 30 * (Convert.ToInt32(textBox2.Text));
            }
            else
            {
                BE2 = 0;
            }
            if (B3.Checked == true)
            {
                str1 += " \r\n\nIced Green Tea    ราคา 40 Baht" + "     จำนวน " + (Convert.ToInt32(textBox3.Text)) + " แก้ว";    
                Sum.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox3.Text)) + " แก้ว");
                BE3 = 40 * (Convert.ToInt32(textBox3.Text));
            }
            else
            {
                BE3 = 0;
            }
            if (H01.Checked == true)
            {
                str1 += " \r\n\nHot americano   ราคา 45 Baht" + "     จำนวน " + (Convert.ToInt32(textBox4.Text)) + " แก้ว";
                Sum.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox4.Text)) + " แก้ว");
                BE4 = 45 * (Convert.ToInt32(textBox4.Text));
            }
            else
            {
                BE4 = 0;
            }
            if (H02.Checked == true)
            {
                str1 += " \r\n\nHot Latte  ราคา 50 Baht" + "     จำนวน " + (Convert.ToInt32(textBox5.Text)) + " แก้ว";
                Sum.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox5.Text)) + " แก้ว");
                BE5 = 50 * (Convert.ToInt32(textBox5.Text));
            }
            else
            {
                BE5 = 0;
            }
            if (H03.Checked == true)
            {
                str1 += " \r\n\nHot Mocha   ราคา 55 Baht" + "     จำนวน " + (Convert.ToInt32(textBox6.Text)) + " แก้ว";
                Sum.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox6.Text)) + " แก้ว");
                BE6 = 55 * (Convert.ToInt32(textBox6.Text));
            }
            else
            {
                BE6 = 0;
            }
            if (CO1.Checked == true)
            {
                str1 += " \r\n\nCrepe Cake   ราคา 50 Baht"+ "     จำนวน " + (Convert.ToInt32(textBox8.Text)) + " แก้ว";
                Sum.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox8.Text)) + " แก้ว");
                DE1 = 50 * (Convert.ToInt32(textBox8.Text));
            }
            else
            {
                DE1 = 0;
            }
            if (CO2.Checked == true)
            {
                str1 += " \r\n\nPancakes   ราคา 45 Baht"+ "     จำนวน " + (Convert.ToInt32(textBox9.Text)) + " แก้ว";
                Sum.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox9.Text)) + " แก้ว");
                DE2 = 45 * (Convert.ToInt32(textBox9.Text));
            }
            else
            {
                DE2 = 0;
            }
            if (CO3.Checked == true)
            {
                str1 += " \r\n\nRoll Cake   ราคา 35 Baht"+ "     จำนวน " + (Convert.ToInt32(textBox10.Text)) + " แก้ว";
                Sum.Text += ("\r\n\nจำนวน " + (Convert.ToInt32(textBox10.Text)) + " แก้ว");
                DE3 = 35 * (Convert.ToInt32(textBox10.Text));
            }
            else
            {
                DE3 = 0;
            }


           textBox1.Text = str1;
            SUM = BE1 + BE2 + BE3 + BE4 + BE5 + BE6 + DE1 + DE2 + DE3;
            Console.WriteLine(SUM);
            String SUMi = Convert.ToString(SUM);
            Sum.Text = SUMi;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
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
            H01.Checked = false;
            H02.Checked = false;
            H03.Checked = false;
            CO1.Checked = false;
            CO2.Checked = false;
            CO3.Checked = false;
        }
    }
}
