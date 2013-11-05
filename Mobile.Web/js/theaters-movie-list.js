
MovieTickets.theaterListForMovie = (function () {

    //ViewModel to be bound to the view
    var viewModel = kendo.observable({
        theaterList: {},
        selectedMovie: {
            movieId: "",
            movieName: "",
            rating: "",
            imageUrl: ""
        },
        selectedDate: ""

    });

    //retrieve list of theaters from the service
    function getTheaterList(movieId) {
        var serviceOptions = {
                url: MovieTickets.configuration
                    .getTheaterListForMovieUrl,
            data: { movieId: movieId },
            requestType: "GET",
            dataType: "JSON",
            callBack: callBack
        };
        MovieTickets.dataAccess.callService(serviceOptions);

    }

    function callBack(result) {
        if (result.success === true) {
            viewModel.set("theaterList", result.data);
        }
    }    

    //handler for show event of the view
    function show(e) {
        //hard coding today's date for selected date
        viewModel.set('selectedDate', new Date().toLocaleDateString());

        //read the selected movie's details from the query string
        viewModel.set("selectedMovie", {
            movieId: e.view.params.movieId,
            movieName: decodeURIComponent(e.view.params.movieName),
            rating: e.view.params.rating,
            imageUrl: e.view.params.image
        }); 
        getTheaterList(e.view.params.movieId);
    }

    return {
        show: show,
        getTheaterList: getTheaterList,
        viewModel: viewModel       
    }
})();