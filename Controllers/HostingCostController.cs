using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// In this first the id will be divide by fortnight(14) then
        /// we will get per fortnight value
        /// if the mod value will be zero will make it one and if it is not then add plus one so 
        /// that any days more than one will be 2 means if the days are 14 or more than 14 the value 
        /// will of mode become 2 and will be multiplied with fortnight price then we will get
        /// total price of the days which user has inputed
        /// then will count tax 
        /// and add tax to the total price
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public String Get(int id)
        {
            int fortnight = 14;
            double fortnitePrice = 5.50;
            double Taxes = 13;
            double total;
            double TotalPrice;
            double taxPrice;
            
            int mod = id / fortnight;
            if(mod == 0)
            {
                mod = 1;
            }
            else
            {
                mod = mod + 1;
            }
            total = fortnitePrice * mod;
            taxPrice = total * (Taxes / 100);
            TotalPrice = total + taxPrice;
            return "“1 fortnights at $" + fortnitePrice + "/FN = $" + total + "CAD, HST 13 % =" + taxPrice + "CAD, Total = $" + TotalPrice + "CAD" ;
        }
    }
}
