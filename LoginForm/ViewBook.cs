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

namespace LoginForm
{
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                String bname = Bname.Text;
                String bauthor = Bauthor.Text;
                String bpubl = Bpublication.Text;
                String bdate = dateTimePicker1.Text;
                int bprice = Convert.ToInt32(Bprice.Text);
                int bquant = Convert.ToInt32(Bquantity.Text);

                String ConnectionString = "data source = LAPTOP-79CO0EVV\\SQLEXPRESS06;DATABASE=LibraryManagementSystem;Integrated Security = True";
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                String query = "update newBook set bname='" + bname + "', bauthor='" + bauthor + "', bpubl='" + bpubl + "', bdate='" + bdate + "', bprice='" + bprice + "', bquant='" + bquant + "' where id='" + rowId + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            String ConnectionString = "data source = LAPTOP-79CO0EVV\\SQLEXPRESS06;DATABASE=LibraryManagementSystem;Integrated Security = True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "select * from newBook";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int bid;
        int rowId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            String ConnectionString = "data source = LAPTOP-79CO0EVV\\SQLEXPRESS06;DATABASE=LibraryManagementSystem;Integrated Security = True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "select * from newBook where id=" + bid + "";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            rowId = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            Bname.Text = ds.Tables[0].Rows[0][1].ToString();
            Bauthor.Text = ds.Tables[0].Rows[0][2].ToString();
            Bpublication.Text = ds.Tables[0].Rows[0][3].ToString();
            dateTimePicker1.Text = ds.Tables[0].Rows[0][4].ToString();
            Bprice.Text = ds.Tables[0].Rows[0][5].ToString();
            Bquantity.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void Bname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            SearchBox.Clear();
            panel2.Visible = false;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                String ConnectionString = "data source = LAPTOP-79CO0EVV\\SQLEXPRESS06;DATABASE=LibraryManagementSystem;Integrated Security = True";
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                String query = "delete from newBook where id=" + rowId + "";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text != null)
            {
                String ConnectionString = "data source = LAPTOP-79CO0EVV\\SQLEXPRESS06;DATABASE=LibraryManagementSystem;Integrated Security = True";
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                String query = "select * from newBook where bname LIKE '" + SearchBox.Text + "%'";
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
                String query = "select * from newBook";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
