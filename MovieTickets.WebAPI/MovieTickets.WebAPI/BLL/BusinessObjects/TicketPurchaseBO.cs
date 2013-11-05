using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieTickets.WebAPI.BLL
{
    public class TicketPurchaseBO
    {
         
         public string TheaterId { get; set; }
         public string MovieId { get; set; }         
         public int NoOfChildTickets { get; set; }
         public int NoOfAdultTickets { get; set; }
         public string ShowDate { get; set; }
         public string ShowTime { get; set; }
         public string TotalAmount { get; set; }
    }
}