namespace LoginForm
{
    partial class AddBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooks));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            Cancel = new Button();
            Save = new Button();
            BookQuantity = new TextBox();
            BookPrice = new TextBox();
            BPublication = new TextBox();
            BAuthName = new TextBox();
            BookName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SkyBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-7, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 346);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSalmon;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-7, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 85);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(316, 23);
            label1.Name = "label1";
            label1.Size = new Size(144, 38);
            label1.TabIndex = 0;
            label1.Text = "Add Book";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(240, 238, 213);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(Cancel);
            panel2.Controls.Add(Save);
            panel2.Controls.Add(BookQuantity);
            panel2.Controls.Add(BookPrice);
            panel2.Controls.Add(BPublication);
            panel2.Controls.Add(BAuthName);
            panel2.Controls.Add(BookName);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(317, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(506, 432);
            panel2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(250, 198);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(163, 31);
            dateTimePicker1.TabIndex = 14;
            // 
            // Cancel
            // 
            Cancel.BackColor = Color.MediumAquamarine;
            Cancel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cancel.ForeColor = Color.White;
            Cancel.Location = new Point(242, 369);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(90, 38);
            Cancel.TabIndex = 13;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += Cancel_Click;
            // 
            // Save
            // 
            Save.BackColor = Color.DodgerBlue;
            Save.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Save.ForeColor = Color.White;
            Save.Location = new Point(142, 369);
            Save.Name = "Save";
            Save.Size = new Size(94, 38);
            Save.TabIndex = 12;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // BookQuantity
            // 
            BookQuantity.BorderStyle = BorderStyle.None;
            BookQuantity.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookQuantity.Location = new Point(250, 315);
            BookQuantity.Multiline = true;
            BookQuantity.Name = "BookQuantity";
            BookQuantity.Size = new Size(163, 27);
            BookQuantity.TabIndex = 11;
            // 
            // BookPrice
            // 
            BookPrice.BorderStyle = BorderStyle.None;
            BookPrice.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookPrice.Location = new Point(250, 262);
            BookPrice.Multiline = true;
            BookPrice.Name = "BookPrice";
            BookPrice.Size = new Size(163, 27);
            BookPrice.TabIndex = 10;
            // 
            // BPublication
            // 
            BPublication.BorderStyle = BorderStyle.None;
            BPublication.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BPublication.Location = new Point(250, 142);
            BPublication.Multiline = true;
            BPublication.Name = "BPublication";
            BPublication.Size = new Size(163, 27);
            BPublication.TabIndex = 8;
            // 
            // BAuthName
            // 
            BAuthName.BorderStyle = BorderStyle.None;
            BAuthName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BAuthName.Location = new Point(250, 81);
            BAuthName.Multiline = true;
            BAuthName.Name = "BAuthName";
            BAuthName.Size = new Size(163, 27);
            BAuthName.TabIndex = 7;
            // 
            // BookName
            // 
            BookName.BorderStyle = BorderStyle.None;
            BookName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookName.Location = new Point(250, 28);
            BookName.Multiline = true;
            BookName.Name = "BookName";
            BookName.Size = new Size(163, 27);
            BookName.TabIndex = 6;
            BookName.TextChanged += BookName_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(41, 311);
            label7.Name = "label7";
            label7.Size = new Size(143, 28);
            label7.TabIndex = 5;
            label7.Text = "Book Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(41, 258);
            label6.Name = "label6";
            label6.Size = new Size(109, 28);
            label6.TabIndex = 4;
            label6.Text = "Book Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 196);
            label5.Name = "label5";
            label5.Size = new Size(195, 28);
            label5.TabIndex = 3;
            label5.Text = "Book Purchase Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 138);
            label4.Name = "label4";
            label4.Size = new Size(166, 28);
            label4.TabIndex = 2;
            label4.Text = "Book Publication";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 80);
            label3.Name = "label3";
            label3.Size = new Size(188, 28);
            label3.TabIndex = 1;
            label3.Text = "Book Author Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 27);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 0;
            label2.Text = "Book Name";
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(820, 512);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBooks";
            Load += AddBooks_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox BookQuantity;
        private TextBox BookPrice;
        private TextBox BPublication;
        private TextBox BAuthName;
        private TextBox BookName;
        private Button Cancel;
        private Button Save;
        private DateTimePicker dateTimePicker1;
    }
}