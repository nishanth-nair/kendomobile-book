using System.Security.Principal;

namespace MovieTickets.WebAPI.Common
{    
    public class MovieTicketsPrincipal: IPrincipal
    { 
           public string UserName { get; set; }
           public IIdentity Identity { get; set; }
           public bool IsInRole(string role)
           {
               if (role.Equals("user"))
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }
           //Constructor
            public MovieTicketsPrincipal(string userName)
            {
                UserName = userName;
                Identity = new GenericIdentity(userName);
            }
       
    }
}