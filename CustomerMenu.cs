using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FINAL_OOP
{
    public partial class CustomerMenu : Form
    {
        DataTable table = new DataTable("table");
        private List<CustomerRequest> currentServices = new List<CustomerRequest>(); // List to store selected services



        public CustomerMenu()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-P2A38ND8;Initial Catalog=PrintingSystem;Integrated Security=True"); // Get connection string from a secure location
            conn.Open();

            string username = LoginForm.Username; // Assuming Username is retrieved securely

            SqlCommand ih = new SqlCommand("SELECT [UserRole],[UserName],[HomeAddress],[Phone] FROM [UserProfile] Where [UserName] = @Username", conn);
            ih.Parameters.AddWithValue("@Username", username);



            using (SqlDataReader reader = ih.ExecuteReader())
            {
                if (reader.Read())
                {
                    lblrl.Text = reader["UserRole"].ToString(); // Access data by column name
                    lbladd.Text = reader["HomeAddress"].ToString(); // Access data by column name
                    lblpn.Text = reader["Phone"].ToString(); // Access data by column name
                }
                else
                {
                    // Handle case where username not found
                    MessageBox.Show("Username not found!");
                }
            }

            conn.Close();
            lbluser.Text = LoginForm.Username.ToString();


        }


        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            double totalCost;
            double ServiceCost = 0;
            int Pages;
            double Subcharged = 1;
            double AfterDiscount = 1;

            if (servicetypebox.SelectedItem.ToString() == "Printing A4 - Black and White")
            {
                ServiceCost = 0.8;
                if (int.Parse(pagesbox.Text) > 100)
                {
                    AfterDiscount = 0.9;
                }
            }
            else if (servicetypebox.SelectedItem.ToString() == "Printing A4 - Color")
            {
                ServiceCost = 2.50;
                if (int.Parse(pagesbox.Text) > 100)
                {
                    AfterDiscount = 0.9;
                }
            }
            else if (servicetypebox.SelectedItem.ToString() == "Binding - Comb Bining")
            {
                ServiceCost = 5.50;
            }
            else if (servicetypebox.SelectedItem.ToString() == "Binding - Thick Cover")
            {
                ServiceCost = 9.30;
            }
            else if (servicetypebox.SelectedItem.ToString() == "Printing - Poster (A0)")
            {
                ServiceCost = 6.0;
                if (int.Parse(pagesbox.Text) > 100)
                {
                    AfterDiscount = 0.9;
                }
            }
            else if (servicetypebox.SelectedItem.ToString() == "Printing - Poster (A1)")
            {
                ServiceCost = 6.0;
                if (int.Parse(pagesbox.Text) > 100)
                {
                    AfterDiscount = 0.9;
                }
            }
            else if (servicetypebox.SelectedItem.ToString() == "Printing - Poster (A2)")
            {
                ServiceCost = 3.0;
                if (int.Parse(pagesbox.Text) > 100)
                {
                    AfterDiscount = 0.9;
                }
            }
            else if (servicetypebox.SelectedItem.ToString() == "Printing - Poster (A3)")
            {
                ServiceCost = 3.0;
                if (int.Parse(pagesbox.Text) > 100)
                {
                    AfterDiscount = 0.9;
                }
            }

            if (checkBox1.Checked)
            {
                Subcharged = 1.3;
            }

            Pages = int.Parse(pagesbox.Text);
            totalCost = ServiceCost * Pages * Subcharged * AfterDiscount;
            labelcost.Text = totalCost.ToString();
            ConfirmRequestBtn.Visible = true;
        }

        private void ConfirmRequestBtn_Click(object sender, EventArgs e)
        {



            SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-P2A38ND8;Initial Catalog=PrintingSystem;Integrated Security=True");


            string query1 = "Insert into CustomerRequest (Customer_Username) values (@Customer_Username)";
            SqlCommand cmd = new SqlCommand(query1, con1);

            cmd.Parameters.AddWithValue("@Customer_Username", LoginForm.Username);

            // Execute the query (OUTPUT inserted doesn't return rows)
            con1.Open();
            cmd.ExecuteNonQuery();


            // Retrieve the inserted RequestID from the output parameter
            string selectid = "select top 1[RequestID] from[CustomerRequest] order by[RequestID] desc";
            SqlCommand command = new SqlCommand(selectid, con1);
            // Execute the query and get the first (and only) result
            object result = command.ExecuteScalar();

            if (result != null)
            {
                int latestRequestID = (int)result; // Cast to int as RequestID is likely an integer
                MessageBox.Show($"Latest RequestID: {latestRequestID}"); // Display the ID


                foreach (CustomerRequest serviceRequest in currentServices)
                {

                    // Insert into ItemRequest using the retrieved RequestID
                    string query2 = "INSERT INTO itemrequests (RequestID, ServiceNo, QuantityOrdered, UrgentRequest, Cost, RequestStatus, PaymentStatus ) VALUES (@RequestID, @ServiceNo, @QuantityOrdered, @UrgentRequest, @Cost, @Status,@Payment)";
                    SqlCommand cmd2 = new SqlCommand(query2, con1);


                    // Set parameters for ItemRequest
                    cmd2.Parameters.AddWithValue("@RequestID", latestRequestID);
                    cmd2.Parameters.AddWithValue("@ServiceNo", serviceRequest.ServiceNo);
                    cmd2.Parameters.AddWithValue("@QuantityOrdered", serviceRequest.QuantityOrdered);
                    cmd2.Parameters.AddWithValue("@UrgentRequest", serviceRequest.UrgentRequest ? 1 : 0); // Convert bool to int for database
                    cmd2.Parameters.AddWithValue("@Cost", serviceRequest.Cost);
                    cmd2.Parameters.AddWithValue("@Status", "NEW");
                    cmd2.Parameters.AddWithValue("@Payment", "Not Paid");

                    // Execute the query for ItemRequest
                    cmd2.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("No records found in CustomerRequests table.");
            }

            con1.Close();

            MessageBox.Show("Requests submitted successfully!");
            Payment form = new Payment(currentServices);
            form.UpdateCart(currentServices); // Pass the currentServices list
            form.ShowDialog();


        }
        /*private void SubmitServiceRequest(CustomerRequest service)
        {

            // Connect to database and prepare SQL statement
            SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-P2A38ND8;Initial Catalog=IOOP_Assignment_GROUP24;Integrated Security=True");
            string query = "Insert into CustomerRequests (Customer_Username, ServiceNo, QuantityOrdered, UrgentRequest, Cost) values (@Customer_Username, @ServiceNo, @QuantityOrdered, @UrgentRequest, @Cost)"; // Modify as needed for additional service details
            SqlCommand cmd = new SqlCommand(query, con1);

            // Set request parameters
            cmd.Parameters.AddWithValue("@Customer_Username", service.CustomerUsername);
            cmd.Parameters.AddWithValue("@ServiceNo", service.ServiceNo);
            cmd.Parameters.AddWithValue("@QuantityOrdered", service.QuantityOrdered);
            cmd.Parameters.AddWithValue("@UrgentRequest", service.UrgentRequest ? 1 : 0); // Convert bool to int for database
            cmd.Parameters.AddWithValue("@Cost", service.Cost);

            // Execute the query
            con1.Open();
            cmd.ExecuteNonQuery();
            con1.Close();
        }*/

        private void UpdateUserProfileBtn_Click(object sender, EventArgs e)
        {
            string username = LoginForm.Username; // Make sure LoginForm.Username is properly initialized
            using (SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-P2A38ND8;Initial Catalog=PrintingSystem;Integrated Security=True"))
            {
                con1.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT UserID, UserName, UserPassword, UserRole, Phone, HomeAddress FROM [UserProfile] WHERE UserName = @UserName", con1))
                {
                    cmd.Parameters.AddWithValue("@UserName", username);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable("UserProfile");
                    sda.Fill(dt);

                    int id = dt.Rows[0].Field<int>("UserID");
                    string name = dt.Rows[0].Field<string>("UserName");
                    string password = dt.Rows[0].Field<string>("UserPassword");
                    string role = dt.Rows[0].Field<string>("UserRole");
                    string v = dt.Rows[0].Field<string>("Phone");
                    string phone = v;
                    string homeadd = dt.Rows[0].Field<string>("HomeAddress");

                    UserProfile ad = new UserProfile(id, name, password, role, phone, homeadd);
                    UpdateCustomerProfile uda = new UpdateCustomerProfile(ad);
                    uda.ShowDialog();
                    con1.Close();

                }
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            // Extract and convert values from input controls (similar to previous implementation)
            string serviceType = servicetypebox.SelectedItem.ToString();
            int quantityOrdered = int.Parse(pagesbox.Text);
            bool urgentRequest = checkBox1.Checked;
            double cost = double.Parse(labelcost.Text);

            // Validate input (similar to previous implementation)
            int ServiceType = 0;
            if (servicetypebox.SelectedItem.ToString() == "Printing A4 - Black and White")
            {
                ServiceType = 1;
            }

            else if (servicetypebox.SelectedItem.ToString() == "Printing A4 - Color")
            {
                ServiceType = 2;
            }

            else if (servicetypebox.SelectedItem.ToString() == "Binding - Comb Bining")
            {
                ServiceType = 3;
            }

            else if (servicetypebox.SelectedItem.ToString() == "Binding - Thick Cover")
            {
                ServiceType = 4;
            }

            else if (servicetypebox.SelectedItem.ToString() == "Printing - Poster (A0)")
            {
                ServiceType = 5;
            }

            else if (servicetypebox.SelectedItem.ToString() == "Printing - Poster (A1)")
            {
                ServiceType = 6;
            }
            else if (servicetypebox.SelectedItem.ToString() == "Printing - Poster (A2)")
            {
                ServiceType = 7;
            }

            else if (servicetypebox.SelectedItem.ToString() == "Printing - Poster (A3)")
            {
                ServiceType = 8;
            }

            // Create a CustomerRequest object for the current service
            CustomerRequest currentService = new CustomerRequest(0, LoginForm.Username, DateTime.Now, ServiceType, quantityOrdered, urgentRequest, cost, "", "", "");
            currentService.ServiceType = serviceType; // Assuming you have a way to map service type to ServiceNo


            // Update data grid view (new)
            dataGridView1.Rows.Add(
                serviceType,
                quantityOrdered,
                urgentRequest ? 1 : 0,
                cost.ToString("C2")
            );

            // Add the service to the currentServices list
            currentServices.Add(currentService);

            MessageBox.Show("Service added to cart!");

        }
        private void CustomerMenu_Load(object sender, EventArgs e)
        {
        }

        private void ViewRequestListBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RequestList uf = new RequestList();
            uf.ShowDialog();
        }

        private void SubmitNewRequestBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerMenu gh = new CustomerMenu();
            gh.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
