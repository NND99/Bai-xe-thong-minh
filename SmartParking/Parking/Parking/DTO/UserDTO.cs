using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.DTO
{
    public class UserDTO
    {
        String cardID;
        String time;
        String image;


        public UserDTO(DataRow row)
        {
            this.CardID = row["CardID"].ToString();
            this.Time = row["Time"].ToString();
            this.Image = row["Image"].ToString();
        }

        public UserDTO(string cardID, string time, string image)
        {
            this.cardID = cardID;
            this.time = time;
            this.image = image;
        }

        public string CardID { get => cardID; set => cardID = value; }
        public string Time { get => time; set => time = value; }
        public string Image { get => image; set => image = value; }
    }
}
