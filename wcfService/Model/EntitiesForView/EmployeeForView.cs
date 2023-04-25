using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcfService.Model
{
    public class EmployeeForView: BaseModelForView
    {
        public string FullName { get; set; }
        public string Acronym { get; set; }
        public int Pesel { get; set; }
        public string Address { get; set; }
        public string EmployeeType { get; set; }
        public string Warehouse { get; set; }
    }
}