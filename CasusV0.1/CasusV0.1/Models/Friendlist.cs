using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasusV0._1.Models
{
    public class Friendlist
    {
        [PrimaryKey, AutoIncrement]
        public int Friendlist_ID { get; set; }

        public int User_ID { get; set; }

        public int User_ID_Adjacent { get; set; }

    }
}

