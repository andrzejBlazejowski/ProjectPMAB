using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcfService.Model
{
    public class BaseModelForView
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedTime { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}