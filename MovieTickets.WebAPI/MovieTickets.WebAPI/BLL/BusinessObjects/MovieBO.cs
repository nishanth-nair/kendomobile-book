using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieTickets.WebAPI.BLL
{
    public class MovieBO
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Rating { get; set; }
        public string Length { get; set; }
        public string Genre { get; set; }
        public string LeadStars { get; set; }
        public string Image { get; set; }
        public bool IsNowPlaying { get; set; }
    }
}