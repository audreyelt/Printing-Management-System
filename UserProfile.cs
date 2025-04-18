using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_OOP
{
    public class UserProfile
    {
        private int _Userid;
        private string _UserName;
        private string _Password;
        private string _Address;
        private string _Phone;
        private string _Role;

        public UserProfile()
        {
            _Userid = 0;
            _UserName = string.Empty;
            _Password = string.Empty;
            _Address = string.Empty;
            _Phone = string.Empty;
            _Role = string.Empty;
        }
        public UserProfile(int userid, string username, string password, string role, string phone, string address)
        {
            _Userid = userid;
            _UserName = username;
            _Password = password;
            _Address = address;
            _Phone = phone;
            _Role = role;
        }
        public int UserID
        {
            get { return _Userid; }
        }

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        public string UserPassword
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public string HomeAddress
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
        public string UserRole
        {
            get { return _Role; }
            set { _Role = value; }
        }
    }
}


