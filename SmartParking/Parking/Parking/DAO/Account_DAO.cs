using Parking.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Parking.DAL
{
    public class Account_DAO
    {
        private static Account_DAO instance;

        public static Account_DAO Instance
        {
            get { if (instance == null) instance = new Account_DAO(); return instance; }
            private set { instance = value; }
        }

        private Account_DAO() { }

        public bool login(string id, string pwd)
        {
            string query = string.Format("SELECT * FROM Account WHERE Username = '{0}' AND " + "Password = '{1}'", id, pwd); 

            DataTable result = DBConnect.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public AccountDTO getAccByID(string id)
        {
            DataTable data = DBConnect.Instance.ExecuteQuery(string.Format(
                "SELECT * FROM Account, AccountInfo " +
                "WHERE Account.Username = AccountInfo.Username AND Account.Username LIKE '{0}'", id));
            foreach (DataRow item in data.Rows)
            {
                return new AccountDTO(item);
            }
            return null;
        }

        public List<AccountDTO> getAccList()
        {
            List<AccountDTO> accList = new List<AccountDTO>();
            string query = "SELECT Account.Username, Password, Type, Fullname FROM Account, AccountInfo WHERE Account.Username = AccountInfo.Username";
            DataTable data = DBConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                AccountDTO acc = new AccountDTO(item);
                accList.Add(acc);
            }
            return accList;

        }

        public bool addtoAccDB(AccountDTO acc)
        {
            string query = string.Format(
                "INSERT INTO Account(Username, Password, Type) " +
                "VALUES ('{0}', '{1}', '{2}')" +
                "INSERT INTO dbo.AccountInfo(Username, Fullname) " +
                "VALUES ('{3}', N'{4}')",
                acc.Username, acc.Password, acc.Type, acc.Username, acc.Fullname);
            int result = DBConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool deleteAccByID(string id)
        {
            string query = string.Format(
                "DELETE AccountInfo WHERE Username = '{0}' " +
                "DELETE Account WHERE Username = '{1}'", id, id);
            int result = DBConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public bool changepwdByID(string username, string pwd)
        {
            string query = string.Format("UPDATE Account SET Password = '{0}') " +
                "WHERE Username = '{1}'", pwd, username);
            int result = DBConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
            ;
        }
    }
}
