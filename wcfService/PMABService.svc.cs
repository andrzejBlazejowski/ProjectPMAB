using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using wcfService.Model;
using wcfService.Model.Entities;
using wcfService.Model.EntitiesForView;

namespace wcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PMABService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PMABService.svc or PMABService.svc.cs at the Solution Explorer and start debugging.
    public class PMABService : IPMABService
    {
        public List<AddresForView> GetAddresses()
        {
            var db = new PMABEntities1();
            var query = from address in db.Address select address;

            return query.ToList()
            .Select(addr => new AddresForView(addr))
            .ToList();
        }

        public List<BrandForView> GetBrands()
        {
            throw new NotImplementedException();
        }

        public List<CommodityForView> GetCommodities()
        {
            throw new NotImplementedException();
        }

        public List<CommodityCategoryForView> GetCommodityCategories()
        {
            throw new NotImplementedException();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<EmployeeForView> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public List<EployeeTypeForView> GetEmployeeTypes()
        {
            throw new NotImplementedException();
        }

        public List<StorageForView> GetStorages()
        {
            throw new NotImplementedException();
        }

        public List<StorageSizeForView> GetStorageSizes()
        {
            throw new NotImplementedException();
        }

        public List<StorageStatusForView> GetStorageStautses()
        {
            throw new NotImplementedException();
        }

        public List<WarhouseForView> GetWarehouses()
        {
            throw new NotImplementedException();
        }
    }
}
