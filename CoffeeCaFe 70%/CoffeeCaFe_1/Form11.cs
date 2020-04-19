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
    public partial class Form11 : Form
    {
        static int d,f,g,h,k,l,q,w,t,y,dd,ddd,qq,qqq,gg,ggg = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            string vasg = Convert.ToString(p);
            string vasj = vasg;
            string da = Sum.Text;
            string dat = textBox28.Text;
            string senm = b;
            string ccc = c;
            string aaa = a;
            string yy = textBox13.Text;
            string sad = textBox31.Text;
            Form6 fr = new Form6(da, dat, senm, ccc, vasj, aaa, yy,sad);
            fr.GetData(SendData());
            fr.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sum.Clear();
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
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();
            textBox26.Clear();
            textBox27.Clear();
            textBox28.Clear();
            textBox29.Clear();
            textBox30.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
            checkBox25.Checked = false;
            checkBox27.Checked = false;
            checkBox28.Checked = false;
            checkBox29.Checked = false;
            checkBox30.Checked = false;
            checkBox31.Checked = false;
            checkBox32.Checked = false;
            checkBox33.Checked = false;
            checkBox34.Checked = false;
            checkBox35.Checked = false;
            checkBox36.Checked = false;
            checkBox37.Checked = false;
            checkBox38.Checked = false;
            checkBox39.Checked = false;
            checkBox40.Checked = false;
            checkBox41.Checked = false;
            checkBox42.Checked = false;
            
        }

        static int p = 0;
        static int asd = 0;
        static string a = "";
        static string b = "";
        static string c = "";
        public Form11(string sa)
        {
            InitializeComponent();
            textBox31.Text = sa;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form5 form1 = new Form5();
           
            form1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str, str1;
        
           int SUM;
            int z,x,y,w,m,n,z1,z2,z3,z4,z5,z6,z7,z8,z9,z10,s1,s2,s3,s4,s5,s6,s7,s8,s9,s10,d1,d2,d3,d4,d5,d6,d7,d8;
            

            str = "";
            str += " \r\n\nโต๊ะที่ : " + comboBox1.SelectedItem.ToString();
            textBox27.Text = str;


            str1 = "";
            
            if (checkBox1.Checked == true)
            {
                str1 += "Espresso   ";
                if (checkBox9.Checked == true)
                {
                    textBox30.Text += ("\n 60 ");

                    d = 60 * (Convert.ToInt32(textBox1.Text));
                }
                z = d;
                
                if (checkBox17.Checked == true)
                {
                    textBox30.Text += (" 65 ");
                    f = 65 * (Convert.ToInt32(textBox1.Text));
                }
                x = f;
                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox1.Text)) + " แก้ว");
                
                p += 1;
                a += ("65");
                b += ((textBox1.Text));
                c += ("\r\n\n  " + 35 * (Convert.ToInt32(textBox1.Text)));
              
            }
            else
            {
                z = 0;
                x = 0;
            }
            if (checkBox2.Checked == true)
            {
                str1 += "Americano   ";
                if (checkBox10.Checked == true)
                {
                    textBox30.Text += ("\n 45 ");

                    g = 45 * (Convert.ToInt32(textBox2.Text));
                }
                y = g;

                if (checkBox18.Checked == true)
                {
                    textBox30.Text += (" 50 ");
                    h = 50 * (Convert.ToInt32(textBox2.Text));
                }
                w = h;
                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox2.Text)) + " แก้ว");
                
                p += 1;
                a += ("45");
                b += ((textBox2.Text));
                c += ("\r\n\n  " + 45 * (Convert.ToInt32(textBox2.Text)));
              


            }
            else
            {
               w = 0;
                y = 0;
            }
            if (checkBox3.Checked == true)
            {
                str1 += "Latte";
                if (checkBox11.Checked == true)
                {
                    textBox30.Text += (" 50 ");

                    k = 50 * (Convert.ToInt32(textBox3.Text));
                }
                m = k;

                if (checkBox19.Checked == true)
                {
                    textBox30.Text += (" 55 ");
                    l = 55 * (Convert.ToInt32(textBox3.Text));
                }
                n = l;

                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox3.Text)) + " แก้ว");

                p += 1;
                a += ("55");
                b += ((textBox3.Text));
                c += ("\r\n\n  " + 55 * (Convert.ToInt32(textBox3.Text)));
            }      
            else
            {
                m = 0;
                n = 0;
            }
            if (checkBox4.Checked == true)
            {
                str1 += "Cappuccino";
                if (checkBox12.Checked == true)
                {
                    textBox30.Text += (" 60 ");

                    w = 60 * (Convert.ToInt32(textBox4.Text));
                }
                z1 = w;

                if (checkBox20.Checked == true)
                {
                    textBox30.Text += (" 65 ");
                    q = 65 * (Convert.ToInt32(textBox4.Text));
                }
                z2 = q;

                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox4.Text)) + " แก้ว");

                p += 1;
                a += ("40");
                b += ((textBox6.Text));
                c += ("\r\n\n  " + 40 * (Convert.ToInt32(textBox6.Text)));
            }
            else
            {
                z1 = 0;
                z2 = 0;
            }
            if (checkBox5.Checked == true)
            {
                str1 += "Mocha";
                if (checkBox13.Checked == true)
                {
                    textBox30.Text += (" 55 ");

                    t = 55 * (Convert.ToInt32(textBox5.Text));
                }
                z3 = t;

                if (checkBox21.Checked == true)
                {
                    textBox30.Text += (" 60 ");
                    y = 60 * (Convert.ToInt32(textBox5.Text));
                }
                z4 = y;

                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox5.Text)) + " แก้ว");

                p += 1;
                a += ("40");
                b += ((textBox6.Text));
                c += ("\r\n\n  " + 40 * (Convert.ToInt32(textBox6.Text)));
            }
            else
            {
                z3 = 0;
                z4 = 0;
            }
            if (checkBox6.Checked == true)
            {
                str1 += "Macchiato";
                if (checkBox14.Checked == true)
                {
                    textBox30.Text += (" 60 ");

                    dd = 60 * (Convert.ToInt32(textBox6.Text));
                }
                z5 = dd;

                if (checkBox22.Checked == true)
                {
                    textBox30.Text += (" 65 ");
                    ddd = 65 * (Convert.ToInt32(textBox6.Text));
                }
                z6 = ddd;

                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox6.Text)) + " แก้ว");

                p += 1;
                a += ("40");
                b += ((textBox6.Text));
                c += ("\r\n\n  " + 40 * (Convert.ToInt32(textBox6.Text)));
            }
            else
            {
                z5 = 0;
                z6 = 0;
            }
            if (checkBox7.Checked == true)
            {
                str1 += "Frappe";
                if (checkBox15.Checked == true)
                {
                    textBox30.Text += (" 45 ");

                    qq = 45 * (Convert.ToInt32(textBox7.Text));
                }
                z7 = qq;

                if (checkBox23.Checked == true)
                {
                    textBox30.Text += (" 50 ");
                    qqq = 50 * (Convert.ToInt32(textBox7.Text));
                }
                z8 = qqq;

                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox7.Text)) + " แก้ว");

                p += 1;
                a += ("40");
                b += ((textBox6.Text));
                c += ("\r\n\n  " + 40 * (Convert.ToInt32(textBox6.Text)));
            }
            else
            {
                z7 = 0;
                z8 = 0;
            }
            if (checkBox8.Checked == true)
            {
                str1 += " Affogato";
                if (checkBox16.Checked == true)
                {
                    textBox30.Text += (" 50 ");

                    gg = 50 * (Convert.ToInt32(textBox8.Text));
                }
                z9 = qq;

                if (checkBox24.Checked == true)
                {
                    textBox30.Text += (" 55 ");
                    ggg = 55 * (Convert.ToInt32(textBox8.Text));
                }
                z10 = qqq;

                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox8.Text)) + " แก้ว");

                p += 1;
                a += ("40");
                b += ((textBox6.Text));
                c += ("\r\n\n  " + 40 * (Convert.ToInt32(textBox6.Text)));
            }
            else
            {
                z9 = 0;
                z10 = 0;
            }
            if (checkBox25.Checked == true)
            {
                str1 += "Green Teaa Matcha Soda";
                textBox30.Text += ("ราคา 55 Baht");
                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox9.Text)) + " แก้ว");
                s1 = 55 * (Convert.ToInt32(textBox9.Text));
               
                p += 1;
                a += ("55");
                b += ((textBox9.Text));
                c += ("\r\n\n  " + 55 * (Convert.ToInt32(textBox9.Text)));
            }
            else
            {
               s1 = 0;
            }
            if (checkBox26.Checked == true)
            {
                str1 += "Matcha Green Tea Macchiato";
                textBox30.Text += ("ราคา 50 Baht");
                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox10.Text)) + " แก้ว");
                s2 = 50 * (Convert.ToInt32(textBox10.Text));

                p += 1;
                 a += ("50");
                 b += ((textBox10.Text));
                  c += ("\r\n\n  " + 50 * (Convert.ToInt32(textBox10.Text)));
            }
            else
            {
                s2 = 0;
            }
            if (checkBox27.Checked == true)
            {
                str1 += "Matcha Green Tea Smoothie";
                textBox30.Text += ("ราคา 60 Baht");
                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox11.Text)) + " แก้ว");
                s3 = 60 * (Convert.ToInt32(textBox11.Text));

                p += 1;
                 a += ("60");
                 b += ((textBox11.Text));
                  c += ("\r\n\n  " + 60 * (Convert.ToInt32(textBox11.Text)));
            }
            else
            {
                s3 = 0;
            }
            if (checkBox28.Checked == true)
            {
                str1 += "Thai tea";
                textBox30.Text += ("ราคา 35 Baht");
                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox12.Text)) + " แก้ว");
                s4 = 35 * (Convert.ToInt32(textBox12.Text));

                p += 1;
               a += ("35");
                 b += ((textBox12.Text));
                 c += ("\r\n\n  " + 35 * (Convert.ToInt32(textBox12.Text)));
            }
            else
            {
                s4 = 0;
            }
            if (checkBox29.Checked == true)
            {
                str1 += "Bonsai Milk Tea";
                textBox30.Text += ("ราคา 55 Baht");
                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox13.Text)) + " แก้ว");
                s5 = 55 * (Convert.ToInt32(textBox13.Text));

                p += 1;
                a += ("55");
              b += ((textBox13.Text));
                  c += ("\r\n\n  " + 55 * (Convert.ToInt32(textBox13.Text)));
            }
            else
            {
                s5 = 0;
            }
            if (checkBox30.Checked == true)
            {
                str1 += "Dried Fruit Tea";
                textBox30.Text += ("ราคา 50 Baht");
                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox14.Text)) + " แก้ว");
                s6 = 50 * (Convert.ToInt32(textBox14.Text));

                p += 1;
                 a += ("50");
                 b += ((textBox14.Text));
                  c += ("\r\n\n  " + 50 * (Convert.ToInt32(textBox14.Text)));
            }
            else
            {
                s6 = 0;
            }
            if (checkBox31.Checked == true)
            {
                str1 += "Roselle Tea";
                textBox30.Text += ("ราคา 45 Baht");
                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox15.Text)) + " แก้ว");
                s7 = 45 * (Convert.ToInt32(textBox15.Text));

                p += 1;
                 a += ("45");
                 b += ((textBox15.Text));
                  c += ("\r\n\n  " + 45 * (Convert.ToInt32(textBox15.Text)));
            }
            else
            {
                s7 = 0;
            }
            if (checkBox32.Checked == true)
            {
                str1 += "Ginger Lemon Tea";
                textBox30.Text += ("ราคา 40 Baht");
                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox16.Text)) + " แก้ว");
                s8 = 40 * (Convert.ToInt32(textBox16.Text));

                p += 1;
                 a += ("40");
                 b += ((textBox16.Text));
                  c += ("\r\n\n  " + 40 * (Convert.ToInt32(textBox16.Text)));
            }
            else
            {
                s8 = 0;
            }
            if (checkBox33.Checked == true)
            {
                str1 += "Ice Ceylon Tea Milk Foam";
                textBox30.Text += ("ราคา 55 Baht");
                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox17.Text)) + " แก้ว");
                s9 = 55 * (Convert.ToInt32(textBox17.Text));

                p += 1;
                 a += ("55");
                 b += ((textBox17.Text));
                  c += ("\r\n\n  " + 55 * (Convert.ToInt32(textBox17.Text)));
            }
            else
            {
                s9 = 0;
            }
            if (checkBox34.Checked == true)
            {
                str1 += "Hot Ceylon Tea Milk Foam";
                textBox30.Text += ("ราคา 50 Baht");
                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox18.Text)) + " แก้ว");
                s10 = 50 * (Convert.ToInt32(textBox18.Text));

                p += 1;
                 a += ("50");
                 b += ((textBox18.Text));
                  c += ("\r\n\n  " + 50 * (Convert.ToInt32(textBox18.Text)));
            }
            else
            {
                s10 = 0;
            }
            if (checkBox35.Checked == true)
            {
                str1 += "Brownie";
                textBox30.Text += ("ราคา 40 Baht");
                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox19.Text)) + " ชิ้น");
                d1 = 40 * (Convert.ToInt32(textBox19.Text));

                p += 1;
                 a += ("40");
                 b += ((textBox19.Text));
                  c += ("\r\n\n  " + 40 * (Convert.ToInt32(textBox19.Text)));
            }
            else
            {
                d1 = 0;
            }
            if (checkBox36.Checked == true)
            {
                str1 += " Chocolate Lava";
                textBox30.Text += ("ราคา 55 Baht");
                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox20.Text)) + " ชิ้น");
                d2 = 55 * (Convert.ToInt32(textBox20.Text));

                p += 1;
                 a += ("55");
                 b += ((textBox20.Text));
                  c += ("\r\n\n  " + 55 * (Convert.ToInt32(textBox20.Text)));
            }
            else
            {
                d2 = 0;
            }
            if (checkBox37.Checked == true)
            {
                str1 += "Cheese cake";
                textBox30.Text += ("ราคา 50 Baht");
                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox21.Text)) + " ชิ้น");
                d3 = 50 * (Convert.ToInt32(textBox21.Text));

                p += 1;
                a += ("50");
                 b += ((textBox21.Text));
                  c += ("\r\n\n  " + 50 * (Convert.ToInt32(textBox21.Text)));
            }
            else
            {
                d3 = 0;
            }
            if (checkBox38.Checked == true)
            {
                str1 += "Waffle";
                textBox30.Text += ("ราคา 25 Baht");
                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox26.Text)) + " ชิ้น");
                d4 = 25 * (Convert.ToInt32(textBox26.Text));

                p += 1;
                 a += ("25");
                 b += ((textBox26.Text));
                  c += ("\r\n\n  " + 25 * (Convert.ToInt32(textBox26.Text)));
            }
            else
            {
                d4 = 0;
            }
            if (checkBox39.Checked == true)
            {
                str1 += "Honey Toast";
                textBox30.Text += ("ราคา 70 Baht");
                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox22.Text)) + " ชิ้น");
                d5 = 70 * (Convert.ToInt32(textBox22.Text));

                p += 1;
                 a += ("70");
                 b += ((textBox22.Text));
                  c += ("\r\n\n  " + 70 * (Convert.ToInt32(textBox22.Text)));
            }
            else
            {
                d5 = 0;
            }
            if (checkBox40.Checked == true)
            {
                str1 += "Fondue";
                textBox30.Text += ("ราคา 120 Baht");
                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox23.Text)) + " ชิ้น");
                d6 = 120 * (Convert.ToInt32(textBox23.Text));

                p += 1;
                 a += ("120");
                 b += ((textBox23.Text));
                  c += ("\r\n\n  " + 120 * (Convert.ToInt32(textBox23.Text)));
            }
            else
            {
                d6 = 0;
            }
            if (checkBox41.Checked == true)
            {
                str1 += "Cup Cake";
                textBox30.Text += ("ราคา 20 Baht");
                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox24.Text)) + " ชิ้น");
                d7 = 20 * (Convert.ToInt32(textBox24.Text));

                p += 1;
                 a += ("20");
                 b += ((textBox24.Text));
                 c += ("\r\n\n  " + 20 * (Convert.ToInt32(textBox24.Text)));
            }
            else
            {
                d7 = 0;
            }
            if (checkBox42.Checked == true)
            {
                str1 += "Red Velvet Cake";
                textBox30.Text += ("ราคา 55 Baht");
                textBox29.Text += ("จำนวน " + (Convert.ToInt32(textBox25.Text)) + " ชิ้น");
                d8 = 55 * (Convert.ToInt32(textBox25.Text));

                p += 1;
                a += ("55");
                b += ((textBox5.Text));
                c += ("\r\n\n  " + 55 * (Convert.ToInt32(textBox25.Text)));
            }
            else
            {
                d8 = 0;
            }


            textBox28.Text = str1;
            SUM = z+x+w+y+m+n+z1+z2+z3+z4+z5+z6+z7+z8+z9+z10+s1+s2+s3+s4+s5+s6+s7+s8+s9+s10+d1+d2+d3+d4+d5+d6+d7+d8;
            Console.WriteLine(SUM);
            String SUMi = Convert.ToString(SUM);
            Sum.Text = SUMi;
          
        }
        public string SendData()
        {
            return textBox30.Text;
        }
      
    }
}
