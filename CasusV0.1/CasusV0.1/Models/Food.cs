using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasusV0._1.Models
{
    public class Food
    {
        [PrimaryKey, AutoIncrement]
        public int Food_Id { get; set; }

        public string Foodname { get; set; }

        public int Calories { get; set; }

        public string Foodtype { get; set; }

        public string Foodimage { get; set; }
    }
}
