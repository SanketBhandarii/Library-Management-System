namespace LoginForm
{
    partial class ViewStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudent));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            StudentSearchBox = new TextBox();
            button1 = new Button();
            panel2 = new Panel();
            Cancel = new Button();
            Delete = new Button();
            Update = new Button();
            Contact = new TextBox();
            label7 = new Label();
            Sem = new TextBox();
            label6 = new Label();
            Dept = new TextBox();
            Enroll = new TextBox();
            label5 = new Label();
            label4 = new Label();
            StudName = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-3, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 119);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(459, 46);
            label1.Name = "label1";
            label1.Size = new Size(150, 31);
            label1.TabIndex = 1;
            label1.Text = "View Student";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(279, -20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label2.Location = new Point(170, 145);
            label2.Name = "label2";
            label2.Size = new Size(171, 32);
            label2.TabIndex = 3;
            label2.Text = "Enrollment No";
            // 
            // StudentSearchBox
            // 
            StudentSearchBox.BackColor = SystemColors.ControlLight;
            StudentSearchBox.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentSearchBox.Location = new Point(347, 146);
            StudentSearchBox.Name = "StudentSearchBox";
            StudentSearchBox.Size = new Size(227, 31);
            StudentSearchBox.TabIndex = 4;
            StudentSearchBox.TextChanged += StudentSearchBox_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(600, 142);
            button1.Name = "button1";
            button1.Size = new Size(112, 35);
            button1.TabIndex = 5;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MistyRose;
            panel2.Controls.Add(Cancel);
            panel2.Controls.Add(Delete);
            panel2.Controls.Add(Update);
            panel2.Controls.Add(Contact);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(Sem);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(Dept);
            panel2.Controls.Add(Enroll);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(StudName);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(38, 513);
            panel2.Name = "panel2";
            panel2.Size = new Size(919, 319);
            panel2.TabIndex = 6;
            // 
            // Cancel
            // 
            Cancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancel.Location = new Point(742, 210);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(96, 45);
            Cancel.TabIndex = 32;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click_1;
            // 
            // Delete
            // 
            Delete.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.Location = new Point(610, 210);
            Delete.Name = "Delete";
            Delete.Size = new Size(101, 45);
            Delete.TabIndex = 31;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Update
            // 
            Update.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update.Location = new Point(483, 210);
            Update.Name = "Update";
            Update.Size = new Size(101, 45);
            Update.TabIndex = 30;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // Contact
            // 
            Contact.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Contact.Location = new Point(660, 125);
            Contact.Name = "Contact";
            Contact.Size = new Size(162, 31);
            Contact.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.MistyRose;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(493, 125);
            label7.Name = "label7";
            label7.Size = new Size(147, 25);
            label7.TabIndex = 28;
            label7.Text = "Student Contact";
            // 
            // Sem
            // 
            Sem.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Sem.Location = new Point(660, 63);
            Sem.Name = "Sem";
            Sem.Size = new Size(162, 31);
            Sem.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.MistyRose;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(493, 66);
            label6.Name = "label6";
            label6.Size = new Size(161, 25);
            label6.TabIndex = 26;
            label6.Text = "Student Semester";
            // 
            // Dept
            // 
            Dept.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dept.Location = new Point(241, 186);
            Dept.Name = "Dept";
            Dept.Size = new Size(162, 31);
            Dept.TabIndex = 25;
            // 
            // Enroll
            // 
            Enroll.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Enroll.Location = new Point(241, 128);
            Enroll.Name = "Enroll";
            Enroll.Size = new Size(162, 31);
            Enroll.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MistyRose;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(103, 128);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 23;
            label5.Text = "Enrollment No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MistyRose;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(103, 188);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 22;
            label4.Text = "Department";
            // 
            // StudName
            // 
            StudName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudName.Location = new Point(241, 66);
            StudName.Name = "StudName";
            StudName.Size = new Size(162, 31);
            StudName.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MistyRose;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(103, 65);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 20;
            label3.Text = "Student Name";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FloralWhite;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(931, 309);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // ViewStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1017, 507);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(StudentSearchBox);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewStudent";
            Load += ViewStudent_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox StudentSearchBox;
        private Button button1;
        private Panel panel2;
        private Button Cancel;
        private Button Delete;
        private Button Update;
        private TextBox Contact;
        private Label label7;
        private TextBox Sem;
        private Label label6;
        private TextBox Dept;
        private TextBox Enroll;
        private Label label5;
        private Label label4;
        private TextBox StudName;
        private Label label3;
        private DataGridView dataGridView1;
    }
}