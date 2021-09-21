using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking.DAL;
using Parking.DTO;

namespace Parking.DAO
{
    public class Parking_UDAO
    {
        private static Parking_UDAO instance;

        public static Parking_UDAO Instance
        {
            get { if (instance == null) instance = new Parking_UDAO(); return instance; }
            private set { instance = value; }
        }

        private Parking_UDAO() { }



        public List<UserDTO> getUserList()
        {
            List<UserDTO> userList = new List<UserDTO>();
            string query = "SELECT [Statistics].CardID, MAX(TimeOut) AS Time, Image FROM  [Statistics], Parking  WHERE [Statistics].Type = N'THẺ THÁNG' AND [Statistics].CardID = Parking.CardID GROUP BY [Statistics].CardID, Image";
            DataTable data = DBConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                UserDTO user = new UserDTO(item);
                userList.Add(user);
            }
            return userList;

        }
    }
}
