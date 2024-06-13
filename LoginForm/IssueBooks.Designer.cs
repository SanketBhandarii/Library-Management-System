namespace LoginForm
{
    partial class IssueBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBooks));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            comboBox1 = new ComboBox();
            label10 = new Label();
            issueBookDate = new DateTimePicker();
            button4 = new Button();
            label9 = new Label();
            label8 = new Label();
            studContact = new TextBox();
            label7 = new Label();
            label6 = new Label();
            studSem = new TextBox();
            label5 = new Label();
            deptName = new TextBox();
            label4 = new Label();
            studName = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(774, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(366, 42);
            label1.Name = "label1";
            label1.Size = new Size(136, 31);
            label1.TabIndex = 1;
            label1.Text = "Issue Books";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(145, -30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(357, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(12, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 464);
            panel2.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSeaGreen;
            button3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(132, 386);
            button3.Name = "button3";
            button3.Size = new Size(108, 36);
            button3.TabIndex = 3;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(24, 386);
            button2.Name = "button2";
            button2.Size = new Size(102, 36);
            button2.TabIndex = 3;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FloralWhite;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(54, 308);
            button1.Name = "button1";
            button1.Size = new Size(160, 51);
            button1.TabIndex = 2;
            button1.Text = "Search Student";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(38, 239);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 194);
            label2.Name = "label2";
            label2.Size = new Size(197, 28);
            label2.TabIndex = 1;
            label2.Text = "Enter Enrollment No";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, -16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(235, 224);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Ivory;
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(issueBookDate);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(studContact);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(studSem);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(deptName);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(studName);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(274, 139);
            panel3.Name = "panel3";
            panel3.Size = new Size(512, 464);
            panel3.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(242, 229);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(219, 28);
            comboBox1.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(82, 399);
            label10.Name = "label10";
            label10.Size = new Size(357, 23);
            label10.TabIndex = 16;
            label10.Text = "Maximum 3 books can be issued to 1 student";
            // 
            // issueBookDate
            // 
            issueBookDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            issueBookDate.Location = new Point(242, 278);
            issueBookDate.Name = "issueBookDate";
            issueBookDate.Size = new Size(219, 27);
            issueBookDate.TabIndex = 15;
            issueBookDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.InactiveCaption;
            button4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(316, 335);
            button4.Name = "button4";
            button4.Size = new Size(145, 43);
            button4.TabIndex = 14;
            button4.Text = "Issue Book";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(71, 278);
            label9.Name = "label9";
            label9.Size = new Size(145, 25);
            label9.TabIndex = 12;
            label9.Text = "Book Issue Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(71, 229);
            label8.Name = "label8";
            label8.Size = new Size(116, 25);
            label8.TabIndex = 10;
            label8.Text = "Books Name";
            // 
            // studContact
            // 
            studContact.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            studContact.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studContact.Location = new Point(242, 177);
            studContact.Name = "studContact";
            studContact.ReadOnly = true;
            studContact.Size = new Size(219, 31);
            studContact.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(71, 183);
            label7.Name = "label7";
            label7.Size = new Size(147, 25);
            label7.TabIndex = 8;
            label7.Text = "Student Contact";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(71, 183);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 6;
            // 
            // studSem
            // 
            studSem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            studSem.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studSem.Location = new Point(242, 128);
            studSem.Name = "studSem";
            studSem.ReadOnly = true;
            studSem.Size = new Size(219, 31);
            studSem.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(71, 134);
            label5.Name = "label5";
            label5.Size = new Size(161, 25);
            label5.TabIndex = 4;
            label5.Text = "Student Semester";
            // 
            // deptName
            // 
            deptName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            deptName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deptName.Location = new Point(242, 84);
            deptName.Name = "deptName";
            deptName.ReadOnly = true;
            deptName.Size = new Size(219, 31);
            deptName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(71, 84);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 2;
            label4.Text = "Department";
            // 
            // studName
            // 
            studName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            studName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studName.Location = new Point(242, 31);
            studName.Name = "studName";
            studName.ReadOnly = true;
            studName.Size = new Size(219, 31);
            studName.TabIndex = 1;
            studName.TextChanged += studName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(71, 37);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 0;
            label3.Text = "Student Name";
            // 
            // IssueBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(798, 615);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IssueBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IssueBooks";
            Load += IssueBooks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Panel panel3;
        private Label label8;
        private TextBox studContact;
        private Label label7;
        private Label label6;
        private TextBox studSem;
        private Label label5;
        private TextBox deptName;
        private Label label4;
        private TextBox studName;
        private Label label3;
        private Button button4;
        private Label label9;
        private Label label10;
        private DateTimePicker issueBookDate;
        private ComboBox comboBox1;
    }
}