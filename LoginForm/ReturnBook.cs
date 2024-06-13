using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String enroll = textBox1.Text;
            String ConnectionString = "data source = LAPTOP-79CO0EVV\\SQLEXPRESS06;DATABASE=LibraryManagementSystem;Integrated Security = True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "select * from IssueBook where std_enroll = '" + enroll + "' and book_return_date is null";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid ID or No Book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                panel2.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
        String bname;
        String bdate;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            textBox2.Text = bname;
            textBox3.Text = bdate;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure student returned the book?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String enroll = textBox1.Text;
                String ConnectionString = "data source = LAPTOP-79CO0EVV\\SQLEXPRESS06;DATABASE=LibraryManagementSystem;Integrated Security = True";
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                String query = "update IssueBook set  book_return_date = '" + dateTimePicker1.Text + "' where std_enroll = '" + enroll + "' and id = '" + rowid + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show("Book Returned Today!", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReturnBook_Load(this, null);
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            IssueBooks issueBooks = new IssueBooks();
            DateTime issueDate = issueBooks.SelectedIssueDate;
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = issueDate;

            TimeSpan difference = date1 - date2;

            if (difference.TotalDays >= 7)
            {
                MessageBox.Show("Since you are returning the book after the deadline, you will have to pay a fine.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
