namespace kütüphaneYönetimSistemi
{
    partial class addStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addStudent));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtEnrollement = new TextBox();
            txtDepartmant = new TextBox();
            txtSemester = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            btnRefresh = new Button();
            btnSave = new Button();
            btnExit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(334, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-12, 101);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(347, 418);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.BlanchedAlmond;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(379, 148);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 3;
            label1.Text = "ÖĞRENCİ ADI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.BlanchedAlmond;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(379, 203);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 4;
            label2.Text = "KAYIT NO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.BlanchedAlmond;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(379, 261);
            label3.Name = "label3";
            label3.Size = new Size(83, 28);
            label3.TabIndex = 5;
            label3.Text = "BÖLÜM";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.BlanchedAlmond;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(379, 313);
            label4.Name = "label4";
            label4.Size = new Size(187, 28);
            label4.TabIndex = 6;
            label4.Text = "ÖĞRENCİ DÖNEMİ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.BlanchedAlmond;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(379, 366);
            label5.Name = "label5";
            label5.Size = new Size(186, 28);
            label5.TabIndex = 7;
            label5.Text = "ÖĞRENCİ İLETİŞİM";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.BlanchedAlmond;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(379, 419);
            label6.Name = "label6";
            label6.Size = new Size(173, 28);
            label6.TabIndex = 8;
            label6.Text = "ÖĞRENCİ E-MAİL";
            // 
            // txtName
            // 
            txtName.Location = new Point(577, 149);
            txtName.Name = "txtName";
            txtName.Size = new Size(244, 27);
            txtName.TabIndex = 9;
            // 
            // txtEnrollement
            // 
            txtEnrollement.Location = new Point(577, 205);
            txtEnrollement.Name = "txtEnrollement";
            txtEnrollement.Size = new Size(244, 27);
            txtEnrollement.TabIndex = 10;
            // 
            // txtDepartmant
            // 
            txtDepartmant.Location = new Point(577, 261);
            txtDepartmant.Name = "txtDepartmant";
            txtDepartmant.Size = new Size(244, 27);
            txtDepartmant.TabIndex = 11;
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(577, 314);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(244, 27);
            txtSemester.TabIndex = 12;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(577, 367);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(244, 27);
            txtContact.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(577, 420);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(244, 27);
            txtEmail.TabIndex = 14;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Chartreuse;
            btnRefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRefresh.Location = new Point(484, 462);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 46);
            btnRefresh.TabIndex = 15;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Blue;
            btnSave.FlatStyle = FlatStyle.System;
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSave.Location = new Point(606, 462);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 46);
            btnSave.TabIndex = 16;
            btnSave.Text = "SAVE INFO";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Cyan;
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnExit.Location = new Point(727, 462);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 46);
            btnExit.TabIndex = 17;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // addStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(882, 520);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(btnRefresh);
            Controls.Add(txtEmail);
            Controls.Add(txtContact);
            Controls.Add(txtSemester);
            Controls.Add(txtDepartmant);
            Controls.Add(txtEnrollement);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "addStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addStudent";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtEnrollement;
        private TextBox txtDepartmant;
        private TextBox txtSemester;
        private TextBox txtContact;
        private TextBox txtEmail;
        private Button btnRefresh;
        private Button btnSave;
        private Button btnExit;
    }
}