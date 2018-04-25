using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DashPanel.Models
{
    public class ServiceRanking
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public string Type { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class GetInfo
    {
        public DateTime FromDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class RawInfo
    {
        public string ServiceName { get; set; }
        public string Operator { get; set; }
    }
    public class Service
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
    }
}