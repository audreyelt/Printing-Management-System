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
    public partial class MakePayment : Form
    {
        public MakePayment()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-P2A38ND8;Initial Catalog=PrintingSystem;Integrated Security=True"); // Get connection string from a secure location
            conn.Open();

            string username = LoginForm.Username; // Assuming Username is retrieved securely

            SqlCommand ih = new SqlCommand("SELECT [Customer_Username] FROM [CustReq] Where [Customer_Username] = @Username", conn);
            ih.Parameters.AddWithValue("@Username", username);

            using (SqlDataReader reader = ih.ExecuteReader())
            {
                if (reader.Read())
                {
                    custname.Text = reader["Customer_Username"].ToString(); // Access data by column name
                }
                else
                {
                    // Handle case where username not found
                    MessageBox.Show("Username not found!");
                }
            }

            conn.Close();

        }

        private void MakePayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printingSystemDataSet2.CustReq' table. You can move, or remove it, as needed.
            this.custReqTableAdapter.Fill(this.printingSystemDataSet2.CustReq);
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-P2A38ND8;Initial Catalog=PrintingSystem;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT [RequestID],[RequestDateTime],[Customer_UserName],[itemRequestID],[ServiceNo],[QuantityOrdered]," +
                "[UrgentRequest],[Cost],[RequestStatus],[PaymentStatus],[Worker_UserID] FROM [PrintingSystem].[dbo].[CustReq] where [Customer_UserName] = @Name ", conn);
            cmd.Parameters.AddWithValue("@Name", custname.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable("Requests");
            sda.Fill(dt);

            dataGridView1.DataSource = dt;
            conn.Close();

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            int requestid = int.Parse(row.Cells[0].Value.ToString());
            //MessageBox.Show(requestid.ToString());

            //AssignWorkerForm awf = new AssignWorkerForm(Request);
            //awf.ShowDialog();

            Request req = new Request(requestid);

            Pay awf = new Pay(req);
            awf.ShowDialog();

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-P2A38ND8;Initial Catalog=PrintingSystem;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT [RequestID],[RequestDateTime],[Customer_UserName],[itemRequestID],[ServiceNo],[QuantityOrdered]," +
                "[UrgentRequest],[Cost],[RequestStatus],[PaymentStatus],[Worker_UserID] FROM [PrintingSystem].[dbo].[CustReq] where [Customer_UserName] = @Name ", conn);
            cmd.Parameters.AddWithValue("@Name", custname.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable("Requests");
            sda.Fill(dt);

            dataGridView1.DataSource = dt; dataGridView1.Refresh();
        }

        

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
