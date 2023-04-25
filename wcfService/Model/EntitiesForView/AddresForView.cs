using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Linq;
using wcfService.Model.Entities;

namespace wcfService.Model
{
    [DataContract]
    public class AddresForView: BaseModelForView
    {
        [DataMember]
        public string StreetName { get; set; }
        [DataMember]
        public string StreetNumber { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string State { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string PostalCode { get; set; }
        public AddresForView() { }
        public AddresForView(Address addr)
        {
            Id = addr.Id;
            CreatedBy = addr.CretedBy;
            ModifiedBy = addr.ModifiedBy;
            CreatedDate = addr.CreatDate;
            ModifiedDate = (DateTime)addr.ModificationDate;
            IsActive = addr.IsActive;
            StreetName = addr.StreetName;
            StreetNumber = addr.StreetNumber;
            City = addr.City;
            State = addr.State;
            Country = addr.Country;
            PostalCode = addr.PostalCode;
        }
    }
}