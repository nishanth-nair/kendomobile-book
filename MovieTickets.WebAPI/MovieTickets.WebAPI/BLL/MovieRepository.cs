using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MovieTickets.WebAPI.BLL
{
    public class MovieRepository
    {
        public static List<MovieBO> moviesMasterList; 
        public static List<TheaterBO> theatresMasterList; 
        public static List<TrailerBO> trailersMasterList; 
        

        /// <summary>
        /// Gets the list of Movies
        /// </summary>
        /// <param name="searchmovie"></param>
        /// <returns></returns>
        public static List<MovieBO> GetMovies(string searchKeyword)
        {          

            List<MovieBO> moviesList = new List<MovieBO>();
            return moviesList;
        }

        //This method returns a list of
        //trailer links and movie names
        public static List<TrailerBO> GetTrailersMasterList()
        {
             if (trailersMasterList == null || trailersMasterList.Count == 0)
            {
               CreateTrailersMasterList();               
            }
            return trailersMasterList;

        }

        public static List<MovieBO> GetMoviesMasterList()
        {
            if (moviesMasterList == null 
                || moviesMasterList.Count == 0)
            {
               CreateMoviesMasterList();               
            }
            return moviesMasterList;
        }

        public static List<TheaterBO> GetTheatresMasterList()
        {
            if (theatresMasterList == null || theatresMasterList.Count == 0)
            {
               CreateTheatersMasterList();               
            }
            return theatresMasterList;
        }

        //Method to create hardcode data for trailers
        private static void CreateTrailersMasterList()
        {
            trailersMasterList = new List<TrailerBO>()
            {
                new TrailerBO(){
                    MovieName= "The Great Gatsby (2013)",
                    VideoUrl= "http://www.youtube.com/embed/rARN6agiW7o?html5=1"
                },
                new TrailerBO(){
                    MovieName= "Iron Man 3",
                    VideoUrl= "http://www.youtube.com/embed/2CzoSeClcw0?html5=1"
                },
                new TrailerBO(){
                    MovieName= "Peeples",
                    VideoUrl= "http://www.youtube.com/embed/jy9Y06zpgTo?html5=1"
                },
                new TrailerBO(){
                    MovieName= "Oblivion",
                    VideoUrl= "http://www.youtube.com/embed/HQ0iiqyJ7BU?html5=1"
                },
                new TrailerBO(){
                    MovieName= "Star Trek Into Darkness ",
                    VideoUrl= "http://www.youtube.com/embed/QAEkuVgt6Aw?html5=1"
                }
            };
        }

        private static void CreateTheatersMasterList()
        {
            theatresMasterList = new List<TheaterBO>()
            {
                new TheaterBO(){
                    TheaterId = "1",
                    Name = "AMC Showplace Vernon Hills",
                    Address="555 North Lakeview Parkway, Vernon Hills, IL 60061",
                    MilesFromCurrentLoc = ".5",
                    Timings = new List<string>(){"11:30 AM","1:00 PM", "3:30 PM", "5:00 PM", "7:00 PM"  }
                },
                 new TheaterBO(){
                     TheaterId = "2",
                    Name = "Regal Lincolnshire Stadium 21 & IMAX",                    
                    Address="300 Parkway Drive, Lincolnshire, IL 60069",
                    MilesFromCurrentLoc = ".9",
                    Timings = new List<string>(){"10:30 AM","11:00 AM", "1:30 PM", "4:00 PM", "6:30 PM"  }
                },
                 new TheaterBO(){
                     TheaterId = "2",
                    Name = "B.G. Cinema, Inc DBA Buffalo Grove Theater",
                    Address="120 Old McHenry Rd., Buffalo Grove, IL 60089",
                    MilesFromCurrentLoc = "1.5",
                    Timings = new List<string>(){"1:30 PM","4:00 PM", "6:30 PM", "8:00 PM", "9:30 PM"  }
                },
                 new TheaterBO(){
                     TheaterId = "3",
                    Name = "Century 16 Deer Park",
                    Address="21600 W Field Parkway, Deer Park, IL 60010",
                    MilesFromCurrentLoc = "2.0",
                    Timings = new List<string>(){"11:30 AM","1:00 PM", "3:30 PM", "5:00 PM", "11:00 PM"  }
                },
                 new TheaterBO(){
                    TheaterId = "4",
                    Name = "Regal Lake Zurich 12",
                    Address="755 S Rand Road, Lake Zurich, IL 60047",
                    MilesFromCurrentLoc = "2.75",
                    Timings = new List<string>(){"12:30 PM","2:00 PM", "4:30 PM", "6:00 PM", "8:00 PM"  }
                },
                 new TheaterBO(){
                    TheaterId = "5",
                    Name = "AMC Northbrook Court 14",
                    Address="1525 Lake Cook Road, Northbrook, IL 60062",
                    MilesFromCurrentLoc = "3.5",
                    Timings = new List<string>(){"11:30 AM","1:00 PM", "4:30 PM", "5:30 PM", "10:00 PM"  }
                },
                 new TheaterBO(){
                    TheaterId = "6",
                    Name = "AMC Randhurst 12 ",
                    Address="200 Access Road, Mount Prospect, IL 60056",
                    MilesFromCurrentLoc = "4.0",
                    Timings = new List<string>(){"12:30 PM","3:30 PM", "5:30 PM", "8:00 PM", "11:00 PM"  }
                }
             };


        }


       private static void CreateMoviesMasterList()
       {                               

            moviesMasterList = new List<MovieBO>()
            {
                new MovieBO(){
                    MovieId = 1,
                    Name = "The Great Gatsby (2013)",
                    Genre = "Drama",
                    Image = "http://images.kendomobilebook.com/movies/greatgatsby.jpg",
                    IsNowPlaying = true,
                    LeadStars = "Leonardo DiCaprio, Amitabh Bachchan",
                    Length = "143",                    
                    Rating = "PG-13"
                },
                new MovieBO(){
                    MovieId = 2,
                    Name= "Iron man 3",
                    Genre= "Sci-Fi",
                    Image = "http://images.kendomobilebook.com/movies/ironman3.jpg",
                    IsNowPlaying = true,
                    LeadStars = "Robert Downey Jr., Gwyneth Paltrow",
                    Length = "130",                    
                    Rating = "PG-13"
                },
                 new MovieBO(){
                    MovieId = 3,
                    Name= "Iron man 3 3D",
                    Genre= "Sci-Fi",
                    Image = "http://images.kendomobilebook.com/movies/ironman3.jpg",
                    IsNowPlaying = true,
                    LeadStars = "Robert Downey Jr., Gwyneth Paltrow",
                    Length = "130",                    
                    Rating = "PG-13"
                },

                new MovieBO(){
                    MovieId = 4,
                    Name = "Peeples",
                    Genre = "Comedy",
                    Image = "http://images.kendomobilebook.com/movies/peeples.jpg",
                    IsNowPlaying = true,
                    LeadStars = "Craig Robinson, Kerry Washington",
                    Length = "95",                    
                    Rating = "PG-13"
                },
                new MovieBO(){
                    MovieId = 5,
                    Name= "Pain & Gain",
                    Genre= "Comedy",
                    Image = "http://images.kendomobilebook.com/movies/painandgain.jpg",
                    IsNowPlaying = true,
                    LeadStars = "Mark Wahlberg, Dwayne Johnson",
                    Length = "129",                    
                    Rating = "PG-13"
                },
                 new MovieBO(){
                    MovieId = 6,
                    Name= "42",
                    Genre= " Biography ",
                    Image = "http://images.kendomobilebook.com/movies/42.jpg",
                    IsNowPlaying = true,
                    LeadStars = "Chadwick Boseman, Harrison Ford, Nicole Beharie",
                    Length = "128",                    
                    Rating = "PG-13"
                },
                new MovieBO(){
                    MovieId = 7,
                    Name = "Oblivion",
                    Genre = "Sci-Fi",
                    Image = "http://images.kendomobilebook.com/movies/oblivion.jpg",
                    IsNowPlaying = true,
                    LeadStars = "Tom Cruise, Morgan Freeman, Olga Kurylenko",
                    Length = "124",                    
                    Rating = "PG-13"
                },
                new MovieBO(){
                    MovieId = 8,
                    Name= "The Big Wedding",
                    Genre= "Comedy",
                    Image = "http://images.kendomobilebook.com/movies/thebigwedding.jpg",
                    IsNowPlaying = true,
                    LeadStars = "Robert De Niro, Katherine Heigl, Diane Keaton ",
                    Length = "89",                    
                    Rating = "R"
                },
                 new MovieBO(){
                    MovieId = 9,
                    Name= "Becoming Traviata",
                    Genre= "Documentary",
                    Image = "http://images.kendomobilebook.com/movies/becomingtraviata.jpg",
                    IsNowPlaying = false,
                    LeadStars = "Natalie Dessay, Louis Langrée",
                    Length = "120",                    
                    Rating = "NR"
                },
                new MovieBO(){
                    MovieId = 10,
                    Name= "Star Trek Into Darkness",
                    Genre= "Sci-Fi",
                    Image = "http://images.kendomobilebook.com/movies/startrek.jpg",
                    IsNowPlaying = false,
                    LeadStars = "Benedict Cumberbatch, Chris Pine",
                    Length = "132",                    
                    Rating = "PG-13"
                },
                  new MovieBO(){
                    MovieId = 11,
                    Name= "Augustine",
                    Genre= "Drama",
                    Image = "http://images.kendomobilebook.com/movies/augustine.jpg",
                    IsNowPlaying = false,
                    LeadStars = "Vincent Lindon, Soko",
                    Length = "101",                    
                    Rating = "NR"
                },
                new MovieBO(){
                    MovieId = 12,
                    Name= "Aurangzeb",
                    Genre= "Action",
                    Image = "http://images.kendomobilebook.com/movies/aurangzeb.jpg",
                    IsNowPlaying = false,
                    LeadStars = " Arjun Kapoor, Prithviraj Sukumaran",
                    Length = "132",                    
                    Rating = "NR"
                },
                  new MovieBO(){
                    MovieId = 13,
                    Name= "Black Rock",
                    Genre= "Horror",
                    Image = "http://images.kendomobilebook.com/movies/blackrock.jpg",
                    IsNowPlaying = false,
                    LeadStars = "Katie Aselton, Lake Bell",
                    Length = "120",                    
                    Rating = "R"
                },
                new MovieBO(){
                    MovieId = 14,
                    Name= "The English Teacher",
                    Genre= "Comedy",
                    Image = "http://images.kendomobilebook.com/movies/TheEnglishTeacher.jpg",
                    IsNowPlaying = false,
                    LeadStars = "Lily Collins, Julianne Moore",
                    Length = "93",                    
                    Rating = "PG-13"
                }
            };






            }






        /// <summary>
        /// Gets the list of theaters
        /// </summary>
        /// <param name="searchtheater"></param>
        /// <returns></returns>
        public static List<TheaterBO> GetTheaters(string searchtheater)
        {

            return new List<TheaterBO>();
            //var context = new MoviesTicketDBEntities();

            //if (!string.IsNullOrEmpty(searchtheater))
            //    return (from theater in context.Theaters
            //            where theater.Name.Contains(searchtheater)
            //            select new TheaterBO
            //            {
            //                Name = theater.Name
            //            }).ToList();
            //else
            //    return (from theater in context.Theaters
            //            select new TheaterBO
            //            {
            //                Name = theater.Name

            //            }).ToList();
        }

        /// <summary>
        /// Gets the list of theaters
        /// </summary>
        /// <param name="searchtheater"></param>
        /// <returns></returns>
        public static UserBO GetUserDetails(string userName)
        {
            //2 users are created by default            
            var usersList = new List<UserBO>{
                new UserBO(){
                    Address = "123 North Field Pkwy, Buffalo Grove, Illinois",
                    EmailId = "alison.massey@email.com",
                    FirstName = "Alison",
                    LastName = "Massey",
                    UserName = "username1", 
                    SubscribedForNewsLetter = true,
                    BookingHistory = new List<TicketBO>{
                         new TicketBO(){
                            TicketId = new Random().Next(10000),
                            TheaterName = "AMC, South Barrington, IL",
                            MovieName = "The Call",
                            Screen = "12",
                            NoOfPersons = 5,
                            ShowDate = "15-Aug-2013",
                            ShowTime = "4:30 PM"
                         },
                         new TicketBO(){
                            TicketId = new Random().Next(10000),
                            TheaterName = "Regal Cinemas, Lincolnshire, IL",
                            MovieName = "Argo",
                            Screen = "7",
                            NoOfPersons = 2,
                            ShowDate = "25-Aug-2013",
                            ShowTime = "7:00 PM"
                         }
  
                        },
                   },

            new UserBO(){
                    Address = "20627 Mauve Orchid Way,Dallas, TX ",
                    EmailId = "patrick.dcoster@email.com",
                    FirstName = "Patrick",
                    LastName = "DCoster",
                    UserName = "username",  
                    SubscribedForNewsLetter = false,
                    BookingHistory = new List<TicketBO>{
                         new TicketBO(){
                            TicketId = new Random().Next(10000),
                            TheaterName = "AMC NorthPark, North Central Expressway, Dallas, TX",
                            MovieName = "Evil Dead",
                            Screen = "19",
                            NoOfPersons = 6,
                            ShowDate = "13-July-2013",
                            ShowTime = "4:30 PM"
                         },
                         new TicketBO(){
                            TicketId = new Random().Next(10000),
                            TheaterName = "AmStar 14, Technology Boulevard, Dallas, TX",
                            MovieName = "The Host",
                            Screen = "21",
                            NoOfPersons = 1,
                            ShowDate = "21-Sept-2013",
                            ShowTime = "5:00 PM"
                         }  
                        },
                   }
            };



            return usersList.FirstOrDefault(x => x.UserName.Equals(userName)); 
        }

        /// <summary>
        /// Add update users
        /// </summary>
        /// <param name="searchtheater"></param>
        /// <returns></returns>
        public static int AddEditUser(UserBO user)
        {

            return 0;
            //var context = new MoviesTicketDBEntities();
            //var userdal = new User();
            //if (user.UserId == 0)
            //{
            //    userdal.FirstName = user.FirstName;
            //    userdal.LastName = user.LastName;
            //    userdal.Address = user.Address;
            //    userdal.EmailId = user.EmailId;
            //    context.Users.Add(userdal);
            //    context.SaveChanges();
            //    return 1;
            //}
            //else
            //{
            //    userdal.FirstName = user.FirstName;
            //    userdal.LastName = user.LastName;
            //    userdal.Address = user.Address;
            //    userdal.EmailId = user.EmailId;
            //    userdal.UserId = user.UserId;
            //    context.Entry(user).State = EntityState.Modified;
            //    context.Users.Add(userdal);
            //    context.SaveChanges();
            //    return 1;
            //}


        }


        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}