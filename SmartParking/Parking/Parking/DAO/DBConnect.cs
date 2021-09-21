using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.DAL
{
    public class DBConnect
    {
        private static DBConnect instance;
        /*        private String conn = @"Data Source=.\sqlexpress;Database=AdvanceProgrammingDB;Integrated Security=True";*/
        private String conn =
            "Data Source=;" +
            "Initial Catalog=SParking;" +
            "Integrated Security=True;" +
            "User=sa;" +
            "Password=";

        public static DBConnect Instance
        {
            get { if (instance == null) instance = new DBConnect(); return DBConnect.instance; }
            private set { DBConnect.instance = value; }
        }

        private DBConnect() { }

        public DataTable ExecuteQuery(string query, object[] para = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (para != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(dt);

                connection.Close();
            }

            return dt;
        }

        public int ExecuteNonQuery(string query, object[] para = null)
        {
            int dt = 0;
            using
            (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (para != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }
                }
                dt = command.ExecuteNonQuery();
                connection.Close();
            }
            return dt;
        }
    }
}

