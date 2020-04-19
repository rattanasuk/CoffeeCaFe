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
        static int sdd = 0;
        static string salid = "";
        static string pri = "";
        static string sddf = "";
        static string hy = "";
        public Form6(string da, string dat, string senm, string ccc, string vasj, string aaa, string yy,string sad)
        {
            InitializeComponent();
            textBox4.Text = da;
            textBox1.Text = dat;
            textBox2.Text = senm;
            textBox3.Text = ccc;
            textBox5.Text = yy;
            textBox5.Text = sad;



            List<string> tre = new List<string>();
            List<string> re = new List<string>();
            string sql = "SELECT * FROM staffs";
            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=coffee cafe");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tre.Add(reader.GetString("StaffName"));
                re.Add(reader.GetString("StaffID"));
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

            }
            textBox9.Text = a;
            sdd = sd;
           sddf = ag;
            hy = senm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                DB dbb = new DB();
                String username = textBox7.Text;
                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand commandd = new MySqlCommand("SELECT * FROM `sales` WHERE `CustomerID` = @usn ", dbb.getConnection());

                commandd.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
                adapter.SelectCommand = commandd;

                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {

                }
                else
                {
                    if (username.Trim().Equals(""))
                    {
                        MessageBox.Show("Enter Your CustomerID", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Wrong CustomerID", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }





















            int z = 0;
            int x = 0;
            int c = 0;
            pri = Convert.ToString(pri);
            for (int p = 0; p < sdd; p++)
            {
                string q = "";
                string s = "";
                string d = "";

                for (int g = z; g < z + 2; g++)
                {
                    q += pri[g];
                    //  MessageBox.Show(q);
                }
                z += 2;
                // MessageBox.Show(q);
                for (int y = x; y < x + 5; y++)
                {
                    s += sddf[y];
                }
                x += 5;
                //MessageBox.Show(s);

                for (int k = c; k < c + 1; k++)
                {
                    d += hy[k];

                }
                c += 1;
                //  MessageBox.Show(d);

                int l = int.Parse(q);
                int t = int.Parse(d);

                int sum = l * t;
                //MessageBox.Show(Convert.ToString(sum));
                
                    DB dbb = new DB();
                    MySqlCommand commandd = new MySqlCommand("INSERT INTO `sale_details`(`SaleDetailID`, `SaleID`, `Price`, `Quantity`, `Amount`) VALUES (@sdi, @si, @pr, @qu, @am)", dbb.getConnection());
                    commandd.Parameters.Add("@sdi", MySqlDbType.VarChar).Value = s;
                    commandd.Parameters.Add("@si", MySqlDbType.VarChar).Value = textBox8.Text;
                    commandd.Parameters.Add("@pr", MySqlDbType.VarChar).Value = price.Text;
                    commandd.Parameters.Add("@qu", MySqlDbType.VarChar).Value = d;
                    commandd.Parameters.Add("@am", MySqlDbType.VarChar).Value = sum;

                    dbb.openConnection();
                    if (!checkTextBoxesValuess())
                    {
                        if (textBox7.Text.Equals(textBox7.Text))
                        {
                            if (checkUsername())
                            {
                                MessageBox.Show("This Username Already Exists, Select A Different One", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (commandd.ExecuteNonQuery() == 1)
                                {
                                    //  MessageBox.Show("Your Account Has Been Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    dbb.closeConnection();
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
        public Boolean checkTextBoxesValuess()
        {
            String sdi = textBox9.Text;
            String si = textBox5.Text;
            String pr = price.Text;
            String qu = textBox2.Text;
            String am = textBox3.Text;

            if (sdi.Equals("textBox9") || si.Equals("textBox5") ||
                    pr.Equals("price") || qu.Equals("textBox2")
                    || am.Equals("textBox3"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        public void GetData(string str)
        {
            price.Text = str;
        }


    }
}
