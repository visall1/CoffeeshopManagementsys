namespace EntityCoffeeShop
{
    partial class ProductCards
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
            pictureBox1 = new PictureBox();
            lbName = new Label();
            btnAdd = new Button();
            numericUpDown1 = new NumericUpDown();
            lbPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(16, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(16, 5);
            lbName.Name = "lbName";
            lbName.Size = new Size(50, 20);
            lbName.TabIndex = 1;
            lbName.Text = "label1";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 192, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(139, 204);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(60, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(16, 206);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(115, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(139, 5);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(50, 20);
            lbPrice.TabIndex = 1;
            lbPrice.Text = "label1";
            // 
            // ProductCards
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(numericUpDown1);
            Controls.Add(btnAdd);
            Controls.Add(lbPrice);
            Controls.Add(lbName);
            Controls.Add(pictureBox1);
            Name = "ProductCards";
            Size = new Size(210, 245);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbName;
        private Button btnAdd;
        private NumericUpDown numericUpDown1;
        private Label lbPrice;
    }
}
