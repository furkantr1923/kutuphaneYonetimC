namespace kütüphaneYönetimSistemi
{
    partial class dashbord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashbord));
            menuStrip1 = new MenuStrip();
            kİTAPLARToolStripMenuItem = new ToolStripMenuItem();
            kitapEkleToolStripMenuItem = new ToolStripMenuItem();
            kitapGörToolStripMenuItem = new ToolStripMenuItem();
            öĞRENCİToolStripMenuItem = new ToolStripMenuItem();
            öğrenciEkleToolStripMenuItem = new ToolStripMenuItem();
            öğrenciBilgisiGörToolStripMenuItem = new ToolStripMenuItem();
            kİTAPBASIMToolStripMenuItem = new ToolStripMenuItem();
            kİTAPİADEToolStripMenuItem = new ToolStripMenuItem();
            kİTAPDETAYLARIToolStripMenuItem = new ToolStripMenuItem();
            eXİTToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Cornsilk;
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { kİTAPLARToolStripMenuItem, öĞRENCİToolStripMenuItem, kİTAPBASIMToolStripMenuItem, kİTAPİADEToolStripMenuItem, kİTAPDETAYLARIToolStripMenuItem, eXİTToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(993, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // kİTAPLARToolStripMenuItem
            // 
            kİTAPLARToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kitapEkleToolStripMenuItem, kitapGörToolStripMenuItem });
            kİTAPLARToolStripMenuItem.Image = (Image)resources.GetObject("kİTAPLARToolStripMenuItem.Image");
            kİTAPLARToolStripMenuItem.Name = "kİTAPLARToolStripMenuItem";
            kİTAPLARToolStripMenuItem.Size = new Size(131, 32);
            kİTAPLARToolStripMenuItem.Text = "KİTAPLAR";
            // 
            // kitapEkleToolStripMenuItem
            // 
            kitapEkleToolStripMenuItem.Image = (Image)resources.GetObject("kitapEkleToolStripMenuItem.Image");
            kitapEkleToolStripMenuItem.Name = "kitapEkleToolStripMenuItem";
            kitapEkleToolStripMenuItem.Size = new Size(184, 32);
            kitapEkleToolStripMenuItem.Text = "Kitap Ekle";
            kitapEkleToolStripMenuItem.Click += kitapEkleToolStripMenuItem_Click;
            // 
            // kitapGörToolStripMenuItem
            // 
            kitapGörToolStripMenuItem.Image = (Image)resources.GetObject("kitapGörToolStripMenuItem.Image");
            kitapGörToolStripMenuItem.Name = "kitapGörToolStripMenuItem";
            kitapGörToolStripMenuItem.Size = new Size(184, 32);
            kitapGörToolStripMenuItem.Text = "Kitap Gör";
            kitapGörToolStripMenuItem.Click += kitapGörToolStripMenuItem_Click;
            // 
            // öĞRENCİToolStripMenuItem
            // 
            öĞRENCİToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { öğrenciEkleToolStripMenuItem, öğrenciBilgisiGörToolStripMenuItem });
            öĞRENCİToolStripMenuItem.Image = (Image)resources.GetObject("öĞRENCİToolStripMenuItem.Image");
            öĞRENCİToolStripMenuItem.Name = "öĞRENCİToolStripMenuItem";
            öĞRENCİToolStripMenuItem.Size = new Size(129, 32);
            öĞRENCİToolStripMenuItem.Text = "ÖĞRENCİ";
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            öğrenciEkleToolStripMenuItem.Image = (Image)resources.GetObject("öğrenciEkleToolStripMenuItem.Image");
            öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            öğrenciEkleToolStripMenuItem.Size = new Size(261, 32);
            öğrenciEkleToolStripMenuItem.Text = "Öğrenci Ekle";
            öğrenciEkleToolStripMenuItem.Click += öğrenciEkleToolStripMenuItem_Click;
            // 
            // öğrenciBilgisiGörToolStripMenuItem
            // 
            öğrenciBilgisiGörToolStripMenuItem.Image = (Image)resources.GetObject("öğrenciBilgisiGörToolStripMenuItem.Image");
            öğrenciBilgisiGörToolStripMenuItem.Name = "öğrenciBilgisiGörToolStripMenuItem";
            öğrenciBilgisiGörToolStripMenuItem.Size = new Size(261, 32);
            öğrenciBilgisiGörToolStripMenuItem.Text = "Öğrenci Bilgisi Gör";
            öğrenciBilgisiGörToolStripMenuItem.Click += öğrenciBilgisiGörToolStripMenuItem_Click;
            // 
            // kİTAPBASIMToolStripMenuItem
            // 
            kİTAPBASIMToolStripMenuItem.Image = (Image)resources.GetObject("kİTAPBASIMToolStripMenuItem.Image");
            kİTAPBASIMToolStripMenuItem.Name = "kİTAPBASIMToolStripMenuItem";
            kİTAPBASIMToolStripMenuItem.Size = new Size(194, 32);
            kİTAPBASIMToolStripMenuItem.Text = "KİTAP TRANSFER";
            kİTAPBASIMToolStripMenuItem.Click += kİTAPBASIMToolStripMenuItem_Click;
            // 
            // kİTAPİADEToolStripMenuItem
            // 
            kİTAPİADEToolStripMenuItem.Image = (Image)resources.GetObject("kİTAPİADEToolStripMenuItem.Image");
            kİTAPİADEToolStripMenuItem.Name = "kİTAPİADEToolStripMenuItem";
            kİTAPİADEToolStripMenuItem.Size = new Size(118, 32);
            kİTAPİADEToolStripMenuItem.Text = "SEARCH";
            kİTAPİADEToolStripMenuItem.Click += kİTAPİADEToolStripMenuItem_Click;
            // 
            // kİTAPDETAYLARIToolStripMenuItem
            // 
            kİTAPDETAYLARIToolStripMenuItem.Image = (Image)resources.GetObject("kİTAPDETAYLARIToolStripMenuItem.Image");
            kİTAPDETAYLARIToolStripMenuItem.Name = "kİTAPDETAYLARIToolStripMenuItem";
            kİTAPDETAYLARIToolStripMenuItem.Size = new Size(177, 32);
            kİTAPDETAYLARIToolStripMenuItem.Text = "TÜMÜNÜ GÖR";
            kİTAPDETAYLARIToolStripMenuItem.Click += kİTAPDETAYLARIToolStripMenuItem_Click;
            // 
            // eXİTToolStripMenuItem
            // 
            eXİTToolStripMenuItem.Image = (Image)resources.GetObject("eXİTToolStripMenuItem.Image");
            eXİTToolStripMenuItem.Name = "eXİTToolStripMenuItem";
            eXİTToolStripMenuItem.Size = new Size(83, 32);
            eXİTToolStripMenuItem.Text = "EXİT";
            eXİTToolStripMenuItem.Click += eXİTToolStripMenuItem_Click;
            // 
            // dashbord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(993, 451);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "dashbord";
            Text = "dashbord";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem kİTAPLARToolStripMenuItem;
        private ToolStripMenuItem kitapEkleToolStripMenuItem;
        private ToolStripMenuItem kitapGörToolStripMenuItem;
        private ToolStripMenuItem öĞRENCİToolStripMenuItem;
        private ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private ToolStripMenuItem öğrenciBilgisiGörToolStripMenuItem;
        private ToolStripMenuItem kİTAPBASIMToolStripMenuItem;
        private ToolStripMenuItem kİTAPİADEToolStripMenuItem;
        private ToolStripMenuItem kİTAPDETAYLARIToolStripMenuItem;
        private ToolStripMenuItem eXİTToolStripMenuItem;
    }
}