namespace LoginForm
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            Contact = new TextBox();
            label6 = new Label();
            Sem = new TextBox();
            label5 = new Label();
            Dept = new TextBox();
            label4 = new Label();
            Enrol = new TextBox();
            label3 = new Label();
            StudName = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSalmon;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(865, 105);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label1.Location = new Point(411, 34);
            label1.Name = "label1";
            label1.Size = new Size(158, 35);
            label1.TabIndex = 1;
            label1.Text = "Add Student";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(324, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(-2, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 436);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(40, 75);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(215, 287);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(Contact);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(Sem);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(Dept);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(Enrol);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(StudName);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(292, 99);
            panel3.Name = "panel3";
            panel3.Size = new Size(571, 436);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.Khaki;
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(337, 298);
            button3.Name = "button3";
            button3.Size = new Size(106, 44);
            button3.TabIndex = 12;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lavender;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(224, 298);
            button2.Name = "button2";
            button2.Size = new Size(106, 44);
            button2.TabIndex = 11;
            button2.Text = "Save Info";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LemonChiffon;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(113, 298);
            button1.Name = "button1";
            button1.Size = new Size(106, 44);
            button1.TabIndex = 10;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Contact
            // 
            Contact.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Contact.Location = new Point(264, 248);
            Contact.Name = "Contact";
            Contact.Size = new Size(195, 30);
            Contact.TabIndex = 9;
            Contact.TextChanged += Contact_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(117, 251);
            label6.Name = "label6";
            label6.Size = new Size(135, 23);
            label6.TabIndex = 8;
            label6.Text = "Student Contact";
            label6.Click += label6_Click;
            // 
            // Sem
            // 
            Sem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Sem.Location = new Point(264, 195);
            Sem.Name = "Sem";
            Sem.Size = new Size(195, 30);
            Sem.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(117, 201);
            label5.Name = "label5";
            label5.Size = new Size(108, 23);
            label5.TabIndex = 6;
            label5.Text = "Student Sem";
            // 
            // Dept
            // 
            Dept.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dept.Location = new Point(264, 140);
            Dept.Name = "Dept";
            Dept.Size = new Size(195, 30);
            Dept.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(117, 144);
            label4.Name = "label4";
            label4.Size = new Size(102, 23);
            label4.TabIndex = 4;
            label4.Text = "Department";
            // 
            // Enrol
            // 
            Enrol.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Enrol.Location = new Point(264, 92);
            Enrol.Name = "Enrol";
            Enrol.Size = new Size(195, 30);
            Enrol.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(117, 96);
            label3.Name = "label3";
            label3.Size = new Size(121, 23);
            label3.TabIndex = 2;
            label3.Text = "Enrollment No";
            // 
            // StudName
            // 
            StudName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudName.Location = new Point(264, 46);
            StudName.Name = "StudName";
            StudName.Size = new Size(195, 30);
            StudName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(117, 50);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 0;
            label2.Text = "Student Name";
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 532);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudent";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private TextBox Contact;
        private Label label6;
        private TextBox Sem;
        private Label label5;
        private TextBox Dept;
        private Label label4;
        private TextBox Enrol;
        private Label label3;
        private TextBox StudName;
        private Label label2;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}