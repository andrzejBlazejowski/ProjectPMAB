using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace wcfService.Model
{
    [DataContract]
    public class BaseModelForView
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
        [DataMember]
        public string CreatedBy { get; set; }
        [DataMember]
        public string ModifiedBy { get; set; }
        [DataMember]
        public DateTime ModifiedDate { get; set; }
        [DataMember]
        public DateTime CreatedDate { get; set; }
    }
}