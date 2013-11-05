using MovieTickets.WebAPI.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MovieTickets.WebAPI.Common;
using System.Threading;

namespace MovieTickets.WebAPI.Controllers
{
    [Authorize]
    public class AccountController : ApiController
    {
        [AllowAnonymous]
        public HttpResponseMessage Options()
        {
            var response = new HttpResponseMessage();
            response.StatusCode = HttpStatusCode.OK;
            return response;
        }
        
        [AllowAnonymous]
        public bool Login(string username, string password)
        {
            //any user name and password combination will work.
            return true;
        }

        //This method will send user details back to the user
        [Authorize]
        public UserBO Get()
        {
            //The user will be authenticated and Thread.CurrentPrincipal is set in the 
            //ValidateCredentials method of AuthMessagehandler class
            //before the control reaches this action method

            MovieTicketsPrincipal currentPrincipal = Thread.CurrentPrincipal as MovieTicketsPrincipal;
            return MovieTicketsBLL.GetLoggedInUserDetails(currentPrincipal.UserName);            
        }

        [Authorize]
        public bool Post(UserBO updatedUserDetails)
        {
            //Code to update user details in the DB.
            //Since we are using hard coded values for the demo, no sae operation is done here.  
            return true;
        }



    }
}
