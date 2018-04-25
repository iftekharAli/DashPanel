using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DashPanel.Models
{
    public class Login
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}