using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace kütüphaneYönetimSistemi
{
    public partial class kitapGor : Form
    {
        public kitapGor()
        {
            InitializeComponent();
        }

        private void kitapGor_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-UINS4DB\\SQLEXPRESS; database = master; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM NewBook";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }
        int bid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                // MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-UINS4DB\\SQLEXPRESS; database = master; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM NewBook where bid = " + bid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtBName1.Text = ds.Tables[0].Rows[0][1].ToString();
            txtAuthor1.Text = ds.Tables[0].Rows[0][2].ToString();
            txtPublication1.Text = ds.Tables[0].Rows[0][3].ToString();
            txtPDate1.Text = ds.Tables[0].Rows[0][4].ToString();
            txtPrice1.Text = ds.Tables[0].Rows[0][5].ToString();
            txtQuantity1.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void butongeri_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void txtBooKName_TextChanged(object sender, EventArgs e)
        {
            if (txtBooKName.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-UINS4DB\\SQLEXPRESS; database = master; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM NewBook where bName LIKE '" + txtBooKName.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-UINS4DB\\SQLEXPRESS; database = master; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM NewBook";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBooKName.Clear();
            panel2.Visible = false;
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            String bname = txtBName1.Text;
            String bauthor = txtAuthor1.Text;
            String publication = txtPublication1.Text;
            String pdate = txtPDate1.Text;
            Int64 price = Int64.Parse(txtPrice1.Text);
            Int64 quan = Int64.Parse(txtQuantity1.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-UINS4DB\\SQLEXPRESS; database = master; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "update NewBook set bName = '" + bname + "',bAuthor = '" + bauthor + "',bPubl = '" + publication + "',bPDate = '" + pdate + "',bPrice = " + price + ",bQuan= " + quan + " where bid=" + rowid + " ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-UINS4DB\\SQLEXPRESS; database = master; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from NewBook where bid="+rowid+"";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);
        }
    }
}
