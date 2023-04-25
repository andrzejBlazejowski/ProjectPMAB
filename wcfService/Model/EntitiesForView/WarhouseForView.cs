using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wcfService.Model.Entities;

namespace wcfService.Model.EntitiesForView
{
    public class WarhouseForView:BaseModelForView
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public WarhouseForView() { }
        public WarhouseForView(warhouse warhouse)
        {
            Id = warhouse.Id;
            CreatedBy = warhouse.CretedBy;
            ModifiedBy = warhouse.ModifiedBy;
            CreatedDate = warhouse.CreatDate;
            ModifiedDate = (DateTime)warhouse.ModificationDate;
            IsActive = warhouse.IsActive;
            Name = warhouse.name;
            Description = warhouse.description;
        }
    }
}