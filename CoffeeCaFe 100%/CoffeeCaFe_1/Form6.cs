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
    public partial class Form6 : Form
    {
        static int d = 0;
        static int sdd = 0;
        static string am = "";
        static string salid = "";
        static string pri = "";
        static string sddf = "";
        static string hy = "";
        List<string> saletid = new List<string>();
        public Form6(string da, string dat, string senm, string ccc, string vasj, string aaa, string yy,string sad,string df, string ii, string sadd)
        {
            InitializeComponent();
            textBox4.Text = da;
            textBox1.Text = dat;
            textBox10.Text = senm;
            textBox3.Text = ccc;
            textBox5.Text = yy;
            textBox5.Text = sad;
            textBox5.Text = sadd;
            textBox10.Text = df;

            textBox11.Text = ii;


            List<string> tre = new List<string>();
            List<string> re = new List<string>();
            List<string> rel = new List<string>();
            string sql = "SELECT * FROM staffs";
            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=coffee cafe");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tre.Add(reader.GetString("StaffName"));
                re.Add(reader.GetString("StaffID"));
                rel.Add(reader.GetString("StaffLevel"));

            }
            for(int i=0; i<tre.Count;i++)
            {
                if (yy == re[i])
                {
                    textBox6.Text = tre[i];
                }
            }
            for (int i = 0; i < tre.Count; i++)
            {
                if (sad == re[i])
                {
                    textBox6.Text = tre[i];
                }
            }
            for (int i = 0; i < tre.Count; i++)
            {
                if (sadd == re[i])
                {
                    textBox12.Text = rel[i];
                }
            }



            pri = aaa;
            price.Text = pri;
            Random rnd = new Random();
            salid = rnd.Next(1000, 9999).ToString();
            textBox8.Text = salid;

            string a = "";

            int sd = Convert.ToInt32(vasj);
            string ag = "";
            for (int i = 0; i < sd; i++)
            {
                string agg = (rnd.Next(10000, 99999).ToString());
                ag += agg;
                a = a + "\r\n\n" + agg;
                saletid.Add(agg);
            }

            textBox9.Text = a;
            sdd = sd;
           sddf = ag;
            hy = senm;
            am = dat;
        }
        public Boolean checkUsername()
        {
            DB db = new DB();

            String namenn = textBox8.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `sales` WHERE `SaleID` = @id", db.getConnection());

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = namenn;

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
            String da = textBox8.Text;
            String cid = textBox7.Text;
            String sid = textBox5.Text;
            String gr = textBox4.Text;
            String hr = textBox5.Text;





            if (cid.Equals("textBox7") || sid.Equals("textBox5") ||
                    gr.Equals("textBox4") || da.Equals("textBox8")
                || hr.Equals("datatimepicker"))
            {
                return true;
            }
            else
            {
                return false;
            }

            //-----------------------------------------------------------------------



        }
        public Boolean checkUsernamea()
        {
            DB db = new DB();

            String namenn = textBox8.Text;

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
       /* public Boolean checkTextBoxesValuess()
        {
            String sdi = textBox9.Text;
            String si = textBox5.Text;
            String pr = price.Text;
            String pn = textBox1.Text;
            String qu = textBox2.Text;
            String am = textBox3.Text;

            if (sdi.Equals("textBox9") || si.Equals("textBox5") ||
                    pr.Equals("price") || pn.Equals("textBox1") || qu.Equals("textBox2")
                    || am.Equals("textBox3"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
            private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        public void GetData(string str)
        {
            price.Text = str;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int lkk = 0;
            List<string> dff = new List<string>();
            List<string> dff1 = new List<string>();
            List<string> dff2 = new List<string>();
            List<string> dff3 = new List<string>();
            string[] arr = this.textBox1.Lines;
            foreach (var str in arr)
            {
                    if (str.Trim() != string.Empty)
                    {
                    dff.Add(str);
                    lkk += 1;
                }
                
            }
            string[] arrr = this.textBox10.Lines;
            foreach (var str in arrr)
            {
                if (str.Trim() != string.Empty)
                {
                    dff1.Add(str);
                 
                }
            }
            string[] arra = this.textBox11.Lines;
            foreach (var str in arra)
            {
                if (str.Trim() != string.Empty)
                {
                    dff2.Add(str);
                }
            }
            string[] arrb = this.textBox3.Lines;
            foreach (var str in arrb)
            {
                if (str.Trim() != string.Empty)
                {
                    dff3.Add(str);
                }
            }
            for (int i = 0; i < dff.Count; i++)
            {
                string sql = "INSERT INTO `sale_details`(`SaleDetailID`, `SaleID`, `ProductName`, `Price`, `Quantity`, `Amount`) VALUES ('" + saletid[i] + "','" + textBox8.Text + "','" + dff[i] + "','" + dff1[i] + "','" + dff2[i] + "','" + dff3[i] + "')";
                MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=coffee cafe");
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.ExecuteReader();
                con.Close();


            }


                DB db = new DB();
                MySqlCommand command = new MySqlCommand("INSERT INTO `sales`(`SaleID`, `SaleDateTime`, `CustomerID`, `StaffID`,`GrandTotal`) VALUES (@id, @da, @cid, @sid, @gr)", db.getConnection());


                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBox8.Text;
                command.Parameters.Add("@da", MySqlDbType.DateTime).Value = dateTimePicker1.Value;
                command.Parameters.Add("@cid", MySqlDbType.VarChar).Value = textBox7.Text;
                command.Parameters.Add("@sid", MySqlDbType.VarChar).Value = textBox5.Text;
                command.Parameters.Add("@gr", MySqlDbType.VarChar).Value = textBox4.Text;

                db.openConnection();
                if (!checkTextBoxesValues())
                {
                    if (textBox7.Text.Equals(textBox7.Text))
                    {
                        if (checkUsernamea())
                        {
                            MessageBox.Show("This Username Already Exists, Select A Different One", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("ทำรายการสำเร็จ", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }

