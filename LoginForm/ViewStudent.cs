using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LoginForm
{
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void Cancel_Click_1(object sender, EventArgs e)
        {
                panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewStudent_Load_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
            String ConnectionString = "data source = LAPTOP-79CO0EVV\\SQLEXPRESS06;DATABASE=LibraryManagementSystem;Integrated Security = True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "select * from newStudent";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        int studid;
        int rowId;

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                String ConnectionString = "data source = LAPTOP-79CO0EVV\\SQLEXPRESS06;DATABASE=LibraryManagementSystem;Integrated Security = True";
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                String query = "delete from newStudent where stuid=" + rowId + "";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void StudentSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (StudentSearchBox.Text != null)
            {
                String ConnectionString = "data source = LAPTOP-79CO0EVV\\SQLEXPRESS06;DATABASE=LibraryManagementSystem;Integrated Security = True";
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                String query = "select * from newStudent where enroll LIKE '" + StudentSearchBox.Text + "%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                String ConnectionString = "data source = LAPTOP-79CO0EVV\\SQLEXPRESS06;DATABASE=LibraryManagementSystem;Integrated Security = True";
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                String query = "select * from newStudent";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                String studname = StudName.Text;
                String enroll = Enroll.Text;
                String dept = Dept.Text;
                String sem = Sem.Text;
                String contact = Contact.Text;

                String ConnectionString = "data source = LAPTOP-79CO0EVV\\SQLEXPRESS06;DATABASE=LibraryManagementSystem;Integrated Security = True";
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                String query = "update newStudent set sname='" + studname + "', enroll='" + enroll + "', dep='" + dept + "', sem='" + sem + "', contact='" + contact + "' where stuid='" + rowId + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                studid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            String ConnectionString = "data source = LAPTOP-79CO0EVV\\SQLEXPRESS06;DATABASE=LibraryManagementSystem;Integrated Security = True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "select * from newStudent where stuid=" + studid + "";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            rowId = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            StudName.Text = ds.Tables[0].Rows[0][1].ToString();
            Enroll.Text = ds.Tables[0].Rows[0][2].ToString();
            Dept.Text = ds.Tables[0].Rows[0][3].ToString();
            Sem.Text = ds.Tables[0].Rows[0][4].ToString();
            Contact.Text = ds.Tables[0].Rows[0][5].ToString();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            StudentSearchBox.Clear();
            panel2.Visible = false;
        }
    }
}