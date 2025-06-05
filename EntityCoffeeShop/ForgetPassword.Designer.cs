namespace EntityCoffeeShop
{
    partial class ForgetPassword
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
            btnReset = new Button();
            txtUsernameOrEmail = new TextBox();
            txtNewPassword = new TextBox();
            txtconfirmPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.Location = new Point(313, 302);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(131, 32);
            btnReset.TabIndex = 0;
            btnReset.Text = "Reset Password";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtUsernameOrEmail
            // 
            txtUsernameOrEmail.Location = new Point(153, 114);
            txtUsernameOrEmail.Name = "txtUsernameOrEmail";
            txtUsernameOrEmail.Size = new Size(291, 27);
            txtUsernameOrEmail.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(153, 178);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(291, 27);
            txtNewPassword.TabIndex = 1;
            // 
            // txtconfirmPassword
            // 
            txtconfirmPassword.Location = new Point(153, 252);
            txtconfirmPassword.Name = "txtconfirmPassword";
            txtconfirmPassword.Size = new Size(291, 27);
            txtconfirmPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 91);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 2;
            label1.Text = "Username or Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 155);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 229);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 2;
            label3.Text = "Conform Password";
            // 
            // button1
            // 
            button1.Location = new Point(214, 302);
            button1.Name = "button1";
            button1.Size = new Size(93, 32);
            button1.TabIndex = 0;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ForgetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 417);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtconfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtUsernameOrEmail);
            Controls.Add(button1);
            Controls.Add(btnReset);
            Name = "ForgetPassword";
            Text = "ForgetPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReset;
        private TextBox txtUsernameOrEmail;
        private TextBox txtNewPassword;
        private TextBox txtconfirmPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}