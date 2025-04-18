using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FINAL_OOP
{
    public partial class ServiceReport : Form
    {
        public ServiceReport()
        {
            InitializeComponent();
        }

        private void ServiceReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printingSystemDataSet4.ViewServiceReport' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'printingSystemDataSet2.ServiceReportView' table. You can move, or remove it, as needed.
            this.serviceReportViewTableAdapter.Fill(this.printingSystemDataSet2.ServiceReportView);

        }

        private void GenerateReportBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-P2A38ND8;Initial Catalog=PrintingSystem;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT [ServiceType],[Year],[Month],[Total] FROM [ServiceReportView] Where [ServiceType] = @ServiceType and [Year] = @Year and [Month] = @Month", conn);
            cmd.Parameters.AddWithValue("@Year", yearcomboboc.Text);
            cmd.Parameters.AddWithValue("@Month", monthcombobox.Text);
            cmd.Parameters.AddWithValue("@ServiceType", servicecombobox.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable("ServiceReport");
            sda.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
