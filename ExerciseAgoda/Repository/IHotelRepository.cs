using System.Collections.Generic;
using System.Data.SqlClient;

namespace ExerciseAgoda.Repository
{
    public interface IHotelRepository
    {
        List<Models.hotel> fetchHotels();
        SqlDataReader reader();
    }
}
