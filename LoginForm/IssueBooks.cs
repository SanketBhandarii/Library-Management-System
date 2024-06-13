using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LoginForm
{
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            String ConnectionString = "data source = LAPTOP-79CO0EVV\\SQLEXPRESS06;DATABASE=LibraryManagementSystem;Integrated Security = True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "Select bname from newBook";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    comboBox1.Items.Add(reader.GetString(i));
                }
            }
            reader.Close();
            con.Close();
        }

        int count;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enrollment No is empty", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String enroll = textBox1.Text;
                String ConnectionString = "data source = LAPTOP-79CO0EVV\\SQLEXPRESS06;DATABASE=LibraryManagementSystem;Integrated Security = True";
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                String query = "Select * from newStudent where enroll = '" + enroll + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);


                if (ds.Tables[0].Rows.Count != 0)
                {
                    studName.Text = ds.Tables[0].Rows[0][1].ToString();
                    deptName.Text = ds.Tables[0].Rows[0][3].ToString();
                    studSem.Text = ds.Tables[0].Rows[0][4].ToString();
                    studContact.Text = ds.Tables[0].Rows[0][5].ToString();
                }
                else
                {
                    MessageBox.Show("Inavlid Enrollment No", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                studName.Clear();
                studContact.Clear();
                deptName.Clear();
                studSem.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String enroll = textBox1.Text;
            String bookName = comboBox1.SelectedItem.ToString();
            String ConnectionString = "data source = LAPTOP-79CO0EVV\\SQLEXPRESS06;DATABASE=LibraryManagementSystem;Integrated Security = True";
            String query2 = "select count(std_enroll) from IssueBook where std_enroll = '" + enroll + "' and book_return_date is null";
            string query3 = "SELECT COUNT(*) FROM IssueBook WHERE book_name = @bookName AND book_return_date IS NULL";
            using (SqlConnection con2 = new SqlConnection(ConnectionString))
            {
                con2.Open();

                SqlCommand cmd = new SqlCommand(query3, con2);
                cmd.Parameters.AddWithValue("@bookName", bookName);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("This book is already issued.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd2 = new SqlCommand(query2, con);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            count = (int)Convert.ToInt64(ds2.Tables[0].Rows[0][0].ToString());


            if (studName.Text != "")
            {
                if (comboBox1.SelectedIndex != -1 && count < 3)
                {
                    String sname = studName.Text;
                    String ssem = studSem.Text;
                    long scontact = Convert.ToInt64(studContact.Text);
                    String dept = deptName.Text;
                    String bname = comboBox1.Text;
                    String bissue = issueBookDate.Text;
                    con.Open();
                    String query = "insert into IssueBook (std_enroll, std_name, std_dep, std_sem, std_contact, book_issue_date, book_name) values ('" + enroll + "', '" + sname + "', '" + dept + "', '" + ssem + "', '" + scontact + "', '" + bissue + "', '" + bname + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Book Issued Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Select Book, OR maximum number of books has been ISSUED", "Books", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Enrollment No.", "Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void studName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public DateTime SelectedIssueDate
        {
            get { return issueBookDate.Value; }
        }

    }
}
