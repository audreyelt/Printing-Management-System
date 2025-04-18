using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FINAL_OOP
{
    public partial class LoginForm : Form
    {
        public static string Username;
        public static string Password;

        public LoginForm()
        {
            InitializeComponent();
            textPassword.PasswordChar = '*'; // Set the PasswordChar property here
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            string username = textName.Text;
            string password = textPassword.Text;

            Username = username;
            Password = password;

            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Please enter a valid username and/or password.");
                return;
            }

            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P2A38ND8;Initial Catalog=PrintingSystem;Integrated Security=True"))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT UserRole FROM [UserProfile] Where [UserName] = @UserName and [UserPassword]=@Pwd", con))
                    {
                        cmd.Parameters.AddWithValue("@UserName", Username);
                        cmd.Parameters.AddWithValue("@Pwd", Password);

                        object result = cmd.ExecuteScalar();
                        string role = result != null ? result.ToString() : null;

                        if (!string.IsNullOrEmpty(role))
                        {
                            if (role == "Admin")
                            {
                                // Show admin menu form
                                AdminMenuForm clf = new AdminMenuForm();
                                clf.ShowDialog();
                            }
                            else if (role == "Customer")
                            {
                                // Show customer menu form
                                CustomerMenu OP = new CustomerMenu();
                                OP.ShowDialog();
                            }
                            else if (role == "Manager")
                            {
                                // Show manager menu form
                                ManagerMenu OP = new ManagerMenu();
                                OP.ShowDialog();
                            }
                            else if (role == "Worker")
                            {
                                // Show worker menu form
                                
                                worker OP = new worker();
                                OP.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Invalid UserName and/or password entered");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username and/or password entered !!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
