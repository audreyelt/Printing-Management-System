using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_OOP
{
    public partial class Pay : Form
    {
        public Pay(Request req)
        {
            InitializeComponent();
            requestid.Text = req.RequestID.ToString();
            
        }

        private void paybtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P2A38ND8;Initial Catalog=PrintingSystem;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE itemrequests SET [PaymentStatus] = @Status  WHERE RequestID = @RequestID ", con);
            cmd.Parameters.AddWithValue("@Status", "Paid");
            cmd.Parameters.AddWithValue("@RequestID",requestid.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("You have make an Payment");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
