﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// In this code whatever value will be inputed it will be added with ten 
        /// and then it will be displayed in the screen.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
