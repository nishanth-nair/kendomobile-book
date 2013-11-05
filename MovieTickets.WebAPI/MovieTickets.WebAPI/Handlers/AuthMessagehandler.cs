using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Web;
using MovieTickets.WebAPI.Common;

namespace MovieTickets.WebAPI.Handlers
{
    public class AuthMessagehandler : DelegatingHandler
    {       
                
        private string _userName;
        
        //Capturing the incoming request by overriding the SendAsync method
        protected override System.Threading.Tasks.Task<HttpResponseMessage> SendAsync(
           HttpRequestMessage request,
           CancellationToken cancellationToken)
        {
            //if the credentials are validated, set CurrentPrincipal and Current.User
            if (ValidateCredentials(request.Headers.Authorization))
            {
                Thread.CurrentPrincipal = new MovieTicketsPrincipal(_userName);
                HttpContext.Current.User = new MovieTicketsPrincipal(_userName);
            }

            //Execute base.SendAsync to execute default actions and once it is completed, 
            //capture the response object and add WWW-Authenticate header if the request was marked as unauthorized.
             return base.SendAsync(request, cancellationToken)
                .ContinueWith(task =>
                                  {
                                      HttpResponseMessage response = task.Result;
                                      if (response.StatusCode == HttpStatusCode.Unauthorized
                                          && !response.Headers.Contains("WWW-Authenticate"))
                                      {
                                          response.Headers.Add("WWW-Authenticate", "Basic");
                                      }
                                      return response;
                                  });
        }       

        //Method to validate credentials from Authorization header value
        private bool ValidateCredentials(AuthenticationHeaderValue authenticationHeaderVal)
        {
            if ( authenticationHeaderVal!= null && !String.IsNullOrEmpty(authenticationHeaderVal.Parameter))
            {

                string[] decodedCredentials = Encoding.ASCII.GetString(
                                                Convert.FromBase64String(
                                                    authenticationHeaderVal.Parameter))
                                                    .Split(new[] { ':' });

                //now decodedCredentials[0] will contain username and decodedCredentials[2] will contain password.
                //You need to implement your business logic to verify credentials here. For simplicity, we are hardcoding user name and password here.
                string decodedUserName = decodedCredentials[0], decodedPassword = decodedCredentials[1];
                if ((decodedUserName.Equals("username") || decodedUserName.Equals("username1"))&& (decodedPassword.Equals("password") || decodedPassword.Equals("password1")))
                {
                    _userName = decodedUserName;
                    return true;//request authenticated.
                }
            }
            return false;//request not authenticated.
        }



    }
}