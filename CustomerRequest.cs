using System;

namespace FINAL_OOP
{
    public class CustomerRequest
    {
        private int v1;
        private string username;
        private DateTime now;
        private string v2;
        private string v3;
        private string v4;

        public int RequestID { get; }
        public string CustomerUsername { get; set; }
        public DateTime RequestDateTime { get; set; }
        public int ServiceNo { get; set; }
        public int QuantityOrdered { get; set; }
        public bool UrgentRequest { get; set; }
        public double Cost { get; set; }
        public string RequestStatus { get; set; }
        public string PaymentStatus { get; set; }
        public string WorkerUserID { get; set; }
        public string ServiceType { get; internal set; }

        public CustomerRequest(int requestID, string username, DateTime requestDateTime, int serviceNo, int quantityOrdered, bool urgentRequest, double cost, string requestStatus, string paymentStatus, string workerUserID)
        {
            RequestID = requestID;
            CustomerUsername = username;
            RequestDateTime = requestDateTime;
            ServiceNo = serviceNo;
            QuantityOrdered = quantityOrdered;
            UrgentRequest = urgentRequest;
            Cost = cost;
            RequestStatus = requestStatus;
            PaymentStatus = paymentStatus;
            WorkerUserID = workerUserID;
        }

        public CustomerRequest(int v1, string username, DateTime now, string serviceType, int quantityOrdered, bool urgentRequest, double cost, string v2, string v3, string v4)
        {
            this.v1 = v1;
            this.username = username;
            this.now = now;
            ServiceType = serviceType;
            QuantityOrdered = quantityOrdered;
            UrgentRequest = urgentRequest;
            Cost = cost;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        public override string ToString()
        {
            return $"RequestID: {RequestID}, Customer: {CustomerUsername}, Service: {ServiceNo}, Quantity: {QuantityOrdered}";
        }
    }
}
    