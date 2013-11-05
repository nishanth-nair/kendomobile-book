using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieTickets.WebAPI.BLL
{
    public class TheaterBO
    {   
        public string TheaterId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string MilesFromCurrentLoc { get; set; }

        //The timings property is used when the this object is used 
        //to display list of theatres for a particulat movie
        public List<string> Timings { get; set; }
        
    }
}