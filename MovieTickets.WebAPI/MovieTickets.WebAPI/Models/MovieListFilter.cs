using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieTickets.WebAPI.Models
{
    public class MovieListFilter
    {
        public bool? IsNowPlaying {get; set;}
        public int PageNo {get; set;}
        public int PageSize {get; set;}
    }
}