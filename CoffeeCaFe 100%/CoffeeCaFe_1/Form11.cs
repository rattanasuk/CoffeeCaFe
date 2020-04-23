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
        string lp,lpp,kll,kl,al,all,op,opp,tr,trr,fl,fll,pl,pll,we,wee = "";

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
            string sadd = textBox31.Text;
            string df = textBox30.Text;
            string ii = b;
            Form6 fr = new Form6(da, dat, senm, ccc, vasj, aaa, yy,sad,df,ii,sadd);
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
            textBox32.Clear();
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
            string str, str1, str2;
        
           int SUM;
            int z,x,y,w,m,n,z1,z2,z3,z4,z5,z6,z7,z8,z9,z10,s1,s2,s3,s4,s5,s6,s7,s8,s9,s10,d1,d2,d3,d4,d5,d6,d7,d8;
            

            str = "";
            str += " \r\n\nโต๊ะที่ : " + comboBox1.SelectedItem.ToString();
            textBox27.Text = str;


            str1 = "";
            str2 = "";
            
            if (checkBox1.Checked == true)
            {
                str1 += "\r\n\n Espresso   ";
                if (checkBox9.Checked == true)
                {
                    textBox30.Text += ("\r\n\n 60 ");
                    lp = " \r\n\n Espresso ราคา 60 Baht" + "     จำนวน " + (Convert.ToInt32(textBox1.Text)) + " แก้ว";
                    d = 60 * (Convert.ToInt32(textBox1.Text));
                }
                z = d;
                str2 += lp;
                
                if (checkBox17.Checked == true)
                {
                    textBox30.Text += ("\r\n\n 65 ");
                    f = 65 * (Convert.ToInt32(textBox1.Text));
                    lpp = " \r\n\n Espresso ราคา 65 Baht" + "     จำนวน " + (Convert.ToInt32(textBox1.Text)) + " แก้ว";
                }
                x = f;
                str2 += lpp;
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox1.Text)) + " แก้ว");
                
                p += 1;
                a += ("\r\n\n 65");
                b += (("\r\n\n" +textBox1.Text));
                c += ("\r\n\n  " + 35 * (Convert.ToInt32(textBox1.Text)));
              
            }
            else
            {
                z = 0;
                x = 0;
            }
            if (checkBox2.Checked == true)
            {
                str1 += "\r\n\n Americano   ";
                if (checkBox10.Checked == true)
                {
                    textBox30.Text += ("\r\n\n 45 ");
                    kl = " \r\n\n Americano ราคา 45 Baht" + "     จำนวน " + (Convert.ToInt32(textBox2.Text)) + " แก้ว";
                    g = 45 * (Convert.ToInt32(textBox2.Text));
                }
                y = g;
                str2 += kl;

                if (checkBox18.Checked == true)
                {
                    textBox30.Text += ("\r\n\n 50 ");
                    h = 50 * (Convert.ToInt32(textBox2.Text));
                    kll = " \r\n\n Americano ราคา 50 Baht" + "     จำนวน " + (Convert.ToInt32(textBox2.Text)) + " แก้ว";
                }
                w = h;
                str2 += kll;
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox2.Text)) + " แก้ว");
                
                p += 1;
                a += ("\r\n\n 45");
                b += (("\r\n\n" + textBox2.Text));
                c += ("\r\n\n  " + 45 * (Convert.ToInt32(textBox2.Text)));
              


            }
            else
            {
               w = 0;
                y = 0;
            }
            if (checkBox3.Checked == true)
            {
                str1 += "\r\n\n Latte";
                if (checkBox11.Checked == true)
                {
                    textBox30.Text += ("\r\n\n 50 ");
                    all = " \r\n\n Latte ราคา 50 Baht" + "     จำนวน " + (Convert.ToInt32(textBox3.Text)) + " แก้ว";
                    k = 50 * (Convert.ToInt32(textBox3.Text));
                }
                m = k;
                str2 += all;
                if (checkBox19.Checked == true)
                {
                    textBox30.Text += ("\r\n\n 55 ");
                    l = 55 * (Convert.ToInt32(textBox3.Text));
                    al = " \r\n\n Latte ราคา 55 Baht" + "     จำนวน " + (Convert.ToInt32(textBox3.Text)) + " แก้ว";
                }
                n = l;
                str2 += al;
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox3.Text)) + " แก้ว");

                p += 1;
                a += ("\r\n\n 55");
                b += (("\r\n\n" + textBox3.Text));
                c += ("\r\n\n  " + 55 * (Convert.ToInt32(textBox3.Text)));
            }      
            else
            {
                m = 0;
                n = 0;
            }
            if (checkBox4.Checked == true)
            {
                str1 += "\r\n\n Cappuccino";
                if (checkBox12.Checked == true)
                {
                    textBox30.Text += ("\r\n\n 60 ");
                    op = " \r\n\n Cappuccino ราคา 60 Baht" + "     จำนวน " + (Convert.ToInt32(textBox4.Text)) + " แก้ว";
                    w = 60 * (Convert.ToInt32(textBox4.Text));
                }
                z1 = w;
                str2 += op;
                if (checkBox20.Checked == true)
                {
                    textBox30.Text += ("\r\n\n 65 ");
                    opp = " \r\n\n Cappuccino ราคา 65 Baht" + "     จำนวน " + (Convert.ToInt32(textBox4.Text)) + " แก้ว";
                    q = 65 * (Convert.ToInt32(textBox4.Text));
                }
                z2 = q;
                str2 += opp;
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox4.Text)) + " แก้ว");

                p += 1;
                a += ("\r\n\n 40");
                b += (("\r\n\n" + textBox6.Text));
                c += ("\r\n\n  " + 40 * (Convert.ToInt32(textBox4.Text)));
            }
            else
            {
                z1 = 0;
                z2 = 0;
            }
            if (checkBox5.Checked == true)
            {
                str1 += "\r\n\n Mocha";
                if (checkBox13.Checked == true)
                {
                    textBox30.Text += ("\r\n\n 55 ");
                    tr = " \r\n\n Mocha ราคา 55 Baht" + "     จำนวน " + (Convert.ToInt32(textBox5.Text)) + " แก้ว";
                    t = 55 * (Convert.ToInt32(textBox5.Text));
                }
                z3 = t;
                str2 += tr;

                if (checkBox21.Checked == true)
                {
                    textBox30.Text += ("\r\n\n 60 ");
                    trr = " \r\n\n Mocha ราคา 60 Baht" + "     จำนวน " + (Convert.ToInt32(textBox5.Text)) + " แก้ว";
                    y = 60 * (Convert.ToInt32(textBox5.Text));
                }
                z4 = y;
                str2 += trr;
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox5.Text)) + " แก้ว");

                p += 1;
                a += ("\r\n\n40");
                b += (("\r\n\n" + textBox6.Text));
                c += ("\r\n\n  " + 40 * (Convert.ToInt32(textBox6.Text)));
            }
            else
            {
                z3 = 0;
                z4 = 0;
            }
            if (checkBox6.Checked == true)
            {
                str1 += "\r\n\n Macchiato";
                if (checkBox14.Checked == true)
                {
                    textBox30.Text += ("\r\n\n 60 ");
                    fl = " \r\n\n Macchiato ราคา 60 Baht" + "     จำนวน " + (Convert.ToInt32(textBox6.Text)) + " แก้ว";
                    dd = 60 * (Convert.ToInt32(textBox6.Text));
                }
                z5 = dd;
                str2 += fl;
                if (checkBox22.Checked == true)
                {
                    textBox30.Text += ("\r\n\n 65 ");
                    ddd = 65 * (Convert.ToInt32(textBox6.Text));
                    fll = " \r\n\n Macchiato ราคา 65 Baht" + "     จำนวน " + (Convert.ToInt32(textBox6.Text)) + " แก้ว";
                }
                z6 = ddd;
                str2 += fll;
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox6.Text)) + " แก้ว");

                p += 1;
                a += ("\r\n\n 40");
                b += (("\r\n\n" + textBox6.Text));
                c += ("\r\n\n  " + 40 * (Convert.ToInt32(textBox6.Text)));
            }
            else
            {
                z5 = 0;
                z6 = 0;
            }
            if (checkBox7.Checked == true)
            {
                str1 += "\r\n\n Frappe";
                if (checkBox15.Checked == true)
                {
                    textBox30.Text += ("\r\n\n 45 ");
                    pl = " \r\n\n Frappe ราคา 45 Baht" + "     จำนวน " + (Convert.ToInt32(textBox7.Text)) + " แก้ว";
                    qq = 45 * (Convert.ToInt32(textBox7.Text));
                }
                z7 = qq;
                str2 += pl;
                if (checkBox23.Checked == true)
                {
                    textBox30.Text += ("\r\n\n 50 ");
                    qqq = 50 * (Convert.ToInt32(textBox7.Text));
                    pll = " \r\n\n Frappe ราคา 50 Baht" + "     จำนวน " + (Convert.ToInt32(textBox7.Text)) + " แก้ว";
                }
                z8 = qqq;
                str2 += pll;
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox7.Text)) + " แก้ว");

                p += 1;
                a += ("\r\n\n 40");
                b += (("\r\n\n" + textBox6.Text));
                c += ("\r\n\n  " + 40 * (Convert.ToInt32(textBox6.Text)));
            }
            else
            {
                z7 = 0;
                z8 = 0;
            }
            if (checkBox8.Checked == true)
            {
                str1 += "\r\n\n Affogato";
                if (checkBox16.Checked == true)
                {
                    textBox30.Text += ("\r\n\n 50 ");
                    we = " \r\n\n Affogato ราคา 50 Baht" + "     จำนวน " + (Convert.ToInt32(textBox8.Text)) + " แก้ว";
                    gg = 50 * (Convert.ToInt32(textBox8.Text));
                }
                z9 = qq;
                str2 += we;
                if (checkBox24.Checked == true)
                {
                    textBox30.Text += ("\r\n\n 55");
                    ggg = 55 * (Convert.ToInt32(textBox8.Text));
                    wee = " \r\n\n Affogato ราคา 55 Baht" + "     จำนวน " + (Convert.ToInt32(textBox8.Text)) + " แก้ว";
                }
                z10 = qqq;
                str2 += wee;
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox8.Text)) + " แก้ว");
                
                p += 1;
                a += ("\r\n\n 40");
                b += (("\r\n\n" + textBox6.Text));
                c += ("\r\n\n  " + 40 * (Convert.ToInt32(textBox6.Text)));
            }
            else
            {
                z9 = 0;
                z10 = 0;
            }
            if (checkBox25.Checked == true)
            {
                str1 += "\r\n\n Green Teaa Matcha Soda";
                textBox30.Text += ("\r\n\n 55");
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox9.Text)) + " แก้ว");
                s1 = 55 * (Convert.ToInt32(textBox9.Text));
                str2 += " \r\n\n Green Teaa Matcha Soda ราคา 55 Baht" + "     จำนวน " + (Convert.ToInt32(textBox9.Text)) + " แก้ว";
                p += 1;
                a += ("\r\n\n 55");
                b += (("\r\n\n" + textBox9.Text));
                c += ("\r\n\n  " + 55 * (Convert.ToInt32(textBox9.Text)));
            }
            else
            {
               s1 = 0;
            }
            if (checkBox26.Checked == true)
            {
                str1 += "\r\n\n Matcha Green Tea Macchiato";
                textBox30.Text += ("\r\n\n 50");
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox10.Text)) + " แก้ว");
                s2 = 50 * (Convert.ToInt32(textBox10.Text));
                str2 += " \r\n\n Matcha Green Tea Macchiato ราคา 50 Baht" + "     จำนวน " + (Convert.ToInt32(textBox10.Text)) + " แก้ว";
                p += 1;
                 a += ("\r\n\n 50");
                 b += (("\r\n\n" + textBox10.Text));
                  c += ("\r\n\n  " + 50 * (Convert.ToInt32(textBox10.Text)));
            }
            else
            {
                s2 = 0;
            }
            if (checkBox27.Checked == true)
            {
                str1 += "\r\n\n Matcha Green Tea Smoothie";
                textBox30.Text += ("\r\n\n 60");
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox11.Text)) + " แก้ว");
                s3 = 60 * (Convert.ToInt32(textBox11.Text));
                str2 += " \r\n\n Matcha Green Tea Smoothie  ราคา 60 Baht" + "     จำนวน " + (Convert.ToInt32(textBox11.Text)) + " แก้ว";
                p += 1;
                 a += ("\r\n\n 60");
                 b += (("\r\n\n" + textBox11.Text));
                  c += ("\r\n\n  " + 60 * (Convert.ToInt32(textBox11.Text)));
            }
            else
            {
                s3 = 0;
            }
            if (checkBox28.Checked == true)
            {
                str1 += "\r\n\n Thai tea";
                textBox30.Text += ("\r\n\n 35");
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox12.Text)) + " แก้ว");
                s4 = 35 * (Convert.ToInt32(textBox12.Text));
                str2 += " \r\n\n Thai tea  ราคา 35 Baht" + "     จำนวน " + (Convert.ToInt32(textBox12.Text)) + " แก้ว";
                p += 1;
               a += ("\r\n\n 35");
                 b += (("\r\n\n" + textBox12.Text));
                 c += ("\r\n\n  " + 35 * (Convert.ToInt32(textBox12.Text)));
            }
            else
            {
                s4 = 0;
            }
            if (checkBox29.Checked == true)
            {
                str1 += "\r\n\n Bonsai Milk Tea";
                textBox30.Text += ("\r\n\n 55");
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox13.Text)) + " แก้ว");
                s5 = 55 * (Convert.ToInt32(textBox13.Text));
                str2 += " \r\n\n Bonsai Milk Tea  ราคา 55 Baht" + "     จำนวน " + (Convert.ToInt32(textBox13.Text)) + " แก้ว";
                p += 1;
                a += ("\r\n\n 55");
              b += (("\r\n\n" + textBox13.Text));
                  c += ("\r\n\n  " + 55 * (Convert.ToInt32(textBox13.Text)));
            }
            else
            {
                s5 = 0;
            }
            if (checkBox30.Checked == true)
            {
                str1 += "\r\n\n Dried Fruit Tea";
                textBox30.Text += ("\r\n\n 50");
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox14.Text)) + " แก้ว");
                s6 = 50 * (Convert.ToInt32(textBox14.Text));
                str2 += " \r\n\n Dried Fruit Tea  ราคา 50 Baht" + "     จำนวน " + (Convert.ToInt32(textBox14.Text)) + " แก้ว";
                p += 1;
                 a += ("\r\n\n 50");
                 b += (("\r\n\n" + textBox14.Text));
                  c += ("\r\n\n  " + 50 * (Convert.ToInt32(textBox14.Text)));
            }
            else
            {
                s6 = 0;
            }
            if (checkBox31.Checked == true)
            {
                str1 += "\r\n\n Roselle Tea";
                textBox30.Text += ("\r\n\n 45");
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox15.Text)) + " แก้ว");
                s7 = 45 * (Convert.ToInt32(textBox15.Text));
                str2 += " \r\n\n Roselle Tea  ราคา 45 Baht" + "     จำนวน " + (Convert.ToInt32(textBox15.Text)) + " แก้ว";
                p += 1;
                 a += ("\r\n\n 45");
                 b += (("\r\n\n" + textBox15.Text));
                  c += ("\r\n\n  " + 45 * (Convert.ToInt32(textBox15.Text)));
            }
            else
            {
                s7 = 0;
            }
            if (checkBox32.Checked == true)
            {
                str1 += "\r\n\n Ginger Lemon Tea";
                textBox30.Text += ("\r\n\n 40");
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox16.Text)) + " แก้ว");
                s8 = 40 * (Convert.ToInt32(textBox16.Text));
                str2 += " \r\n\n  Ginger Lemon Tea  ราคา 40 Baht" + "     จำนวน " + (Convert.ToInt32(textBox16.Text)) + " แก้ว";
                p += 1;
                 a += ("\r\n\n 40");
                 b += (("\r\n\n" + textBox16.Text));
                  c += ("\r\n\n  " + 40 * (Convert.ToInt32(textBox16.Text)));
            }
            else
            {
                s8 = 0;
            }
            if (checkBox33.Checked == true)
            {
                str1 += "\r\n\n Ice Ceylon Tea Milk Foam";
                textBox30.Text += ("\r\n\n 55");
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox17.Text)) + " แก้ว");
                s9 = 55 * (Convert.ToInt32(textBox17.Text));
                str2 += " \r\n\n  Ict Ceylon Tea Milk Foam  ราคา 55 Baht" + "     จำนวน " + (Convert.ToInt32(textBox17.Text)) + " แก้ว";
                p += 1;
                 a += ("\r\n\n 55");
                 b += (("\r\n\n" + textBox17.Text));
                  c += ("\r\n\n  " + 55 * (Convert.ToInt32(textBox17.Text)));
            }
            else
            {
                s9 = 0;
            }
            if (checkBox34.Checked == true)
            {
                str1 += "\r\n\n Hot Ceylon Tea Milk Foam";
                textBox30.Text += ("\r\n\n 50");
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox18.Text)) + " แก้ว");
                s10 = 50 * (Convert.ToInt32(textBox18.Text));
                str2 += " \r\n\n  Hot Ceylon Tea Milk Foam  ราคา 50 Baht" + "     จำนวน " + (Convert.ToInt32(textBox18.Text)) + " แก้ว";
                p += 1;
                 a += ("\r\n\n 50");
                 b += (("\r\n\n" + textBox18.Text));
                  c += ("\r\n\n  " + 50 * (Convert.ToInt32(textBox18.Text)));
            }
            else
            {
                s10 = 0;
            }
            if (checkBox35.Checked == true)
            {
                str1 += "\r\n\n Brownie";
                textBox30.Text += ("\r\n\n 40");
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox19.Text)) + " ชิ้น");
                d1 = 40 * (Convert.ToInt32(textBox19.Text));
                str2 += " \r\n\n  Brownie  ราคา 40 Baht" + "     จำนวน " + (Convert.ToInt32(textBox19.Text)) + " แก้ว";
                p += 1;
                 a += ("\r\n\n 40");
                 b += (("\r\n\n" + textBox19.Text));
                  c += ("\r\n\n  " + 40 * (Convert.ToInt32(textBox19.Text)));
            }
            else
            {
                d1 = 0;
            }
            if (checkBox36.Checked == true)
            {
                str1 += "\r\n\n Chocolate Lava";
                textBox30.Text += ("\r\n\n 55");
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox20.Text)) + " ชิ้น");
                d2 = 55 * (Convert.ToInt32(textBox20.Text));
                str2 += " \r\n\n  Chocolate Lava  ราคา 55 Baht" + "     จำนวน " + (Convert.ToInt32(textBox20.Text)) + " แก้ว";
                p += 1;
                 a += ("\r\n\n 55");
                 b += (("\r\n\n" + textBox20.Text));
                  c += ("\r\n\n  " + 55 * (Convert.ToInt32(textBox20.Text)));
            }
            else
            {
                d2 = 0;
            }
            if (checkBox37.Checked == true)
            {
                str1 += "\r\n\n Cheese cake";
                textBox30.Text += ("\r\n\n 50");
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox21.Text)) + " ชิ้น");
                d3 = 50 * (Convert.ToInt32(textBox21.Text));
                str2 += " \r\n\n  Cheese cake  ราคา 50 Baht" + "     จำนวน " + (Convert.ToInt32(textBox21.Text)) + " แก้ว";
                p += 1;
                a += ("\r\n\n 50");
                 b += (("\r\n\n" + textBox21.Text));
                  c += ("\r\n\n  " + 50 * (Convert.ToInt32(textBox21.Text)));
            }
            else
            {
                d3 = 0;
            }
            if (checkBox38.Checked == true)
            {
                str1 += "\r\n\n Waffle";
                textBox30.Text += ("\r\n\n 25");
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox26.Text)) + " ชิ้น");
                d4 = 25 * (Convert.ToInt32(textBox26.Text));
                str2 += " \r\n\n  Waffle  ราคา 25 Baht" + "     จำนวน " + (Convert.ToInt32(textBox26.Text)) + " แก้ว";
                p += 1;
                 a += ("\r\n\n 25");
                 b += (("\r\n\n" + textBox26.Text));
                  c += ("\r\n\n  " + 25 * (Convert.ToInt32(textBox26.Text)));
            }
            else
            {
                d4 = 0;
            }
            if (checkBox39.Checked == true)
            {
                str1 += "\r\n\n Honey Toast";
                textBox30.Text += ("\r\n\n 70");
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox22.Text)) + " ชิ้น");
                d5 = 70 * (Convert.ToInt32(textBox22.Text));
                str2 += " \r\n\n  Honey Toast  ราคา 70 Baht" + "     จำนวน " + (Convert.ToInt32(textBox22.Text)) + " แก้ว";
                p += 1;
                 a += ("\r\n\n 70");
                 b += (("\r\n\n" + textBox22.Text));
                  c += ("\r\n\n  " + 70 * (Convert.ToInt32(textBox22.Text)));
            }
            else
            {
                d5 = 0;
            }
            if (checkBox40.Checked == true)
            {
                str1 += "\r\n\n Fondue";
                textBox30.Text += ("\r\n\n 120");
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox23.Text)) + " ชิ้น");
                d6 = 120 * (Convert.ToInt32(textBox23.Text));
                str2 += " \r\n\n  Fondue  ราคา 120 Baht" + "     จำนวน " + (Convert.ToInt32(textBox23.Text)) + " แก้ว";
                p += 1;
                 a += ("\r\n\n 120");
                 b += (("\r\n\n" + textBox23.Text));
                  c += ("\r\n\n  " + 120 * (Convert.ToInt32(textBox23.Text)));
            }
            else
            {
                d6 = 0;
            }
            if (checkBox41.Checked == true)
            {
                str1 += "\r\n\n Cup Cake";
                textBox30.Text += ("\r\n\n 20");
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox24.Text)) + " ชิ้น");
                d7 = 20 * (Convert.ToInt32(textBox24.Text));
                str2 += " \r\n\n  Cup Cake  ราคา 20 Baht" + "     จำนวน " + (Convert.ToInt32(textBox24.Text)) + " แก้ว";
                p += 1;
                 a += ("\r\n\n 20");
                 b += (("\r\n\n" + textBox24.Text));
                 c += ("\r\n\n  " + 20 * (Convert.ToInt32(textBox24.Text)));
            }
            else
            {
                d7 = 0;
            }
            if (checkBox42.Checked == true)
            {
                str1 += "\r\n\n Red Velvet Cake";
                textBox30.Text += ("\r\n\n 55");
                textBox29.Text += ("\r\n\n จำนวน " + (Convert.ToInt32(textBox25.Text)) + " ชิ้น");
                d8 = 55 * (Convert.ToInt32(textBox25.Text));
                str2 += " \r\n\n Red Velvet Cake   ราคา 55 Baht" + "     จำนวน " + (Convert.ToInt32(textBox25.Text)) + " แก้ว";
                p += 1;
                a += ("\r\n\n 55");
                b += (("\r\n\n" + textBox25.Text));
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
            textBox32.Text = str2;
          
        }
        public string SendData()
        {
            return textBox30.Text;
        }
      
    }
}
