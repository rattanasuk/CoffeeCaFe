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

            DB db = new DB();

            String username = textBox1.Text;
            String password = textBox2.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `staffs` WHERE `StaffID` = @usn and `StaffPassword` = @pass", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);


            if (table.Rows.Count > 0)
            {
                this.Hide();
                Form5 form1 = new Form5();
                form1.GetData(SendData());
                form1.Show();
            }
            else
            {
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username To Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password To Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Wrong Username Or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
    }
}
