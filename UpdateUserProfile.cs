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
    public partial class UpdateUserProfile : Form
    {
        UserProfile profile;
        public UpdateUserProfile(UserProfile ud)
        {
            InitializeComponent();
            profile = ud;

            labeluserID.Text = ud.UserID.ToString();
            usernamecb.Text = ud.UserName.ToString();
            passwordtextbox.Text = ud.UserPassword.ToString();
            rolelabel.Text = ud.UserRole.ToString();
            pnumtextbox.Text = ud.Phone.ToString();
            addresstextbox.Text = ud.HomeAddress.ToString();
            
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-P2A38ND8;Initial Catalog=PrintingSystem;Integrated Security=True");
            using (SqlCommand cmd = new SqlCommand("UPDATE UserProfile SET [UserName] = @Username, [UserPassword] = @UserPassword, [UserRole] = @UserRole, [Phone] = @Phone, [HomeAddress] = @HomeAddress" + " where [UserID] = @UserID ", con1))
            {
                profile.UserName = usernamecb.Text;
                profile.UserPassword = passwordtextbox.Text;
                profile.HomeAddress = addresstextbox.Text;
                profile.Phone = pnumtextbox.Text;


                cmd.Parameters.AddWithValue("@UserID", profile.UserID);
                cmd.Parameters.AddWithValue("@UserName", profile.UserName);
                cmd.Parameters.AddWithValue("@UserPassword", profile.UserPassword);
                cmd.Parameters.AddWithValue("@UserRole", profile.UserRole);
                cmd.Parameters.AddWithValue("@Phone", profile.Phone);
                cmd.Parameters.AddWithValue("@HomeAddress", profile.HomeAddress);
                con1.Open();
                cmd.ExecuteNonQuery();
                con1.Close();

                MessageBox.Show("User Profile Updated!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
