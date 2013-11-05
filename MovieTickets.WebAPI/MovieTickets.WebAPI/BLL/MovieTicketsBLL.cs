using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieTickets.WebAPI.BLL
{
    public class MovieTicketsBLL
    {

        public static List<TrailerBO> GetTrailers()
        {
            return MovieRepository.GetTrailersMasterList();
        }

        public static List<MovieBO> GetMovies(string searchKeyword)
        {
            return MovieRepository.GetMovies(searchKeyword);
        }

        public static List<MovieBO> GetMovieList(int listType)
        {
            var moviesMasterList = MovieRepository.GetMoviesMasterList();

            switch (listType)
            {
                 //return now playing movies
                case 0:
                    return moviesMasterList
                            .Where( m => m.IsNowPlaying == true )
                            .ToList();

                //return coming soon movies
                case 1:
                    return moviesMasterList
                           .Where(m => m.IsNowPlaying == false)
                           .ToList();
                

                // return all the movies sorted by name
                default:
                    return moviesMasterList
                           .OrderBy(x => x.Name)
                           .ToList();
            }
        }

        public static List<TheaterBO> GetTheaterListForMovie(int movieId)
        {
            //for any movie, return all the theatres 
            return MovieRepository.GetTheatresMasterList();
        }

        public static int AddEditUser(UserBO user)
        {
            return MovieRepository.AddEditUser(user);
        }

        public static List<TheaterBO> GetTheaters(string searchtheater)
        {
            return MovieRepository.GetTheaters(searchtheater);
        }

        public static UserBO GetLoggedInUserDetails(string userName)
        {
            return MovieRepository.GetUserDetails(userName);
        }

    }
}