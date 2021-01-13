using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace CasusV0._1.Models
{
    public class Users
    {
        [PrimaryKey, AutoIncrement]
        public int User_Id { get; set; }

        [MaxLength(30)]
        public string Username { get; set; }

        public string Password { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }

        public int Weight { get; set; }

        public int Length { get; set; }
    }
}
