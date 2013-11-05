using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieTickets.WebAPI.BLL
{
    public class UserBO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public bool SubscribedForNewsLetter { get; set; }
        public List<TicketBO> BookingHistory { get; set; }
    }
}