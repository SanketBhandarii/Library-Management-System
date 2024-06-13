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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (StudName.Text != "" && Enrol.Text != "" && Dept.Text != "" && Sem.Text != "" && Contact.Text != "")
            {
                if (MessageBox.Show("Are you sure want to save details?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (IsNumeric(StudName.Text) || IsNumeric(Dept.Text) || !Int64.TryParse(Contact.Text, out _) || Contact.Text.Length != 10 || !Int64.TryParse(Sem.Text, out _))
                    {
                        MessageBox.Show("Some Values Entered are not valid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        String ConnectionString = "data source = LAPTOP-79CO0EVV\\SQLEXPRESS06;DATABASE=LibraryManagementSystem;Integrated Security = True";
                        SqlConnection con = new SqlConnection(ConnectionString);
                        con.Open();
                        String studname = StudName.Text;
                        String enrol = Enrol.Text;
                        String dept = Dept.Text;
                        String sem = Sem.Text;
                        String contact = Contact.Text;
                        String query = "INSERT INTO newStudent (sname, enroll, dep, sem, contact) VALUES('" + studname + "', '" + enrol + "', '" + dept + "', '" + sem + "', '" + contact + "');";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("All Details Successfully Saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all the details", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudName.Text = "";
            Enrol.Text = "";
            Dept.Text = "";
            Sem.Text = "";
            Contact.Text = "";
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

        private void Contact_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
