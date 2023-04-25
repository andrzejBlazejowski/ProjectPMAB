using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcfService.Model
{
    public class AddresForView: BaseModelForView
    {
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
    }
}