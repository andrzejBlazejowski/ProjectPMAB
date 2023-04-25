using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wcfService.Model.Entities;

namespace wcfService.Hlpers
{
    public class AddressHelper
    {
        public static string getShortAddres(Address addr)
        {
            return addr.StreetName + ", " + addr.StreetNumber + ", " + addr.City;
        }

        public static string getLongAddres(Address addr)
        {
            return addr.StreetName + ", " + addr.StreetNumber + "\n" + addr.City + ", " + addr.PostalCode + " \n" + addr.Country + ", "+ addr.State;
        }
    }
}