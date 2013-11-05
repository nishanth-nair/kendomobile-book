using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieTickets.WebAPI.Models
{
    public class UserViewmodel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserId { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string FullName { get; set; }
    }
}