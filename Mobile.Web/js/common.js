MovieTickets.common = (function () {

    function navigateToView(view) {
        //Navigate to local/remote or external view
        MovieTickets.main.getKendoApplication().navigate(view);
    }
    function showLogOffButton(){
        //show log off button.
        $(".mt-main-layout-btn-logoff").show();
    }

    function hideLogOffButton(){
        //hide log off button
        $(".mt-main-layout-btn-logoff").hide();
    }
    
    return {       
        navigateToView: navigateToView,
        showLogOffButton: showLogOffButton,
        hideLogOffButton: hideLogOffButton
    }

})();