using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;

namespace MovieTickets.WebAPI.Controllers
{
    public class ValuesController : ApiController
    {
         //GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }
                
        public HttpResponseMessage GetImage()
        {
            byte[] bytes = System.IO.File.ReadAllBytes(
                HttpContext.Current.Server.MapPath("~/Content/Kendo.png"));
            var result = new HttpResponseMessage(HttpStatusCode.OK);
            result.Content = new ByteArrayContent(bytes);            
            result.Content.Headers.ContentType = new MediaTypeHeaderValue("image/png");
            
            return result;
        }
        
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}