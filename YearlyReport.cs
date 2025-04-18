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
    public partial class YearlyReport : Form
    {
        public YearlyReport()
        {
            InitializeComponent();
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-P2A38ND8;Initial Catalog=PrintingSystem;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Year], [Month], Total FROM [YearlyReportView] Where [Year] = @Year", conn);
            cmd.Parameters.AddWithValue("@Year", comboBox1.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable("YearlyReport");
            sda.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void YearlyReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printingSystemDataSet2.YearlyReportView' table. You can move, or remove it, as needed.
            this.yearlyReportViewTableAdapter.Fill(this.printingSystemDataSet2.YearlyReportView);
            // TODO: This line of code loads data into the 'printingSystemDataSet.YearlyReport' table. You can move, or remove it, as needed.

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
