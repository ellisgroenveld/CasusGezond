using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasusV0._1.Models
{
    class Eaten
    {
        [PrimaryKey, AutoIncrement]
        public int Eaten_Id { get; set; }

        public int User_Id { get; set; }

        public int Food_Id { get; set; }

        public string Date { get; set; }

        public int Quantity { get; set; }
    }
}
