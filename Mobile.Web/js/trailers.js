MovieTickets.trailers = (function () {  

    function show(e) {
        var options = {
            url: MovieTickets.configuration.getTrailersUrl,
            requestType: "GET",
            dataType: "JSON",
            callBack: callBack
        };
        MovieTickets.dataAccess.callService(options);        
    }

    function callBack(result) {
        if (result.success === true) {
            //
            var trailerTemplate = kendo.template($("#mt-trailers-view #mt-tmpl-trailers").html());
            $("#mt-trailers-view #mt-trailer-scrollview")
                .data('kendoMobileScrollView')
                .content(kendo.render(trailerTemplate, result.data));                
        }
    }

    return {        
        show:show
    }


})();