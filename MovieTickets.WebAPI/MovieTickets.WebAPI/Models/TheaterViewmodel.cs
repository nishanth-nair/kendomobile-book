using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieTickets.WebAPI.Models
{
    public class TheaterViewmodel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NoOfScreens { get; set; }
        public int ZipCode { get; set; }
        public string State {get; set; }
        public string City { get; set; }
        public string StreetAddress { get; set; }
        public string Country { get; set; }
    }
}