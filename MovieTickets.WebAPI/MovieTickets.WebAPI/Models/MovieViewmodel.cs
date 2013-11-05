using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieTickets.WebAPI.Models
{
    public class MovieViewmodel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public string Rating { get; set; }
        public string Reviews { get; set; }
    }
}