using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginForm
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }
        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        bool IsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (BookName.Text != "" && BAuthName.Text != "" && BPublication.Text != "" && BookPrice.Text != "" && BookQuantity.Text != "")
            {
                if (MessageBox.Show("Are you sure want to add this book?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (IsNumeric(BAuthName.Text) || IsNumeric(BPublication.Text) || !Int64.TryParse(BookPrice.Text, out _) || !Int64.TryParse(BookQuantity.Text, out _))
                    {
                        MessageBox.Show("Some Values Entered are not valid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        System.String ConnectionString = "data source = LAPTOP-79CO0EVV\\SQLEXPRESS06;DATABASE=LibraryManagementSystem;Integrated Security = True";
                        SqlConnection con = new SqlConnection(ConnectionString);
                        con.Open();
                        System.String bname = BookName.Text;
                        System.String bauthor = BAuthName.Text;
                        System.String bpubl = BPublication.Text;
                        System.String bdate = dateTimePicker1.Text;
                        int bprice = Convert.ToInt32(BookPrice.Text);
                        int bquant = Convert.ToInt32(BookQuantity.Text);
                        System.String query = "INSERT INTO newBook (bname, bauthor, bpubl, bdate, bprice, bquant) VALUES('" + bname + "', '" + bauthor + "', '" + bpubl + "', '" + bdate + "', '" + bprice + "', '" + bquant + "');";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("All Book Details Successfully Saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BookName.Text = "";
                        BAuthName.Text = "";
                        BPublication.Text = "";
                        BookPrice.Text = "";
                        BookQuantity.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all the details", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void BookName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}