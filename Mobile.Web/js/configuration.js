MovieTickets.configuration = (function () {

   //var serviceUrl = "http://localhost/movietickets.webapi/api/";
    var serviceUrl = "http://api.kendomobilebook.com/api/";
    

    return {            
        serviceUrl: serviceUrl,
        accountUrl: serviceUrl + "Account/",
        getMovieListUrl: serviceUrl + "Movies/GetMovieList/",        
        getTheaterListForMovieUrl: serviceUrl +
            "Theater/Get/",
        getTrailersUrl: serviceUrl + "Movies/GetTrailers/",
        purchaseTicketsUrl: serviceUrl + "Tickets"
    }
})();