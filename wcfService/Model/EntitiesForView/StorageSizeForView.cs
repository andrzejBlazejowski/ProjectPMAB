using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcfService.Model.EntitiesForView
{
    public class StorageSizeForView:BaseModelForView
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public int depth { get; set; }
    }
}