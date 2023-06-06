using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphaneYönetimSistemi
{
    public partial class dashbord : Form
    {
        public dashbord()
        {
            InitializeComponent();
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitapekle abd = new kitapekle();
            abd.Show();
        }

        private void eXİTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ÇIKMAK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void kitapGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitapGor vb = new kitapGor();
            vb.Show();
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addStudent ast = new addStudent();
            ast.Show();
        }

        private void öğrenciBilgisiGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vievStudentInformation vsi = new vievStudentInformation();
            vsi.Show();
        }

        private void kİTAPBASIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitapBasim ib = new kitapBasim();
            ib.Show();
        }

        private void kİTAPİADEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            returnBook rb = new returnBook();
            rb.Show();

        }

        private void kİTAPDETAYLARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            complateBookDetay cbd = new complateBookDetay();
            cbd.Show();
        }
    }
}
