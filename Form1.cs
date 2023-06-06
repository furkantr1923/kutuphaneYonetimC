using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphaneYönetimSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-UINS4DB\\SQLEXPRESS ; database=master;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from loginTable where username = '" + textBox1.Text + "' and pass = '" + textBox2.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds); 

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                dashbord dsa = new dashbord();
                dsa.Show();
            }
            else
            {
                MessageBox.Show("YANLIŞ GİRDİNİZ !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pictureBoxTw_Click(object sender, EventArgs e)
        {
            string url = "https://twitter.com/iBBAtaturkKtp";
            System.Diagnostics.Process.Start(url);
        }

        private void pictureBoxinsta_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/ibbkutuphane/");
        }
    }
}