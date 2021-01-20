using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasusV0._1.Models
{
    class Login
{
        [PrimaryKey]
        public int LogId { get; set; }

        public bool LoggedIn { get; set; }

        public int UserId { get; set; }
}
}
