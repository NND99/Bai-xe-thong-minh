using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.DTO
{
    public class StatisticsDTO
    {

        private String cardID;
        private String timeIn;
        private String timeOut;
        private String type;
        private double money;

        public StatisticsDTO(string cardID, string timeIn, string timeOut, string type, double money)
        {
            this.cardID = cardID;
            this.timeIn = timeIn;
            this.timeOut = timeOut;
            this.type = type;
            this.money = money;
        }

        public string CardID { get => cardID; set => cardID = value; }
        public string TimeIn { get => timeIn; set => timeIn = value; }
        public string TimeOut { get => timeOut; set => timeOut = value; }
        public string Type { get => type; set => type = value; }
        public double Money { get => money; set => money = value; }

        public StatisticsDTO(DataRow row)
        {
            this.cardID = row["CardID"].ToString();
            this.timeIn = row["TimeIn"].ToString();
            this.timeOut = row["TimeOut"].ToString();
            this.type = row["Type"].ToString();
            this.money = (int)row["Money"];
        }
    }
}
