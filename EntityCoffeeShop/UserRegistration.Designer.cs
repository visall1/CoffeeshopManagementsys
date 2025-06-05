namespace EntityCoffeeShop
{
    partial class UserRegistration
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            txtPassword = new TextBox();
            txtConform = new TextBox();
            txtPhone = new TextBox();
            label1 = new Label();
            txtFullName = new TextBox();
            button1 = new Button();
            txtAddress = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(1337, 625);
            splitContainer1.SplitterDistance = 424;
            splitContainer1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 68);
            label3.Name = "label3";
            label3.Size = new Size(227, 38);
            label3.TabIndex = 12;
            label3.Text = "Welcome Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.pngtree_coffee_shop_poster_background_material_image_172972_2034775056;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(424, 625);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtConform);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(txtEmail);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(909, 625);
            panel1.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(249, 68);
            label2.Name = "label2";
            label2.Size = new Size(281, 38);
            label2.TabIndex = 11;
            label2.Text = "REGISTRATION USER";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10.2F);
            txtPassword.Location = new Point(388, 140);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(278, 30);
            txtPassword.TabIndex = 7;
            // 
            // txtConform
            // 
            txtConform.Font = new Font("Segoe UI", 10.2F);
            txtConform.Location = new Point(388, 187);
            txtConform.Name = "txtConform";
            txtConform.PlaceholderText = "Conform Password";
            txtConform.Size = new Size(278, 30);
            txtConform.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10.2F);
            txtPhone.Location = new Point(62, 230);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone Number";
            txtPhone.Size = new Size(284, 30);
            txtPhone.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(388, 270);
            label1.Name = "label1";
            label1.Size = new Size(116, 23);
            label1.TabIndex = 10;
            label1.Text = "Date of birth :";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 10.2F);
            txtFullName.Location = new Point(62, 187);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Full Name";
            txtFullName.Size = new Size(284, 30);
            txtFullName.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(555, 350);
            button1.Name = "button1";
            button1.Size = new Size(111, 36);
            button1.TabIndex = 9;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10.2F);
            txtAddress.Location = new Point(62, 300);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address";
            txtAddress.Size = new Size(284, 30);
            txtAddress.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10.2F);
            dateTimePicker1.Location = new Point(388, 300);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(278, 30);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.Value = new DateTime(2025, 8, 19, 0, 0, 0, 0);
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10.2F);
            txtUsername.Location = new Point(62, 140);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(284, 30);
            txtUsername.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.2F);
            txtEmail.Location = new Point(388, 230);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(278, 30);
            txtEmail.TabIndex = 2;
            // 
            // UserRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 238, 196);
            Controls.Add(splitContainer1);
            Name = "UserRegistration";
            Size = new Size(1337, 625);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtConform;
        private TextBox txtPhone;
        private Label label1;
        private TextBox txtFullName;
        private Button button1;
        private TextBox txtAddress;
        private DateTimePicker dateTimePicker1;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private Label label3;
    }
}
