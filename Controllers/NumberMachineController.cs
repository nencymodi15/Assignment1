using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    /// <summary>
    /// In this Id value will Firstly add 10 to it
    /// then Divide the Whole total By 2 and store in to div variable 
    /// then div will be multiply with 20 and store them in mul variable
    /// then Mul will be subtracted by 10 and stored into sub and sub will be displyed to user
    /// </summary>
    public class NumberMachineController : ApiController
    {
        public int Get(int id)
        {
            int sum = id + 10;
            int div = sum / 2;
            int mul = div * 20;
            int sub = mul - 10;
            return sub;
        }
    }
}
