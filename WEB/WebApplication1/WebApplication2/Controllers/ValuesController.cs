using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public string Get()
        {
            return "Hello World";
        }

        // GET api/values/5
        public string Get(int num1, int num2)
        {
            return (num1 + num2).ToString();
        }

     

        public string Get(int input)
        {
            int total = 0;
           for (int i = 0; i <= input; i++)
            {
                total += i;
            }
            return total.ToString();
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
