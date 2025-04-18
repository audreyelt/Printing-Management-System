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
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-P2A38ND8;Initial Catalog=PrintingSystem;Integrated Security=True"); // Get connection string from a secure location
            conn.Open();

            string username = LoginForm.Username; // Assuming Username is retrieved securely

            SqlCommand ih = new SqlCommand("SELECT [UserRole],[UserName],[HomeAddress],[Phone] FROM [UserProfile] Where [UserName] = @Username", conn);
            ih.Parameters.AddWithValue("@Username", username);
          


            using (SqlDataReader reader = ih.ExecuteReader())
            {
                if (reader.Read())
                {
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

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if (RegRBtn.Checked == true)
            {
        
                RegisterNewUser form1 = new RegisterNewUser();
                form1.ShowDialog();
            }
            else if (UpdateRBtn.Checked)
            {

                SelectUserToUpdate uf = new SelectUserToUpdate();
                uf.ShowDialog();
            }

            else if (YearlyRBtn.Checked == true)
            {
               
                YearlyReport form3 = new YearlyReport();
                form3.ShowDialog();
            }
            else if (ServiceRBtn.Checked == true)
            {
               
                ServiceReportt form4 = new ServiceReportt();
                form4.ShowDialog();
            }
            else if (CustomerRBtn.Checked == true)
            {
               
                CustomerReport form5 = new CustomerReport();
                form5.ShowDialog();
            }
            else
            {
                MessageBox.Show("Choose An Option");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
