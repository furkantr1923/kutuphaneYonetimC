namespace kütüphaneYönetimSistemi
{
    partial class kitapGor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitapGor));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtBooKName = new TextBox();
            btnnrefresh = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            txtPDate1 = new TextBox();
            butongeri = new Button();
            buttondelete = new Button();
            btnguncelle = new Button();
            txtQuantity1 = new TextBox();
            txtPrice1 = new TextBox();
            txtPublication1 = new TextBox();
            txtAuthor1 = new TextBox();
            txtBName1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1106, 141);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(447, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(277, 159);
            label1.Name = "label1";
            label1.Size = new Size(135, 28);
            label1.TabIndex = 1;
            label1.Text = "KİTAP ADI = ";
            // 
            // txtBooKName
            // 
            txtBooKName.Location = new Point(403, 159);
            txtBooKName.Margin = new Padding(3, 4, 3, 4);
            txtBooKName.Name = "txtBooKName";
            txtBooKName.Size = new Size(268, 27);
            txtBooKName.TabIndex = 2;
            txtBooKName.TextChanged += txtBooKName_TextChanged;
            // 
            // btnnrefresh
            // 
            btnnrefresh.BackColor = Color.Chartreuse;
            btnnrefresh.Location = new Point(695, 153);
            btnnrefresh.Margin = new Padding(3, 4, 3, 4);
            btnnrefresh.Name = "btnnrefresh";
            btnnrefresh.Size = new Size(90, 44);
            btnnrefresh.TabIndex = 3;
            btnnrefresh.Text = "YENİLE";
            btnnrefresh.UseVisualStyleBackColor = false;
            btnnrefresh.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 205);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1106, 305);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(txtPDate1);
            panel2.Controls.Add(butongeri);
            panel2.Controls.Add(buttondelete);
            panel2.Controls.Add(btnguncelle);
            panel2.Controls.Add(txtQuantity1);
            panel2.Controls.Add(txtPrice1);
            panel2.Controls.Add(txtPublication1);
            panel2.Controls.Add(txtAuthor1);
            panel2.Controls.Add(txtBName1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 511);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1106, 279);
            panel2.TabIndex = 5;
            // 
            // txtPDate1
            // 
            txtPDate1.Location = new Point(768, 64);
            txtPDate1.Margin = new Padding(3, 4, 3, 4);
            txtPDate1.Name = "txtPDate1";
            txtPDate1.Size = new Size(228, 27);
            txtPDate1.TabIndex = 16;
            // 
            // butongeri
            // 
            butongeri.BackColor = Color.White;
            butongeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            butongeri.Location = new Point(911, 215);
            butongeri.Margin = new Padding(3, 4, 3, 4);
            butongeri.Name = "butongeri";
            butongeri.Size = new Size(97, 60);
            butongeri.TabIndex = 15;
            butongeri.Text = "GERİ";
            butongeri.UseVisualStyleBackColor = false;
            butongeri.Click += butongeri_Click;
            // 
            // buttondelete
            // 
            buttondelete.BackColor = Color.Crimson;
            buttondelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttondelete.Location = new Point(768, 215);
            buttondelete.Margin = new Padding(3, 4, 3, 4);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(99, 60);
            buttondelete.TabIndex = 14;
            buttondelete.Text = "SİL";
            buttondelete.UseVisualStyleBackColor = false;
            buttondelete.Click += buttondelete_Click;
            // 
            // btnguncelle
            // 
            btnguncelle.BackColor = Color.LightSkyBlue;
            btnguncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnguncelle.Location = new Point(614, 215);
            btnguncelle.Margin = new Padding(3, 4, 3, 4);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(113, 60);
            btnguncelle.TabIndex = 13;
            btnguncelle.Text = "GÜNCELLE";
            btnguncelle.UseVisualStyleBackColor = false;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // txtQuantity1
            // 
            txtQuantity1.Location = new Point(768, 163);
            txtQuantity1.Margin = new Padding(3, 4, 3, 4);
            txtQuantity1.Name = "txtQuantity1";
            txtQuantity1.Size = new Size(228, 27);
            txtQuantity1.TabIndex = 11;
            // 
            // txtPrice1
            // 
            txtPrice1.Location = new Point(768, 111);
            txtPrice1.Margin = new Padding(3, 4, 3, 4);
            txtPrice1.Name = "txtPrice1";
            txtPrice1.Size = new Size(228, 27);
            txtPrice1.TabIndex = 10;
            // 
            // txtPublication1
            // 
            txtPublication1.Location = new Point(230, 172);
            txtPublication1.Margin = new Padding(3, 4, 3, 4);
            txtPublication1.Name = "txtPublication1";
            txtPublication1.Size = new Size(202, 27);
            txtPublication1.TabIndex = 8;
            // 
            // txtAuthor1
            // 
            txtAuthor1.Location = new Point(230, 117);
            txtAuthor1.Margin = new Padding(3, 4, 3, 4);
            txtAuthor1.Name = "txtAuthor1";
            txtAuthor1.Size = new Size(202, 27);
            txtAuthor1.TabIndex = 7;
            // 
            // txtBName1
            // 
            txtBName1.Location = new Point(230, 56);
            txtBName1.Margin = new Padding(3, 4, 3, 4);
            txtBName1.Name = "txtBName1";
            txtBName1.Size = new Size(202, 27);
            txtBName1.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(631, 173);
            label7.Name = "label7";
            label7.Size = new Size(107, 20);
            label7.TabIndex = 5;
            label7.Text = "KİTAP MİKTARI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(631, 121);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 4;
            label6.Text = "KİTAP FİYAT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(631, 67);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 3;
            label5.Text = "KİTAP ALIM TARİHİ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 121);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 2;
            label4.Text = "KİTAP YAZAR ADI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 176);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 1;
            label3.Text = "KİTAP YAYIM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 63);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 0;
            label2.Text = "KİTAP ADI";
            // 
            // kitapGor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1105, 479);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(btnnrefresh);
            Controls.Add(txtBooKName);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "kitapGor";
            Text = "kitapGor";
            Load += kitapGor_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtBooKName;
        private Button btnnrefresh;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button butongeri;
        private Button buttondelete;
        private Button btnguncelle;
        private TextBox txtQuantity1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox7;
        private TextBox txtPrice1;
        private TextBox txtPublication1;
        private TextBox txtAuthor1;
        private TextBox txtBName1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtPDate1;
    }
}