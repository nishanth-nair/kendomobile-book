using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MovieTickets.WebAPI.BLL;

namespace MovieTickets.WebAPI.Controllers
{
    public class TicketsController : ApiController
    {
        

        // POST api/tickets
        public bool Post(TicketPurchaseBO ticket)
        {
            //implement save logic here. for the sake of simplicity
            //we assume that the ticket is saved properly and 
            //return a success boolean.
            
            return true;
        }

        
    }
}
