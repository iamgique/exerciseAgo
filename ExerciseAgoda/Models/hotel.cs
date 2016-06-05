using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExerciseAgoda.Models
{
    public class hotel
    {

        public const int COLUMN_ID_INDEX = 0;
        public const int COLUMN_NAME_INDEX = 1;
        public const int COLUMN_RATING_INDEX = 2;
        public const int COLUMN_STATUS_INDEX = 3;

        public int id { get; set; }
        public String name { get; set; }
        public byte rating { get; set; }
        public String status { get; set; }
       
    }
}