using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using wcfService.Model.Entities;

namespace wcfService.Model.EntitiesForView
{
    [DataContract]
    public class EployeeTypeForView : BaseModelForView
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }

        public EployeeTypeForView() { }
        public EployeeTypeForView(employeeType empType)
        {
            Id = empType.Id;
            CreatedBy = empType.CretedBy;
            ModifiedBy = empType.ModifiedBy;
            CreatedDate = empType.CreatDate;
            ModifiedDate = (DateTime)empType.ModificationDate;
            IsActive = empType.IsActive;
            Name = empType.name;
            Description = empType.description;
        }
    }
}