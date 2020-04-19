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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `products`(`ProductID`, `ProductName`, `Price`, `ProductDetail`) VALUES (@id, @na,  @pr, @prd)", db.getConnection());

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id.Text;
            command.Parameters.Add("@na", MySqlDbType.VarChar).Value = na.Text;
            command.Parameters.Add("@pr", MySqlDbType.VarChar).Value = pr.Text;
            command.Parameters.Add("@prd", MySqlDbType.VarChar).Value = prd.Text;
            
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

            MySqlCommand command = new MySqlCommand("SELECT * FROM `products` WHERE `ProductID` = @id", db.getConnection());

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
            String idd = id.Text;
            String name = na.Text;
            String pri = pr.Text;
            String pde = prd.Text;
            if (idd.Equals("id") || name.Equals("na") ||
                    pri.Equals("pr") || pde.Equals("prd"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
