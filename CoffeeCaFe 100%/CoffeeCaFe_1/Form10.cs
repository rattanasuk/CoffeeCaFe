using MySql.Data.MySqlClient;
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
    public partial class Form10 : Form
    {
        
        private Form8 op2;
        public Form10()
        {
            InitializeComponent();
            this.textBox2.AutoSize = false;
            this.textBox2.Size = new Size(this.textBox2.Size.Width, 35);

            this.textBox1.AutoSize = false;
            this.textBox1.Size = new Size(this.textBox1.Size.Width, 35);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            op2 = new Form8();
            op2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql3 = "SELECT * FROM staffs";
            MySqlConnection con3 = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=coffee cafe");
            MySqlCommand cmd1 = new MySqlCommand(sql3, con3);

            con3.Open();
            MySqlDataReader reader3 = cmd1.ExecuteReader();
            List<string> StaffID = new List<string>();
            List<string> StaffCode = new List<string>();
            List<string> StaffName = new List<string>();
            List<string> Gender = new List<string>();
            List<string> StaffPassword = new List<string>();
            List<string> StaffLevel = new List<string>();
            while (reader3.Read())
            {
                StaffID.Add(reader3.GetString("StaffID"));
                StaffCode.Add(reader3.GetString("StaffCode"));
                StaffName.Add(reader3.GetString("StaffName"));
                Gender.Add(reader3.GetString("Gender"));
                StaffPassword.Add(reader3.GetString("StaffPassword"));
                StaffLevel.Add(reader3.GetString("StaffLevel"));
            }
            int checkloop = 0;
            for (int i = 0; i < StaffID.Count; ++i)
            {
                if (StaffLevel[i] == "Staff")
                {
                    if (textBox1.Text == StaffID[i])
                    {
                       
                        if (textBox2.Text == StaffPassword[i])
                        {
                           
                            checkloop = 1;
                           


                            Form5 form5 = new Form5();
                            form5.Show();
                            form5.GetData(SendData());
                            this.Hide();
                           
                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                }
                if (StaffLevel[i] == "Manager")
                {
                   
                    if (textBox1.Text == StaffID[i])
                    {

                      
                        if (textBox2.Text == StaffPassword[i])
                        {
                            
                            checkloop = 1;
                            Form2 form2 = new Form2();
                            form2.Show();
                            this.Hide();
                            
                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                }
                if (StaffLevel[i] == "Admin")
                {
                    if (textBox1.Text == StaffID[i])
                    {
                       
                        if (textBox2.Text == StaffPassword[i])
                        {

                            checkloop = 1;

                            Form5 form5 = new Form5();
                            form5.GetData(SendData());
                            form5.Show();
                            this.Hide();
                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                }

            }
            if (checkloop == 0)
            {
                MessageBox.Show("ID or Password ไม่ถูกต้อง");
            }




        }
        public string SendData()
        {
            return textBox1.Text;
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "StaftId";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "StaftId")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "password";
                textBox2.ForeColor = Color.Black;
            }
        }
        public void GetDataa(string str)
        {
            textBox3.Text = str;
        }
       
        public string SendDaata()
        {
            return textBox3.Text;
        }
    }
}
