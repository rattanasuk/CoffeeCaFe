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
            if (!checkTextBoxesValue())
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
                    MessageBox.Show("Wrong Confirmation id", "Password Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
        public Boolean checkTextBoxesValue()
        {
            String idd = id.Text;
            String name = na.Text;
            String pri = pr.Text;
            String pde = prd.Text;
            
            if (idd.Equals("ProuctID") || name.Equals("ProductName") ||
                    pri.Equals("Price") || pde.Equals("ProductDetail"))
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
            Form5 asd = new Form5();
            asd.Show();
            this.Close();
        }

       

        private void id_Enter(object sender, EventArgs e)
        {
            if (id.Text == "ProuctID")
            {
                id.Text = "";
                id.ForeColor = Color.Black;
            }
        }

        private void id_Leave(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                id.Text = "ProuctID";
                id.ForeColor = Color.Gray;
            }
        }

        private void na_Enter(object sender, EventArgs e)
        {
            if (na.Text == "ProductName")
            {
                na.Text = "";
                na.ForeColor = Color.Black;
            }
        }

        private void na_Leave(object sender, EventArgs e)
        {
            if (na.Text == "")
            {
                na.Text = "ProductName";
                na.ForeColor = Color.Gray;
            }
        }

        private void pr_Leave(object sender, EventArgs e)
        {
            if (pr.Text == "")
            {
                pr.Text = "Price";
                pr.ForeColor = Color.Gray;
            }
        }

        private void pr_Enter(object sender, EventArgs e)
        {
            if (pr.Text == "Price")
            {
                pr.Text = "";
                pr.ForeColor = Color.Black;
            }
        }

        private void prd_Enter(object sender, EventArgs e)
        {
            if (prd.Text == "ProductDetail")
            {
                prd.Text = "";
                prd.ForeColor = Color.Black;
            }
        }

        private void prd_Leave(object sender, EventArgs e)
        {
            if (prd.Text == "")
            {
                prd.Text = "ProductDetail";
                prd.ForeColor = Color.Gray;
            }
        }

        private void pr_KeyPress(object sender, KeyPressEventArgs e)
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

        private void id_KeyPress(object sender, KeyPressEventArgs e)
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
    }
    
}
