namespace LoginForm
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            addNewBookToolStripMenuItem = new ToolStripMenuItem();
            viewBooksToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            addStudentToolStripMenuItem = new ToolStripMenuItem();
            viewStudentInfoToolStripMenuItem = new ToolStripMenuItem();
            issueBookToolStripMenuItem = new ToolStripMenuItem();
            returnBookToolStripMenuItem = new ToolStripMenuItem();
            completeBookDetailsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(247, 250, 250);
            menuStrip1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, studentToolStripMenuItem, issueBookToolStripMenuItem, returnBookToolStripMenuItem, completeBookDetailsToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1136, 58);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.BackColor = Color.FromArgb(247, 250, 250);
            booksToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewBookToolStripMenuItem, viewBooksToolStripMenuItem });
            booksToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            booksToolStripMenuItem.ForeColor = Color.Black;
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(126, 54);
            booksToolStripMenuItem.Text = "Books";
            booksToolStripMenuItem.Click += booksToolStripMenuItem_Click;
            // 
            // addNewBookToolStripMenuItem
            // 
            addNewBookToolStripMenuItem.Image = (Image)resources.GetObject("addNewBookToolStripMenuItem.Image");
            addNewBookToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
            addNewBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            addNewBookToolStripMenuItem.Size = new Size(254, 56);
            addNewBookToolStripMenuItem.Text = "Add New Book";
            addNewBookToolStripMenuItem.Click += addNewBookToolStripMenuItem_Click;
            // 
            // viewBooksToolStripMenuItem
            // 
            viewBooksToolStripMenuItem.Image = (Image)resources.GetObject("viewBooksToolStripMenuItem.Image");
            viewBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            viewBooksToolStripMenuItem.Size = new Size(254, 56);
            viewBooksToolStripMenuItem.Text = "View Books";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addStudentToolStripMenuItem, viewStudentInfoToolStripMenuItem });
            studentToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentToolStripMenuItem.Image = (Image)resources.GetObject("studentToolStripMenuItem.Image");
            studentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(142, 54);
            studentToolStripMenuItem.Text = "Student";
            // 
            // addStudentToolStripMenuItem
            // 
            addStudentToolStripMenuItem.Image = (Image)resources.GetObject("addStudentToolStripMenuItem.Image");
            addStudentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            addStudentToolStripMenuItem.Size = new Size(278, 56);
            addStudentToolStripMenuItem.Text = "Add Student";
            // 
            // viewStudentInfoToolStripMenuItem
            // 
            viewStudentInfoToolStripMenuItem.Image = (Image)resources.GetObject("viewStudentInfoToolStripMenuItem.Image");
            viewStudentInfoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewStudentInfoToolStripMenuItem.Name = "viewStudentInfoToolStripMenuItem";
            viewStudentInfoToolStripMenuItem.Size = new Size(278, 56);
            viewStudentInfoToolStripMenuItem.Text = "View Student Info";
            // 
            // issueBookToolStripMenuItem
            // 
            issueBookToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            issueBookToolStripMenuItem.Image = (Image)resources.GetObject("issueBookToolStripMenuItem.Image");
            issueBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            issueBookToolStripMenuItem.Name = "issueBookToolStripMenuItem";
            issueBookToolStripMenuItem.Size = new Size(165, 54);
            issueBookToolStripMenuItem.Text = "Issue Book";
            // 
            // returnBookToolStripMenuItem
            // 
            returnBookToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnBookToolStripMenuItem.Image = (Image)resources.GetObject("returnBookToolStripMenuItem.Image");
            returnBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            returnBookToolStripMenuItem.Size = new Size(180, 54);
            returnBookToolStripMenuItem.Text = "Return Book";
            returnBookToolStripMenuItem.TextDirection = ToolStripTextDirection.Horizontal;
            // 
            // completeBookDetailsToolStripMenuItem
            // 
            completeBookDetailsToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            completeBookDetailsToolStripMenuItem.Image = (Image)resources.GetObject("completeBookDetailsToolStripMenuItem.Image");
            completeBookDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            completeBookDetailsToolStripMenuItem.Name = "completeBookDetailsToolStripMenuItem";
            completeBookDetailsToolStripMenuItem.Size = new Size(266, 54);
            completeBookDetailsToolStripMenuItem.Text = "Complete Book Details";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(106, 54);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1136, 645);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addNewBookToolStripMenuItem;
        private ToolStripMenuItem viewBooksToolStripMenuItem;
        private ToolStripMenuItem issueBookToolStripMenuItem;
        private ToolStripMenuItem returnBookToolStripMenuItem;
        private ToolStripMenuItem completeBookDetailsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem viewStudentInfoToolStripMenuItem;
    }
}