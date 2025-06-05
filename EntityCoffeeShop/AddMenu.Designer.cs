
namespace EntityCoffeeShop
{
    partial class AddMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMenu));
            btnUpload = new Button();
            pictureBox1 = new PictureBox();
            comboCategories = new ComboBox();
            txtName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSave = new Button();
            btnSwitch = new Button();
            txtPrice = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpload
            // 
            btnUpload.BackColor = SystemColors.GradientActiveCaption;
            btnUpload.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpload.ForeColor = Color.Black;
            btnUpload.Image = (Image)resources.GetObject("btnUpload.Image");
            btnUpload.ImageAlign = ContentAlignment.MiddleRight;
            btnUpload.Location = new Point(491, 180);
            btnUpload.Margin = new Padding(4);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(153, 36);
            btnUpload.TabIndex = 1;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(491, 21);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // comboCategories
            // 
            comboCategories.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboCategories.FormattingEnabled = true;
            comboCategories.Location = new Point(136, 141);
            comboCategories.Margin = new Padding(4);
            comboCategories.Name = "comboCategories";
            comboCategories.Size = new Size(299, 28);
            comboCategories.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(136, 28);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(299, 31);
            txtName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(14, 87);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 0;
            label3.Text = "Price : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(14, 141);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 0;
            label4.Text = "Category : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(14, 28);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 0;
            label5.Text = "Name :";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(337, 183);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 33);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnSwitch
            // 
            btnSwitch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSwitch.Location = new Point(136, 183);
            btnSwitch.Name = "btnSwitch";
            btnSwitch.Size = new Size(98, 33);
            btnSwitch.TabIndex = 6;
            btnSwitch.Text = "Cancel";
            btnSwitch.UseVisualStyleBackColor = true;
            btnSwitch.Click += btnCancel_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(136, 84);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(299, 31);
            txtPrice.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(260, 9);
            label1.Name = "label1";
            label1.Size = new Size(245, 25);
            label1.TabIndex = 8;
            label1.Text = "ADD NEW PRODUCT MENU:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnSwitch);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnUpload);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(comboCategories);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(27, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 286);
            panel1.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(240, 183);
            button1.Name = "button1";
            button1.Size = new Size(91, 33);
            button1.TabIndex = 6;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Delete_Click;
            // 
            // AddMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.8F);
            Margin = new Padding(4);
            Name = "AddMenu";
            Size = new Size(703, 337);
            Load += AddMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private Button btnUpload;
        private PictureBox pictureBox1;
        private ComboBox comboCategories;
        private TextBox txtName;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSave;
        private Button btnSwitch;
        private TextBox txtPrice;
        private Label label1;
        private Panel panel1;
        private Button button1;
    }
}
