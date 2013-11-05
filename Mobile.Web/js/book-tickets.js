
MovieTickets.bookTickets = (function () {

    var viewModel = kendo.observable({

        //method to increment no of child tickets
        incrementChildTicket: function () {

            this.set("noChildTickets", parseInt(
                        this.get("noChildTickets")) + 1);
        },

        //method to increment no of adult tickets
        incrementAdultTicket: function () {            
             
            this.set("noAdultTickets", parseInt(
                        this.get("noAdultTickets")) + 1);
        }, 

        //method to decrement no of child tickets
        decrementChildTicket: function () {
            if (this.get("noChildTickets") !=0 )
                this.set("noChildTickets", parseInt(
                            this.get("noChildTickets")) - 1);
        },

        //method to decrement no of adult tickets
        decrementAdultTicket: function () {
            if (this.get("noAdultTickets") != 0)            
                this.set("noAdultTickets", parseInt(
                            this.get("noAdultTickets")) - 1);
        },

        //get the total amount for adult ickets
        noAdultTotalAmount: function () {                         
                return this.get("noAdultTickets") * 10.00            
        },

        //get the total amount for child tickets
        noChildTotalAmount: function () {           
                return this.get("noChildTickets") * 8.00           
        },

        //get total amount    
        totalAmount: function () {
            return viewModel.noAdultTotalAmount() +
                   viewModel.noChildTotalAmount();
        },        
        
        noAdultTickets: 0,
        noChildTickets: 0,

        //movie details
        selectedMovie: {
            movieId: "",
            movieName: "",
            rating: "",            
        },
        //teater details
        selectedTheater: {
            theaterId: "",
            theaterName: "",
            address: "",
            time:""
        },       
    });

    //in the view's show event , set details of
    //selected movie and theater
    function show(e) {
        viewModel.set("selectedMovie", {
            movieId: e.view.params.movieId,
            movieName: decodeURIComponent(e.view.params.movieName),
            rating: e.view.params.rating,
        });
        viewModel.set("selectedTheater", {
            theaterId: e.view.params.theaterId,
            theaterName: decodeURIComponent(e.view.params.theaterName),
            address: decodeURIComponent(e.view.params.address),
            time: decodeURIComponent(e.view.params.time),
            date: decodeURIComponent(e.view.params.date)
        });
    }
    
    //method to purchase tickets. This method sends
    //all the data to the service in an HTTP POST
    function purchaseTickets() {

        //no tickets are selected, display a message
        if (viewModel.noAdultTickets == 0 &&
            viewModel.noChildTickets == 0) {
            alert('Atlease one ticket needs to be purchased.');
            return;
        }
        
        var serviceOptions = {
            url: MovieTickets.configuration.purchaseTicketsUrl,
            data: {
                movieId: viewModel.selectedMovie.movieId,
                theaterId: viewModel.selectedTheater.theaterId,
                noOfAdultTickets: viewModel.noAdultTickets,
                noOfChildTickets: viewModel.noChildTickets,
                showDate: viewModel.selectedTheater.date,
                showTime: viewModel.selectedTheater.time,
                totalAmount: viewModel.totalAmount
            },
            requestType: "POST",
            dataType: "JSON",
            callBack: purchaseCallBack
        }
        //service call.
        MovieTickets.dataAccess.callService(serviceOptions);

        function purchaseCallBack(result) {
            if (result.success === true) {
                //display a message to the user
                //using modal view
                var intializedModalView =
                    $("#mt-modal-complete").data("kendoMobileModalView");

                //if the modal view is already initialized,
                //destroy it
                if (intializedModalView) {
                    intializedModalView.destroy();
                }

                $('#mt-modal-complete').kendoMobileModalView({
                    height: 130, width: 200
                }).data("kendoMobileModalView").open();

            } else {
                alert('purchase failed. please try again.');
            }
        }
    }

    //method to close the modal view and redirect
    //to the main view.
    function closeModalView() {       

        //close the confirmation modal popup
        $("#mt-modal-complete").data("kendoMobileModalView").close();

        //navigate to the home page
        MovieTickets.main.getKendoApplication().navigate('#mt-home-main-view');
    }

    return {
        show: show,        
        viewModel: viewModel,     
        purchaseTickets: purchaseTickets,
        closeModalView: closeModalView
    }
    

})();