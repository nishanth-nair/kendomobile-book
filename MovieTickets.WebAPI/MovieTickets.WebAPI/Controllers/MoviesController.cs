using MovieTickets.WebAPI.BLL;
using MovieTickets.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieTickets.WebAPI.Controllers
{
    public class MoviesController : ApiController
    {        
        
        [Authorize]
        public List<MovieBO> Get(string id)
        {
           return MovieTicketsBLL.GetMovies(id);
        }

        [Authorize]
        public List<MovieBO> Get()
        {
            return MovieTicketsBLL.GetMovies("");
        }
       
        
        public List<MovieBO> GetMovieList(int listType)
        {
           return MovieTicketsBLL.GetMovieList(listType);
        }
        
         public List<TrailerBO> GetTrailers()
        {
           return MovieTicketsBLL.GetTrailers();
        }
                
        // POST api/values
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}