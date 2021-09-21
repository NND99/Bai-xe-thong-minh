using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Parking.DTO;
using System.Data.SqlClient;

namespace Parking.DAL
{
    public class Parking_GDAO
    {
        private static Parking_GDAO instance;
        public static Parking_GDAO Instance
        {
            get { if (instance == null) instance = new Parking_GDAO(); return Parking_GDAO.instance; }
            private set { instance = value; }
        }

        private Parking_GDAO() { }
        

        public List<ParkingDTO> getListParking()
        {
            List<ParkingDTO> parkingList = new List<ParkingDTO>();
            string query = "SELECT * FROM Parking";
            DataTable data = DBConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DTO.ParkingDTO parking = new DTO.ParkingDTO(item);
                parkingList.Add(parking);
            }
            return parkingList;
        }

        public ParkingDTO getParkingByID(string id)
        {
            string query = string.Format("SELECT * FROM Parking WHERE CardID = '{0}' ORDER BY time DESC", id);
            DataTable data = DBConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return new ParkingDTO(item);
            }
            return null;
        }

        public bool addtoDB(ParkingDTO parking)
        {
            string query = string.Format("INSERT INTO Parking(CardID, Time, Status, Type, Image)"
                + "VALUES('{0}','{1}','{2}',N'{3}', '{4}')", parking.CardID, parking.Time, parking.Status, parking.Type, parking.Image);
            int result = DBConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

       
        public bool deleteParkingByID(string id)
        {
            string query = string.Format("DELETE Parking WHERE CardID = '{0}'", id);
            int result = DBConnect.Instance.ExecuteNonQuery(query);
            return result > 0;


        }
  

        public bool updateParkingByID(ParkingDTO parking)
        {
            string query = string.Format("UPDATE Parking SET CardID='{0}',Time='{1}',Status='{2}', Type= N'{3}',Image='{4}' WHERE CardID='{5}'", parking.CardID, parking.Time, parking.Status, parking.Type,parking.Image, parking.CardID);
            int result = DBConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public List<StatisticsDTO> getStatisticsByDate(string timeIn, string timeOut)
        {
            List<StatisticsDTO> statisList = new List<StatisticsDTO>();
            string query = "SELECT * FROM [Statistics] WHERE TimeIn >= '" + timeIn + "' AND TimeIn <= '" + timeOut + "'";
            DataTable data = DBConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                StatisticsDTO statics = new StatisticsDTO(item);
                statisList.Add(statics);
            }
            return statisList;

        }

        public List<StatisticsDTO> getStatisticsByDay(string day, string month, string year)
        {
            List<StatisticsDTO> statisList = new List<StatisticsDTO>();
            string query = string.Format("SELECT * FROM [Statistics] WHERE DAY(TimeIn) = '{0}' AND MONTH(timeIn) = '{1}' AND YEAR(TimeIn) = '{2}'", day, month, year);
            DataTable data = DBConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                StatisticsDTO statics = new StatisticsDTO(item);
                statisList.Add(statics);
            }
            return statisList;

        }

        public List<StatisticsDTO> getStatisticsByMonth(string month, string year)
        {
            List<StatisticsDTO> statisList = new List<StatisticsDTO>();
            string query = string.Format("SELECT * FROM [Statistics] WHERE MONTH(TimeIn) = '{0}' AND YEAR(TimeIn) = '{1}'", month, year);
            DataTable data = DBConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                StatisticsDTO statics = new StatisticsDTO(item);
                statisList.Add(statics);
            }
            return statisList;

        }

        public List<StatisticsDTO> getStatisticsByYear(string year)
        {
            List<StatisticsDTO> statisList = new List<StatisticsDTO>();
            string query = string.Format("SELECT * FROM [Statistics] WHERE YEAR(TimeIn) = '{0}'", year);
            DataTable data = DBConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                StatisticsDTO statics = new StatisticsDTO(item);
                statisList.Add(statics);
            }
            return statisList;

        }

        public List<StatisticsDTO> getStatisticsByUser()
        {
            List<StatisticsDTO> statisList = new List<StatisticsDTO>();
            string query = "SELECT * FROM [Statistics] WHERE Type='THẺ THÁNG'";
            DataTable data = DBConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                StatisticsDTO statics = new StatisticsDTO(item);
                statisList.Add(statics);
            }
            return statisList;

        }

        public List<StatisticsDTO> getStatisticsDB()
        {
            List<StatisticsDTO> statisList = new List<StatisticsDTO>();
            string query = "SELECT * FROM [Statistics]";
            DataTable data = DBConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                StatisticsDTO statics = new StatisticsDTO(item);
                statisList.Add(statics);
            }
            return statisList;

        }

        public bool addtoStatisticsDB(StatisticsDTO mystatics)
        {
            string query = string.Format("INSERT INTO [Statistics](CardID, TimeIn, TimeOut, Type, Money)"
                + "VALUES('{0}', '{1}', '{2}', N'{3}', '{4}')", mystatics.CardID, mystatics.TimeIn, mystatics.TimeOut, mystatics.Type, mystatics.Money);
            int result = DBConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool deleteStatisticsByID(string id)
        {
            string query = string.Format("DELETE [Statistics] WHERE CardID = '{0}'", id);
            int result = DBConnect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
