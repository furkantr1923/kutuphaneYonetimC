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
    public partial class addStudent : Form
    {
        public addStudent()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEnrollement.Clear();
            txtDepartmant.Clear();
            txtSemester.Clear();
            txtContact.Clear();
            txtEmail.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String enroll = txtEnrollement.Text;
            String dep = txtDepartmant.Text;
            String sem = txtSemester.Text;
            Int64 mobile = Int64.Parse(txtContact.Text);
            String email = txtEmail.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-UINS4DB\\SQLEXPRESS; database = master;integrated security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = " insert into NewStudent (sname, enroll, dep, sem, contact, email) values ('"+name+"','"+enroll+"','"+dep+"','"+sem+"',"+mobile+",'"+email+"' )";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("VERİ KAYDEDİLDİ !","BAŞARILI",MessageBoxButtons.OK,MessageBoxIcon.Information);

            
        }
    }
}
