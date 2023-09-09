using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Al_Masaa_Cafe.BL
{
    public class MuserBL
    {
        private string username;
        private string password;
        private string role;

       
        public MuserBL(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public MuserBL(string username,string password)
        {
            this.username = username;
            this.password = password;
            this.role = "NA";
        }
        public string Username
        {
            set => username = value;
            get => username;
        }
        public string Pwd
        {
            set => password = value;
            get => password;
        }
        public string Role
        {
            set => role = value;
            get => role;
        }
    }
}
