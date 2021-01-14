using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasusV0._1.Models
{
    public class Friendlist
    {
        [PrimaryKey, AutoIncrement]
        public int Friendlist_Id { get; set; }

        public int User_Id { get; set; }

        public int User_Id_Adjacent { get; set; }

    }
}

