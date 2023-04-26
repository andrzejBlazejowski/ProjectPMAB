using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using wcfService.Hlpers;
using wcfService.Model.Entities;

namespace wcfService.Model
{
    [DataContract]
    public class EmployeeForView: BaseModelForView
    {
        public string FullName { get; set; }
        public string Acronym { get; set; }
        public string Pesel { get; set; }
        public string Address { get; set; }
        public string EmployeeType { get; set; }
        public string Warehouse { get; set; }

        public EmployeeForView() { }
        public EmployeeForView(employee emp)
        {
            Id = emp.Id;
            CreatedBy = emp.CretedBy;
            ModifiedBy = emp.ModifiedBy;
            CreatedDate = emp.CreatDate;
            ModifiedDate = (DateTime)emp.ModificationDate;
            IsActive = emp.IsActive;
            FullName = emp.FirstName + ", "+ emp.MiddleName + ", " + emp.LastName;
            Acronym = emp.FirstName[0] + "." + emp.LastName;
            Pesel = emp.PeselNumber;
            Address = AddressHelper.getLongAddres(emp.Address);
            EmployeeType = emp.employeeType.name;
            Warehouse = emp.warhouse.name;
        }
    }
}