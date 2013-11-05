using MovieTickets.WebAPI.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieTickets.WebAPI.Controllers
{
    public class TheaterController : ApiController
    {
         public List<TheaterBO> Get(int movieId)
        {
           return MovieTicketsBLL.GetTheaterListForMovie(movieId);
        }
    }
}
