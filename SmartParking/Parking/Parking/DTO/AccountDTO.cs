using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.DTO
{

    public class AccountDTO
    {
        private string username;
        private string password;
        private string type;

        private string fullname;


        public AccountDTO(string username, string password, string type, string fullname)
        {
            this.username = username;
            this.password = password;
            this.type = type;
            this.fullname = fullname;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Type { get => type; set => type = value; }
        public string Fullname { get => fullname; set => fullname = value; }

        public AccountDTO(DataRow row)
        {
            this.Username = row["Username"].ToString();
            this.Password = row["Password"].ToString();
            this.Type = row["Type"].ToString();
            this.Fullname = row["Fullname"].ToString();

        }
    }
}
