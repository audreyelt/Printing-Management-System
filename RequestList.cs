using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_OOP
{
    public partial class RequestList : Form
    {
        public RequestList()
        {
            InitializeComponent();
        }

        private void RequestList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printingSystemDataSet.CustReq' table. You can move, or remove it, as needed.
            this.custReqTableAdapter.Fill(this.printingSystemDataSet.CustReq);
            // TODO: This line of code loads data into the 'iOOP_Assignment_GROUP24DataSet1.CustomerRequests' table. You can move, or remove it, as needed.

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
