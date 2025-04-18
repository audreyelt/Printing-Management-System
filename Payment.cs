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
    public partial class Payment : Form
    {
        private List<CustomerRequest> services;

        

        public Payment(List<CustomerRequest> services)
        {
            InitializeComponent();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.services = services; // Store passed services
        }
        
        public void UpdateCart(List<CustomerRequest> services)
        {
            foreach (CustomerRequest service in services)
            {
                dataGridView2.Rows.Add(
                    service.ServiceType,
                    service.QuantityOrdered,
                    service.UrgentRequest ? 1 : 2, // Convert bool to string for display (optional)
                    service.Cost.ToString() // Format cost as currency with two decimal places
                );
            }
        }
        

        private void Payment_Load_1(object sender, EventArgs e)
        {
            // Clear existing data (if needed)
            dataGridView2.Rows.Clear();

            // Add each service from the passed list to the DataGridView
            foreach (CustomerRequest service in services)
            {
                dataGridView2.Rows.Add(
                    service.ServiceType,
                    service.QuantityOrdered,
                    service.UrgentRequest ? 1 : 2, // Convert bool to string for display (optional)
                    service.Cost.ToString() // Format cost as currency with two decimal places
                );
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double sum = 0; //Double, because we are dealing with money, which is a decimal

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value); //This takes the value of your selected cell within your ingredients datagrid (they need to be only numbers, no letters since we're converting to a double)
            }
            totalprice.Text = sum.ToString(); // Format total price as currency with two decimal places
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            /*SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-P2A38ND8;Initial Catalog=PrintingSystem;Integrated Security=True");
            using (SqlCommand cmd = new SqlCommand("UPDATE itemrequests SET [PaymentStatus] = @Paymentstatus " + " where [RequestID] = @RequestID ", con1))
            {
                cmd.Parameters.AddWithValue("@RequestID", LoginForm.Username);
                cmd.Parameters.AddWithValue("@Paymentstatus", "Paid");
                con1.Open();
                cmd.ExecuteNonQuery();
                con1.Close();
                MessageBox.Show("You Have Successfully made a Payment!");
            }*/
            this.Close();
            MakePayment uf = new MakePayment();
            uf.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
