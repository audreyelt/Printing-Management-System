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
    public partial class CustomerReport : Form
    {
        public CustomerReport()
        {
            InitializeComponent();
        }

        private void CustomerReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printingSystemDataSet2.CustomerReportView' table. You can move, or remove it, as needed.
            this.customerReportViewTableAdapter.Fill(this.printingSystemDataSet2.CustomerReportView);
            // TODO: This line of code loads data into the 'printingSystemDataSet.CustomerReport' table. You can move, or remove it, as needed.
            

        }

        private void GenerateReportBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-P2A38ND8;Initial Catalog=PrintingSystem;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Customer_Username],[ServiceType],[Year],[Month],[Total] FROM [CustomerReportView] Where [Customer_Username]= @Customer and [Month] = @Month", conn);
            cmd.Parameters.AddWithValue("@Customer", usernametxtbox.Text);
            cmd.Parameters.AddWithValue("@Month", monthcombobox.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable("ServiceReport");
            sda.Fill(dt);

            dataGridView1.DataSource = dt;
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
