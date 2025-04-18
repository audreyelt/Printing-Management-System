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

namespace FINAL_OOP
{
    public partial class worker : Form
    {
        public worker()
        {
            InitializeComponent();
            /*SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-P2A38ND8;Initial Catalog=PrintingSystem;Integrated Security=True");
            conn.Open();
            SqlCommand ih = new SqlCommand("SELECT [UserID] FROM [UserProfile] Where [UserName] = @Username", conn);
            ih.Parameters.AddWithValue("@Username", LoginForm.Username);
            MessageBox.Show(ih.ToString());
            ih.ExecuteNonQuery();
            conn.Close();
            
            worker_id.Text = ih.ToString();*/
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-P2A38ND8;Initial Catalog=PrintingSystem;Integrated Security=True"); // Get connection string from a secure location
            conn.Open();

            string username = LoginForm.Username; // Assuming Username is retrieved securely

            SqlCommand ih = new SqlCommand("SELECT [UserID],[UserRole],[UserName],[HomeAddress],[Phone] FROM [UserProfile] Where [UserName] = @Username", conn);
            ih.Parameters.AddWithValue("@Username", username);

            using (SqlDataReader reader = ih.ExecuteReader())
            {
                if (reader.Read())
                {
                    worker_id.Text = reader["UserID"].ToString(); // Access data by column name
                    lblrl.Text = reader["UserRole"].ToString(); // Access data by column name
                    lbladd.Text = reader["HomeAddress"].ToString(); // Access data by column name
                    lblpn.Text = reader["Phone"].ToString(); // Access data by column name
                }
                else
                {
                    // Handle case where username not found
                    MessageBox.Show("Username not found!");
                }
            }

            conn.Close();
            lbluser.Text = LoginForm.Username.ToString();

        }



        private void worker_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printingSystemDataSet1.CustReq' table. You can move, or remove it, as needed.
            this.custReqTableAdapter1.Fill(this.printingSystemDataSet1.CustReq);

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-P2A38ND8;Initial Catalog=PrintingSystem;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT [RequestID],[RequestDateTime],[Customer_UserName],[itemRequestID],[ServiceNo],[QuantityOrdered]," +
                "[UrgentRequest],[Cost],[RequestStatus],[PaymentStatus],[Worker_UserID] FROM [PrintingSystem].[dbo].[CustReq] where [Worker_UserID] = @ID ", conn);
            cmd.Parameters.AddWithValue("@ID",worker_id.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable("Requests");
            sda.Fill(dt);

            dataGridView1.DataSource = dt;
            conn.Close();

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-P2A38ND8;Initial Catalog=PrintingSystem;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT [RequestID],[RequestDateTime],[Customer_UserName],[itemRequestID],[ServiceNo],[QuantityOrdered]," +
                "[UrgentRequest],[Cost],[RequestStatus],[PaymentStatus],[Worker_UserID] FROM [PrintingSystem].[dbo].[CustReq] where [Worker_UserID] = @ID ", conn);
            cmd.Parameters.AddWithValue("@ID", worker_id.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable("Requests");
            sda.Fill(dt);

            dataGridView1.DataSource = dt; dataGridView1.Refresh();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            int requestid = int.Parse(row.Cells[0].Value.ToString());
            //MessageBox.Show(requestid.ToString());

            //AssignWorkerForm awf = new AssignWorkerForm(Request);
            //awf.ShowDialog();

            Request req = new Request(requestid);

            worker2 awf = new worker2(req);
            awf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = LoginForm.Username;
            using (SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-P2A38ND8;Initial Catalog=PrintingSystem;Integrated Security=True"))
            {
                con1.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT UserID, UserName, UserPassword, UserRole, Phone, HomeAddress FROM [UserProfile] WHERE UserName = @UserName", con1))
                {
                    cmd.Parameters.AddWithValue("@UserName", username);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable("UserProfile");
                    sda.Fill(dt);

                    int id = dt.Rows[0].Field<int>("UserID");
                    string name = dt.Rows[0].Field<string>("UserName");
                    string password = dt.Rows[0].Field<string>("UserPassword");
                    string role = dt.Rows[0].Field<string>("UserRole");
                    string v = dt.Rows[0].Field<string>("Phone");
                    string phone = v;
                    string homeadd = dt.Rows[0].Field<string>("HomeAddress");

                    UserProfile ad = new UserProfile(id, name, password, role, phone, homeadd);
                    UpdateCustomerProfile uda = new UpdateCustomerProfile(ad);
                    uda.ShowDialog();
                    con1.Close();

                }
            }
        }
    }
}
