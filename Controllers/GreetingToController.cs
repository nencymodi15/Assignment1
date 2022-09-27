using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingToController : ApiController
    {
        /// <summary>
        /// In this number entered by User it will be displayed as Hello to {idvalue} people. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public String Get(int id)
        {
            return "Hello To " + id + " People!";
        }
    }
}
