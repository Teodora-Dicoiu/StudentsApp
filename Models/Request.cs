using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAPI.Models
{
    public class Request
    {
        public string Type { get; set; }
        public string Route { get; set; }
        public string Status { get; set; }

        public Request( string type, string route, string status)
        {
            this.Type = type;
            this.Route = route;
            this.Status = status;
        }
    }
}
