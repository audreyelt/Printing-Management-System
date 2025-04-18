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
    public partial class SelectUserToUpdate : Form
    {
        public SelectUserToUpdate()
        {
            InitializeComponent();
        }

        private void SelectUserToUpdate_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'printingSystemDataSet.UserProfile' table. You can move, or remove it, as needed.
            this.userProfileTableAdapter.Fill(this.printingSystemDataSet.UserProfile);
           

        }

       

        /* private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
         {
             DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

             string username = dataGridView1.Rows[0]; 
             using (SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-P2A38ND8;Initial Catalog=IOOP_Assignment_GROUP24;Integrated Security=True"))
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

                     UserProfile ud = new UserProfile(id, name, password, role, phone, homeadd);
                     UpdateUserProfile uda = new UpdateUserProfile(ud);
                     uda.ShowDialog();
                     con1.Close();

                 }
             }

         }*/
        

        private void dataGridView1_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Ensure the clicked row index is valid
            if (e.RowIndex >= 0)
            {
                // Get the DataGridViewRow at the specified index
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Extract the username from the specific cell
                // Assuming the username is in the first cell (index 0)
                string username = row.Cells[3].Value.ToString();

                // Use the extracted username in your SQL query
                using (SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-P2A38ND8;Initial Catalog=PrintingSystem;Integrated Security=True"))
                {
                    con1.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT UserID, UserName, UserPassword, UserRole, Phone, HomeAddress FROM [UserProfile] WHERE UserName = @UserName", con1))
                    {
                        cmd.Parameters.AddWithValue("@UserName", username);

                        SqlDataAdapter sda = new SqlDataAdapter(cmd);

                        DataTable dt = new DataTable("UserProfile");
                        sda.Fill(dt);

                        // Ensure the DataTable contains rows
                        if (dt.Rows.Count > 0)
                        {
                            int id = dt.Rows[0].Field<int>("UserID");
                            string name = dt.Rows[0].Field<string>("UserName");
                            string password = dt.Rows[0].Field<string>("UserPassword");
                            string role = dt.Rows[0].Field<string>("UserRole");
                            string phone = dt.Rows[0].Field<string>("Phone");
                            string homeadd = dt.Rows[0].Field<string>("HomeAddress");

                            UserProfile ud = new UserProfile(id, name, password, role, phone, homeadd);
                            UpdateUserProfile uda = new UpdateUserProfile(ud);
                            uda.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("No user found with the specified username.");
                        }

                        con1.Close();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
