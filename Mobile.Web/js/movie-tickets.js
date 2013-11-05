
MovieTickets.main = (function () {
    var application;

    function getApplication() {
        return application;
    }

    function initializeApp() {

        //initialize app
        application = new kendo.mobile.Application(document.body,
         {             
             transition: 'slide',
             loading: "<h3>Loading...</h3>"
             
         });

        //Display loading image on every ajax call
        $(document).ajaxStart(function () {           

            //application.showLoading calls the showLoading() method of the 
            //pane object inside the application. During the application's 
            //initial view's init method this pane object may not be initialized
            //and so application.showLoading() may throw error.To prevent this
            //we need to do a check for existence application.pane before calling
            //application.showLoading();
            if (application.pane) {
                application.showLoading();
            }            
        });

        //Hide ajax loading image on after ajax call
        $(document).ajaxStop(function () {
            
            if (application.pane) {
                application.hideLoading();
            }
            });
    }

    return {                
        initializeApp: initializeApp,
        getKendoApplication: getApplication        
    }
})();