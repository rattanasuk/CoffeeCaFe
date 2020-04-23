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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `customers`(`CustomerID`, `Username`,`CustomerName`,`CustomerLastname`, `Gender`, `CustomerType`, `CustomerTelNo`, `CustumerEmail`) VALUES (@fn, @Us, @ln, @last, @usn, @Ty, @pass, @Em)", db.getConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = ID.Text;
            command.Parameters.Add("@Us", MySqlDbType.VarChar).Value = Username.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = namen.Text;
            command.Parameters.Add("@last", MySqlDbType.VarChar).Value = Lastname.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Tell.Text;
            command.Parameters.Add("@Ty", MySqlDbType.VarChar).Value = Type.SelectedItem;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = Gender.SelectedItem;
            command.Parameters.Add("@Em", MySqlDbType.VarChar).Value = Email.Text;

            db.openConnection();
            if (!checkTextBoxesValues())
            {
                if (ID.Text.Equals(ID.Text))
                {
                    if (checkUsername())
                    {
                        MessageBox.Show("This Username Already Exists, Select A Different One", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("สมัครเรียบร้อยแล้ว", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            db.closeConnection();

        }
        public Boolean checkUsername()
        {
            DB db = new DB();

            String namenn = ID.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `customers` WHERE `CustomerID` = @fn", db.getConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = namenn;

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
                String lname = Lastname.Text;
                String name = namen.Text;
                String email = Email.Text;
                String uname = Username.Text;
                String pass = ID.Text;
                String der = Gender.Text;
                String sad = Tell.Text;



            if (lname.Equals("Lastname") || name.Equals("namen") ||
                    email.Equals("Email") || uname.Equals("Username")
                    || pass.Equals("ID") || der.Equals("Gender"))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

        private void Gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Username_Enter(object sender, EventArgs e)
        {
            if (Username.Text == "UserName")
            {
                Username.Text = "";
                Username.ForeColor = Color.Black;
            }
        }

        private void Username_Leave(object sender, EventArgs e)
        {

            if (Username.Text == "")
            {
                Username.Text = "UserName";
                Username.ForeColor = Color.Gray;
            }
        }

        private void ID_Enter(object sender, EventArgs e)
        {
            if (ID.Text == "ID")
            {
                ID.Text = "";
                ID.ForeColor = Color.Black;
            }
        }

        private void ID_Leave(object sender, EventArgs e)
        {
            if (ID.Text == "")
            {
                ID.Text = "ID";
                ID.ForeColor = Color.Gray;
            }
        }

        private void namen_Enter(object sender, EventArgs e)
        {
            if (namen.Text == "Name")
            {
                namen.Text = "";
                namen.ForeColor = Color.Black;
            }
        }

        private void namen_Leave(object sender, EventArgs e)
        {
            if (namen.Text == "")
            {
                namen.Text = "Name";
                namen.ForeColor = Color.Gray;
            }
        }

        private void LastName_Leave(object sender, EventArgs e)
        {
            if (Lastname.Text == "")
            {
                Lastname.Text = "LastName";
                Lastname.ForeColor = Color.Gray;
            }
        }

        private void LastName_Enter(object sender, EventArgs e)
        {
            if (Lastname.Text == "LastName")
            {
                Lastname.Text = "";
                Lastname.ForeColor = Color.Black;
            }
        }

        private void Email_Enter(object sender, EventArgs e)
        {
            if (Email.Text == "Email")
            {
               Email.Text = "";
                Email.ForeColor = Color.Black;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (Email.Text == "")
            {
                Email.Text = "Email";
                Email.ForeColor = Color.Gray;
            }
        }

        private void Tell_Leave(object sender, EventArgs e)
        {
            if (Tell.Text == "")
            {
                Tell.Text = "Telphone";
                Tell.ForeColor = Color.Gray;
            }
        }

        private void Tell_Enter(object sender, EventArgs e)
        {
            if (Tell.Text == "Telphone")
            {
               Tell.Text = "";
                Tell.ForeColor = Color.Black;
            }
        }

        private void Tell_KeyPress(object sender, KeyPressEventArgs e)
        {
            int cInt = Convert.ToInt32(e.KeyChar);
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57 || cInt == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกเป็นตัวเลขเท่านั้น");

            }
        }

        private void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            int cInt = Convert.ToInt32(e.KeyChar);
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57 || cInt == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกเป็นตัวเลขเท่านั้น");

            }
        }

        private void Lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            int cInt = Convert.ToInt32(e.KeyChar);
            if ((int)e.KeyChar >= 65 && (int)e.KeyChar <= 122 || cInt == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกเป็นภาษาอังกฤษเท่านั้น");

            }
        }

        private void namen_KeyPress(object sender, KeyPressEventArgs e)
        {
            int cInt = Convert.ToInt32(e.KeyChar);
            if ((int)e.KeyChar >= 65 && (int)e.KeyChar <= 122 || cInt == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกเป็นภาษาอังกฤษเท่านั้น");

            }
        }
    }
}
    

