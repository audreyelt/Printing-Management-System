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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FINAL_OOP
{
    public partial class AssignWorkerForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P2A38ND8;Initial Catalog=PrintingSystem;Integrated Security=True");
        public AssignWorkerForm(Request req)
        {
            InitializeComponent();
            lblRequestID.Text = req.RequestID.ToString();
            cbWorkerID.Text = req.WorkerID;
        }

        private void AssignWorkerForm_Load(object sender, EventArgs e)
        {
            FillBox();
        }
        public void FillBox()
        {
            //cbWorkerID.Items.Clear();
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select [UserID] from UserProfile where [UserRole] = @Role;", con);
                cmd.Parameters.AddWithValue("@Role", "Worker");
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("UserID", typeof(string));
                dt.Load(reader);
                cbWorkerID.ValueMember = "UserID";
                cbWorkerID.DataSource = dt;

                con.Close();
            }
            catch (Exception)
            {

            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(cbWorkerID.Text);
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-P2A38ND8;Initial Catalog=PrintingSystem;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE itemrequests SET [Worker_UserID] = @WorkerID, [RequestStatus] = @Status  WHERE RequestID = @RequestID ", con);
                cmd.Parameters.AddWithValue("@WorkerID", cbWorkerID.Text);
                cmd.Parameters.AddWithValue("@RequestID", lblRequestID.Text);
                cmd.Parameters.AddWithValue("@Status", "Assigned");
                cmd.ExecuteNonQuery();

                //MessageBox.Show(_requestid.ToString());
                //MessageBox.Show(cmd.CommandText);

                con.Close();
            }
            catch (Exception E)
            {
                //MessageBox.Show(E.Message);
            }
            MessageBox.Show("New Worker Assigned!");
        }

       

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
