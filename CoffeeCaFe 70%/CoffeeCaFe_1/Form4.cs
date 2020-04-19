using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CoffeeCaFe_1
{
    public partial class Form4 : Form
    {

        static int num = 0;
        static string ass = "";
        static string salid = "";
        static string pri = "";
        
        public Form4(string data, string da, string sen, string ran, string vas, string pi, string aa, string bb, string cc, string[] zxc)
        {
            InitializeComponent();
            textBox3.Text = data;
            textBox5.Text = cc;
            // textBox6.Text = sen;

            
            for(int e=0; e<zxc.Length;e++)
            {
                MessageBox.Show(zxc[e]);
            }










            int se = 0;
            string fg = "";
            for (int l = 0; l < (aa.Length)/2; l++)
             {
               
                for (int p = se; p < se+2; p++)
                 {
                     // textBox4.Text = aa;
                     fg += aa[p];

                 }
                fg += "\r\n\n";
                 se += 2;

             }
            textBox4.Text = "\r\n\n" +fg;
            textBox6.Text = bb;
            

            

            Random rnd = new Random();
            salid = rnd.Next(1000, 9999).ToString();
            textBox2.Text = "\r\n\n" + salid;

            string a = "";

            int sd = Convert.ToInt32(vas);
            string ag = "";
            for (int i = 0; i < sd; i++)
            {
                string agg = (rnd.Next(10000, 99999).ToString());
                ag += agg;
                a = a + "\r\n\n"+ agg;

            }
            textBox1.Text = a;
            num = sd;
            ass = ag;
            pri = aa;

           /* string h = "";
            string jj = "";
            for (int v = 0; v < sd; v++)
            {
                pri = aa;
                textBox4.Text = "\r\n\n" + pri;

                jj += pri;
                h = h + "\r\n\n" + pri;

            }*/


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

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            int asss = 0;
            int assss = 0;


            for (int z = 0; z < num; z++)
            {
                string aaa = "";
                string bbb = "";

                for (int m = asss; m < asss + 5; m++)
                {

                    aaa += ass[m];

                }
                asss += 5;

                for (int l = assss; l < assss + 2; l++)
                {

                    bbb += pri[l];
                    
                }
                assss += 2;
                

                //  MessageBox.Show("" + bbb);

                MySqlCommand command = new MySqlCommand("INSERT INTO `sale_details`(`SaleDetailID`, `SaleID`, `Price`, `Quantity`, `Amount`) VALUES (@sdi, @si, @pr, @qu, @am)", db.getConnection());

                 command.Parameters.Add("@sdi", MySqlDbType.VarChar).Value = aaa;
                 command.Parameters.Add("@si", MySqlDbType.VarChar).Value = salid;
                 command.Parameters.Add("@pr", MySqlDbType.VarChar).Value = bbb;
                 command.Parameters.Add("@qu", MySqlDbType.VarChar).Value = textBox6.Text;
                 command.Parameters.Add("@am", MySqlDbType.VarChar).Value = textBox5.Text;

                      db.openConnection();
                      if (!checkTextBoxesValues())
                      {
                          if (textBox1.Text.Equals(textBox1.Text))
                          {
                              if (checkUsername())
                              {
                                  MessageBox.Show("This Username Already Exists, Select A Different One", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                              }
                              else
                              {
                                  if (command.ExecuteNonQuery() == 1)
                                  {
                                      MessageBox.Show("Your Account Has Been Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                  }
                                  else
                                  {
                                      MessageBox.Show("ERROR");
                                  }
                              }
                          }
                          else
                          {
                              MessageBox.Show("Wrong Confirmation Password", "Password Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                          }

                      }
                      else
                      {
                          MessageBox.Show("Enter Your Informations First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                      }
                      db.closeConnection();

                  }
              }
              public Boolean checkUsername()
              {
                  DB db = new DB();

                  String namenn = textBox1.Text;

                  DataTable table = new DataTable();

                  MySqlDataAdapter adapter = new MySqlDataAdapter();

                  MySqlCommand command = new MySqlCommand("SELECT * FROM `sale_details` WHERE `SaleDetailID` = @sdi", db.getConnection());

                  command.Parameters.Add("@sdi", MySqlDbType.VarChar).Value = namenn;

                  adapter.SelectCommand = command;

                  adapter.Fill(table);
                  if (table.Rows.Count > 0)
                  {
                      return true;
                  }
                  else
                  {
                      return false;
                  }
              }
              public Boolean checkTextBoxesValues()
              {
                  String sdi = textBox1.Text;
                  String si = textBox2.Text;
                  String pr = textBox4.Text;
                  String qu = textBox6.Text;
                  String am = textBox5.Text;





                  if (sdi.Equals("textBox1") || si.Equals("textBox2") ||
                          pr.Equals("textBox4") || qu.Equals("textBox6")
                          || am.Equals("textBox5"))
                  {
                      return true;
                  }
                  else
                  {
                      return false;
                  }

              }
            }
        }
    
