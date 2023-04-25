using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using wcfService.Model;
using wcfService.Model.EntitiesForView;

namespace wcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPMABService" in both code and config file together.
    [ServiceContract]
    public interface IPMABService
    {
        [OperationContract]
        List<AddresForView> GetAddresses();


        [OperationContract]
        List<BrandForView> GetBrands();

        [OperationContract]
        List<CommodityCategoryForView> GetCommodity();

        [OperationContract]
        List<CommodityCategoryForView> GetCommodity();
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
