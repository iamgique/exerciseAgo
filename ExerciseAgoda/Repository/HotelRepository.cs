using System;
using System.Collections.Generic;
using ExerciseAgoda.Models;
using System.Data.SqlClient;

namespace ExerciseAgoda.Repository
{
    public class HotelRepository : IHotelRepository
    {
        private ConnectDB db = new ConnectDB();
        
        public SqlDataReader reader()
        {
            db.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM hotel";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = db.conn;

            return cmd.ExecuteReader();
        }

        public List<hotel> fetchHotels()
        {
            SqlDataReader reader = this.reader();

            var hotelList = new List<hotel>();
            while (reader.Read())
            {
                var hotelMap = new hotel();
                hotelMap.id = reader.GetInt32(hotel.COLUMN_ID_INDEX);
                hotelMap.name = reader.GetString(hotel.COLUMN_NAME_INDEX);
                hotelMap.rating = reader.GetByte(hotel.COLUMN_RATING_INDEX);
                hotelMap.status = reader.GetString(hotel.COLUMN_STATUS_INDEX);
                hotelList.Add(hotelMap);
            }
            db.Close();
            return hotelList;
           
        }
    }
}