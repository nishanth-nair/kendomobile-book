MovieTickets.userAccount = (function () {
    //ViewModel for User Account view
    var viewModel = kendo.observable({
        isUserLoggedIn: false,
        firstName: "",
        lastName: "",
        userName: "username", //hardcoded
        password: "password", //hardcoded
        userAddress: "",
        userEmailAddress: "",
        subscribedForNewsLetter:false,
        userBookingHistory: [],
        userLogin: function () {
            var loginOptions = {
                url: MovieTickets.configuration.accountUrl,
                requestType: "GET",
                dataType: "JSON",
                httpHeader: "Authorization", //for HTTP Basic authentication

                //btoa function will convert the text to base 64 encoding
                headerValue: "Basic " + btoa(this.userName + ":" + this.password),
                callBack: this.fnLoginCallBack
            };
            MovieTickets.dataAccess.callService(loginOptions);

        },
        //method for user login
        fnLoginCallBack: function (result) {
            if (result.success === true) {
                viewModel.set("firstName", result.data.FirstName);
                viewModel.set("lastName", result.data.LastName);
                viewModel.set("userAddress", result.data.Address);
                viewModel.set("userEmailAddress", result.data.EmailId);
                viewModel.set("userBookingHistory", result.data.BookingHistory);
                viewModel.set("isUserLoggedIn", true);
                viewModel.set("subscribedForNewsLetter", result.data.SubscribedForNewsLetter);

                MovieTickets.common.showLogOffButton();
                

            } else {
                //any error handling code
            }
        },

        //method to update user details
        updateUserDetails: function () {
            var updateOptions = {
                url: MovieTickets.configuration.accountUrl,
                requestType: "POST",
                dataType: "JSON",
                data: { firstName: viewModel.get("firstName"),
                        lastName: viewModel.get("lastName"),
                        address: viewModel.get("userAddress"),
                        emailId: viewModel.get("userEmailAddress"),
                        subscribedForNewsLetter: viewModel.get("subscribedForNewsLetter")
                },

                //for HTTP Basic authentication
                httpHeader: "Authorization",
                //btoa function will convert the text to base 64 encoding
                headerValue: "Basic " + btoa(this.userName + ":" + this.password),
                callBack: function () {
                    //if you are using PhoneGap to deploy as an app, 
                    //you should use the notification api
                    alert('Details updated...');
                }
            };
            MovieTickets.dataAccess.callService(updateOptions);
        },

        //method called when log off button is clicked
        logOff: function () {
            console.log('inside logOff');
            viewModel.set("firstName", "");
            viewModel.set("lastName", "");
            viewModel.set("userAddress", "");
            viewModel.set("userEmailAddress", "");
            viewModel.set("userBookingHistory", "");
            viewModel.set("isUserLoggedIn", false);

            //hide log off button
            MovieTickets.common.hideLogOffButton();
            
            //navigate to User Account screen.
            MovieTickets.common.navigateToView("UserAccount.html");
        }
    });

    return {
        viewModel: viewModel
    }
})();