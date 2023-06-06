using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
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
    public partial class kitapBasim : Form
    {
        public kitapBasim()
        {
            InitializeComponent();
        }

        private void kitapBasim_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-UINS4DB\\SQLEXPRESS; database=master; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("SELECT bName FROM NewBook;", con);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    comboBoxBooks.Items.Add(Sdr.GetString(i));
                }

            }
            Sdr.Close();
            con.Close();
        }
        int count;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEnrollement.Text != "")
            {
                String eid = txtEnrollement.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-UINS4DB\\SQLEXPRESS; database=master; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM NewStudent where enroll  = '" + eid + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);


                cmd.CommandText = "SELECT count(std_enroll) FROM IRBook where std_enroll  = '" + eid + "' and book_return_date is null";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet DS1 = new DataSet();
                DA.Fill(DS1);

                count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());



                if (DS.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtDepartment.Text = DS.Tables[0].Rows[0][3].ToString();
                    txtSemester.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtContect.Text = DS.Tables[0].Rows[0][5].ToString();
                    txtMail.Text = DS.Tables[0].Rows[0][6].ToString();


                }

                else
                {
                    txtName.Clear();
                    txtDepartment.Clear();
                    txtSemester.Clear();
                    txtContect.Clear();
                    txtMail.Clear();
                    MessageBox.Show("GEÇERSİZ KAYIT NUMARASI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                if (comboBoxBooks.SelectedIndex != -1 && count <= 2)
                {
                    String enroll = txtEnrollement.Text;
                    String sname = txtName.Text;
                    String sdep = txtDepartment.Text;
                    String sem = txtSemester.Text;
                    Int64 contact = Int64.Parse(txtContect.Text);
                    String email = txtMail.Text;
                    String bookname = comboBoxBooks.Text;
                    String bookIssueDate = dateTimePicker.Text;


                    String eid = txtEnrollement.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-UINS4DB\\SQLEXPRESS; database=master; integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    DateTime issueDate = DateTime.Parse(bookIssueDate);
                    DateTime returnDate = issueDate.AddDays(30);
                    string formattedReturnDate = returnDate.ToString("yyyy-MM-dd");

                    cmd.CommandText = "INSERT INTO IRBook(std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_date,book_return_date) values ('" + enroll + "', '" + sname + "','" + sdep + "','" + sem + "'," + contact + ",'" + email + "','" + bookname + "','" + bookIssueDate + "','" + formattedReturnDate + "')";

                    cmd.ExecuteNonQuery();

                    con.Close();



                    MessageBox.Show("KİTAP YAYINLANDI", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {
                    MessageBox.Show("KİTAP SEÇİN. YA DA MAKSİMUM KİTAP SAYISI ÇIKTI.", "KİTAP SEÇİLMEDİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
