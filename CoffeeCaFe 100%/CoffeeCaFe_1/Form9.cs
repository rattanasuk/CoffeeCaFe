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
            string sql = "SELECT * FROM products";

            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=coffee cafe");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            dataG.DataSource = ds.Tables[0].DefaultView;
            con.Close();

            
        }
        public void GetData(string str)
        {
            textBox1.Text = str;
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
            asd.GetData(SendData());
            asd.Show();
            this.Close();
        }
        public string SendData()
        {
            return textBox1.Text;
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

        private void button3_Click(object sender, EventArgs e)
        {
            update();
           
        }
        private void update()
        {
            DB db = new DB();
            MySqlCommand CmdLoad = new MySqlCommand("SELECT * FROM  products", db.getConnection());
            if (CmdLoad.Connection.State == ConnectionState.Open)
                CmdLoad.Connection.Close();

            CmdLoad.Connection.Open();

            DataSet DsLoad = new DataSet();

            MySqlDataAdapter DaLoad = new MySqlDataAdapter(CmdLoad);

            DaLoad.Fill(DsLoad);

            dataG.DataSource = DsLoad.Tables[0].DefaultView;

            DsLoad = null;

            DaLoad = null;

            CmdLoad.Connection.Close();

            CmdLoad = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (dataG.SelectedRows.Count == 0)
                return; 
            string sql = "DELETE FROM products WHERE ProductID = @rowID";

            using (MySqlConnection myConnection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=coffee cafe"))
            using (MySqlCommand deleteRecord = new MySqlCommand(sql, myConnection))
            {
                myConnection.Open();

                int selectedIndex = dataG.SelectedRows[0].Index;

                int rowID = Convert.ToInt32(dataG[0, selectedIndex].Value);

                deleteRecord.Parameters.Add("@rowID", MySqlDbType.Int32).Value = rowID;
                deleteRecord.ExecuteNonQuery();

                dataG.Rows.RemoveAt(selectedIndex);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form2 mn = new Form2();
            mn.Show();
            this.Close();
        }
    }
    
}
