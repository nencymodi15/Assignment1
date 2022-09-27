using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class SqureController : ApiController
    {
        /// <summary>
        /// In this User will input a number in url and the number will be multiplyed by
        /// it self to give Squre od that Number
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Get(int id)
        {
            return id * id;
        }
    }
}
