using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FINAL_OOP
{
    public partial class RegisterNewUser : Form
    {
        private List<string> userrole = new List<string> { "Admin", "Manager", "Worker", "Customer" };

        public RegisterNewUser()
        {
            InitializeComponent();
        }
        public string Username
        {
            get { return usernametextbox.Text; }
        }
        public string Password
        {
            get { return passwordtextbox.Text; }
        }
        public string Role
        {
            get { return rolecombobox.Text; }
        }
        public string Address
        {
            get { return addresstextbox.Text; }
        }
        public int PhoneNumber
        {
            get { return int.Parse(pnumtextbox.Text); }
        }
        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (rolecombobox.Text == "Please Select A Role")
            {
                MessageBox.Show("Please Select A Role");
            }
            else
            {
                SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-P2A38ND8;Initial Catalog=PrintingSystem;Integrated Security=True");
                try
                {
                    con1.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[UserProfile] ([UserName], [UserPassword], [UserRole], [Phone], [HomeAddress]) VALUES (@UserName, @UserPassword, @UserRole, @Phone, @HomeAddress)", con1))
                    {
                        cmd.Parameters.AddWithValue("@UserName", Username);
                        cmd.Parameters.AddWithValue("@UserPassword", Password);
                        cmd.Parameters.AddWithValue("@UserRole", Role);
                        cmd.Parameters.AddWithValue("@Phone", PhoneNumber);
                        cmd.Parameters.AddWithValue("@HomeAddress", Address);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("New User Registered!");
                    DialogResult = DialogResult.OK;
                    this.Close();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    if (con1.State == System.Data.ConnectionState.Open)
                    {
                        con1.Close();
                    }

                }
            }
        }

        private void RegisterNewUser_Load(object sender, EventArgs e)
        {
            rolecombobox.Items.Clear();
            rolecombobox.DataSource = userrole;
            rolecombobox.Text = "Please Select A Role";
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
