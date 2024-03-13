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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(321, 432);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 59, 59);
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
            panel2.BackColor = Color.Snow;
            panel2.Location = new Point(317, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(506, 432);
            panel2.TabIndex = 2;
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 235, 235);
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
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
    }
}