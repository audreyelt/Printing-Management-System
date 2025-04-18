using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FINAL_OOP
{
    public partial class worker2 : Form
    {
        public worker2(Request req)
        {
            InitializeComponent();
            label3.Text = req.RequestID.ToString();
        }
        class DB
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-P2A38ND8;Initial Catalog=PrintingSystem;Integrated Security=True");

            public void OpenConnection()
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
            }
            public void CloseConnection()
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            public SqlConnection GetConnection()
            {
                return connection;
            }
        }
        private void worker2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (statuscombobox.SelectedIndex != -1)
            {
                string status = "";
                if (statuscombobox.SelectedIndex == 0)
                {
                    status = "Work in Progress";
                }
                else if (statuscombobox.SelectedIndex == 1)
                {
                    status = "Completed";
                }

                // Use parameterized queries to prevent SQL injection
                string query = "UPDATE itemrequests SET RequestStatus = @status WHERE RequestID = @requestID";
                DB db = new DB();
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());

                // Add parameters with values
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@requestID", label3.Text);

                db.OpenConnection();
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                MessageBox.Show("Request Updated");
            }
            else
            {
                MessageBox.Show("Please select the status from the list box");
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void statuscombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
