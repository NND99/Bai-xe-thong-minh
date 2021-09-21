using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.DTO
{
    public class ParkingDTO
    {
        String cardID;
        String time;
        String status;
        String type;
        String image;

        public ParkingDTO(string cardID, String time, string status, string type, string image)
        {
            this.cardID = cardID;
            this.time = time;
            this.status = status;
            this.type = type;
            this.image = image;
        }

        public string CardID { get => cardID; set => cardID = value; }
        public String Time { get => time; set => time = value; }
        public string Status { get => status; set => status = value; }
        public string Type { get => type; set => type = value; }
        public string Image { get => image; set => image = value; }

        public ParkingDTO(DataRow row)
        {
            this.CardID = row["cardID"].ToString();
            this.time = row["time"].ToString();
            this.Status = row["status"].ToString();
            this.Type = row["type"].ToString();
            this.Image = row["image"].ToString();
        }
    }
}
