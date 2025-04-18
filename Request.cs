using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_OOP
{
    public class Request
    {
        private int _ReqID;
        private string _WorkerID;

        public Request() 
        { 
            _ReqID = 0;
            _WorkerID = string.Empty;
        }

        public Request(int reqid)
        {
            _ReqID = reqid;
            
        }

        public int RequestID 
        { //read only since Request ID is autoamatically generated in SQL
            get { return _ReqID; }
        }

        public string WorkerID
        {
            get { return _WorkerID; }
            set { _WorkerID = value; }
        }
    }

}
