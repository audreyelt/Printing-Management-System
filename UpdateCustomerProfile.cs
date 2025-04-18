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
    public partial class UpdateCustomerProfile : Form
    {
        UserProfile profile;
        public UpdateCustomerProfile(UserProfile ad)
        {
            InitializeComponent();
            profile = ad;

            labeluserID.Text = ad.UserID.ToString();
            usernamecb.Text = ad.UserName.ToString();
            passwordtextbox.Text = ad.UserPassword.ToString();
            rolelabel.Text = ad.UserRole.ToString();
            pnumtextbox.Text = ad.Phone.ToString();
            addresstextbox.Text = ad.HomeAddress.ToString();

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

       

        private void labeluserID_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
