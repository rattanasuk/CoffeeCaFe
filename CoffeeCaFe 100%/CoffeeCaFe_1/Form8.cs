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
            string sql = "SELECT * FROM Staffs";

            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=coffee cafe");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            dataG.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form10 op = new Form10();
            op.Show();
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
            String pas = pa.Text;
            String der = le.Text;
            if (lname.Equals("staftID") || name.Equals("StaftCode") ||
                    email.Equals("StaftName") || uname.Equals("ge")
                    || pas.Equals("StaftPassword") || der.Equals("le"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        private void id_Enter(object sender, EventArgs e)
        {
            if (id.Text == "StaftID")
            {
                id.Text = "";
                id.ForeColor = Color.Black;
            }
        }
        private void id_Leave(object sender, EventArgs e)
        {

            if (id.Text == "")
            {
                id.Text = "StaftID";
                id.ForeColor = Color.Gray;
            }
        }

        

        private void co_Leave(object sender, EventArgs e)
        {
            if (co.Text == "")
            {
                co.Text = "StaftCode";
                co.ForeColor = Color.Gray;
            }
        }

        private void co_Enter(object sender, EventArgs e)
        {
            if (co.Text == "StaftCode")
            {
                co.Text = "";
                co.ForeColor = Color.Black;
            }
        }

        private void na_Enter(object sender, EventArgs e)
        {

            if (na.Text == "StaftName")
            {
                na.Text = "";
                na.ForeColor = Color.Black;
            }
        }

        private void na_Leave(object sender, EventArgs e)
        {

            if (co.Text == "")
            {
                na.Text = "StaftName";
                na.ForeColor = Color.Gray;
            }
        }

        private void pa_Leave(object sender, EventArgs e)
        {
            if (pa.Text == "")
            {
                pa.Text = "StaftPassword";
                pa.ForeColor = Color.Gray;
            }
        }

        private void pa_Enter(object sender, EventArgs e)
        {
            if (pa.Text == "StaftPassword")
            {
                pa.Text = "";
                pa.ForeColor = Color.Black;
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

        private void na_KeyPrass(object sender, KeyPressEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {

            if (dataG.SelectedRows.Count == 0)
                return;
            string sql = "DELETE FROM staffs WHERE StaffID = @rowID";

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

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 asd = new Form2();
            asd.Show();
            
            this.Hide();
        }
    }
    
}
