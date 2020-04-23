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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;



        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;


            string sql = "SELECT * FROM Staffs";

            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=coffee cafe");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;

            string sql = "SELECT * FROM Products";

            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=coffee cafe");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
            con.Close();
           
            
           /* string sqll = "SELECT * FROM Products";

            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=coffee cafe");
            MySqlCommand cmdd = new MySqlCommand(sqll, conn);
            con.Open();

            DataSet dss = new DataSet();
            MySqlDataAdapter daa = new MySqlDataAdapter(cmdd);
            daa.Fill(dss);
            dataGridView2.DataSource = dss.Tables[0].DefaultView;
            con.Close();*/
        }

      

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form9 op = new Form9();
            op.Show();
            this.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Form8 op = new Form8();
            op.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
            groupBox5.Visible = false;

            string sql = "SELECT * FROM sales";

            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=coffee cafe");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=coffee cafe");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from sales Where SaleDateTime LIKE '%" + textBox1.Text +"%'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox5.Visible = false;





            string sql = "SELECT * FROM sale_details";

            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=coffee cafe");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            dataGridView4.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Form9 op = new Form9();
            op.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = true;

            string sql = "SELECT * FROM customers";

            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=coffee cafe");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            dataGridView5.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=coffee cafe");
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from customers Where CustomerType LIKE '%" + textBox2.Text + "%'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView5.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ne = new Form1();
            ne.Show();
            this.Close();
        }
    }
}

