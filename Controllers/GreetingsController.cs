using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingsController : ApiController
    {
        /// <summary>
        /// This Code will display Helloworld To User By post Method
        /// </summary>
        /// <returns></returns>
        public String Post()
        {
            return "Hello World";
        }
    }
}
