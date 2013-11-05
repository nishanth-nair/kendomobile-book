using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieTickets.WebAPI.BLL
{
    public class TicketBO
    {
         public int TicketId { get; set; }
         public string TheaterName { get; set; }
         public string MovieName { get; set; }
         public  string Screen { get; set; }
         public int NoOfPersons { get; set; }
         public string ShowDate { get; set; }
         public string ShowTime { get; set; }
    }
}