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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `staffs`(`StaffID`, `StaffCode`, `StaffName`, `Gender`, `StaffPassword`, `StaffLevel`) VALUES (@id, @co, @na, @ge, @pa, @la)", db.getConnection());

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id.Text;
            command.Parameters.Add("@co", MySqlDbType.VarChar).Value = co.Text;
            command.Parameters.Add("@na", MySqlDbType.VarChar).Value = na.Text;
            command.Parameters.Add("@ge", MySqlDbType.VarChar).Value = ge.SelectedItem;
            command.Parameters.Add("@pa", MySqlDbType.VarChar).Value = pa.Text;
            command.Parameters.Add("@la", MySqlDbType.VarChar).Value = le.Text;
            db.openConnection();
            if (!checkTextBoxesValues())
            {
                if (id.Text.Equals(id.Text))
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
        public Boolean checkUsername()
        {
            DB db = new DB();

            String namenn = id.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `staffs` WHERE `StaffID` = @id", db.getConnection());

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
            String lname = id.Text;
            String name = co.Text;
            String email = na.Text;
            String uname = ge.Text;
            String pass = pa.Text;
            String der = le.Text;
          



            if (lname.Equals("id") || name.Equals("co") ||
                    email.Equals("na") || uname.Equals("ge")
                    || pass.Equals("pa") || der.Equals("le"))
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
