namespace LoginForm
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            SearchBox = new TextBox();
            Refresh = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            Cancel = new Button();
            Delete = new Button();
            Update = new Button();
            Bquantity = new TextBox();
            bq = new Label();
            Bprice = new TextBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            Bpublication = new TextBox();
            label5 = new Label();
            Bauthor = new TextBox();
            label4 = new Label();
            Bname = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 123);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(502, 53);
            label1.Name = "label1";
            label1.Size = new Size(128, 31);
            label1.TabIndex = 2;
            label1.Text = "View Book";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(312, -15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(182, 152);
            label2.Name = "label2";
            label2.Size = new Size(129, 30);
            label2.TabIndex = 1;
            label2.Text = "Book Name";
            label2.Click += label2_Click;
            // 
            // SearchBox
            // 
            SearchBox.BackColor = SystemColors.ButtonHighlight;
            SearchBox.BorderStyle = BorderStyle.None;
            SearchBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBox.Location = new Point(327, 147);
            SearchBox.Multiline = true;
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(275, 34);
            SearchBox.TabIndex = 2;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // Refresh
            // 
            Refresh.BackColor = Color.Cornsilk;
            Refresh.FlatStyle = FlatStyle.Popup;
            Refresh.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Refresh.Location = new Point(625, 147);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(94, 35);
            Refresh.TabIndex = 3;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = false;
            Refresh.Click += Refresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.NavajoWhite;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 201);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(954, 298);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(Cancel);
            panel2.Controls.Add(Delete);
            panel2.Controls.Add(Update);
            panel2.Controls.Add(Bquantity);
            panel2.Controls.Add(bq);
            panel2.Controls.Add(Bprice);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(Bpublication);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(Bauthor);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(Bname);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 512);
            panel2.Name = "panel2";
            panel2.Size = new Size(954, 312);
            panel2.TabIndex = 5;
            // 
            // Cancel
            // 
            Cancel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cancel.Location = new Point(564, 220);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(103, 43);
            Cancel.TabIndex = 15;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Delete
            // 
            Delete.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Delete.Location = new Point(444, 220);
            Delete.Name = "Delete";
            Delete.Size = new Size(103, 43);
            Delete.TabIndex = 14;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Update
            // 
            Update.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Update.Location = new Point(323, 220);
            Update.Name = "Update";
            Update.Size = new Size(103, 43);
            Update.TabIndex = 13;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // Bquantity
            // 
            Bquantity.BorderStyle = BorderStyle.None;
            Bquantity.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bquantity.Location = new Point(689, 148);
            Bquantity.Multiline = true;
            Bquantity.Name = "Bquantity";
            Bquantity.Size = new Size(178, 34);
            Bquantity.TabIndex = 12;
            // 
            // bq
            // 
            bq.AutoSize = true;
            bq.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bq.Location = new Point(488, 148);
            bq.Name = "bq";
            bq.Size = new Size(143, 28);
            bq.TabIndex = 11;
            bq.Text = "Book Quantity";
            // 
            // Bprice
            // 
            Bprice.BorderStyle = BorderStyle.None;
            Bprice.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bprice.Location = new Point(689, 90);
            Bprice.Multiline = true;
            Bprice.Name = "Bprice";
            Bprice.Size = new Size(178, 34);
            Bprice.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(488, 90);
            label7.Name = "label7";
            label7.Size = new Size(109, 28);
            label7.TabIndex = 9;
            label7.Text = "Book Price";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(689, 40);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(191, 31);
            dateTimePicker1.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(488, 39);
            label6.Name = "label6";
            label6.Size = new Size(195, 28);
            label6.TabIndex = 6;
            label6.Text = "Book Purchase Date";
            // 
            // Bpublication
            // 
            Bpublication.BorderStyle = BorderStyle.None;
            Bpublication.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bpublication.Location = new Point(227, 155);
            Bpublication.Multiline = true;
            Bpublication.Name = "Bpublication";
            Bpublication.Size = new Size(199, 34);
            Bpublication.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(55, 155);
            label5.Name = "label5";
            label5.Size = new Size(166, 28);
            label5.TabIndex = 4;
            label5.Text = "Book Publication";
            // 
            // Bauthor
            // 
            Bauthor.BorderStyle = BorderStyle.None;
            Bauthor.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bauthor.Location = new Point(227, 96);
            Bauthor.Multiline = true;
            Bauthor.Name = "Bauthor";
            Bauthor.Size = new Size(199, 34);
            Bauthor.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 96);
            label4.Name = "label4";
            label4.Size = new Size(128, 28);
            label4.TabIndex = 2;
            label4.Text = "Book Author";
            // 
            // Bname
            // 
            Bname.BorderStyle = BorderStyle.None;
            Bname.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bname.Location = new Point(227, 39);
            Bname.Multiline = true;
            Bname.Name = "Bname";
            Bname.Size = new Size(199, 34);
            Bname.TabIndex = 1;
            Bname.TextChanged += Bname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 39);
            label3.Name = "label3";
            label3.Size = new Size(119, 28);
            label3.TabIndex = 0;
            label3.Text = "Book Name";
            // 
            // ViewBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1007, 509);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(Refresh);
            Controls.Add(SearchBox);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewBook";
            Load += ViewBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label2;
        private TextBox SearchBox;
        private Button Refresh;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TextBox Bpublication;
        private Label label5;
        private TextBox Bauthor;
        private Label label4;
        private TextBox Bname;
        private Label label3;
        private Button Cancel;
        private Button Delete;
        private Button Update;
        private TextBox Bquantity;
        private Label bq;
        private TextBox Bprice;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Label label6;
    }
}