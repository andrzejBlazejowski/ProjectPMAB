using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcfService.Model.EntitiesForView
{
    public class BrandForView:BaseModelForView
    {
        public string Name { get; set; }
        public string Description{ get; set; }
        public string Address { get; set; }
    }
}