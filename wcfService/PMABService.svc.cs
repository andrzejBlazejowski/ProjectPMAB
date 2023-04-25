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
            var db = new PMABEntities1();
            var query = from items in db.Brand select items;

            return query.ToList()
            .Select(items => new BrandForView(items))
            .ToList();
        }

        public List<CommodityForView> GetCommodities()
        {
            var db = new PMABEntities1();
            var query = from items in db.Comodity select items;

            return query.ToList()
            .Select(items => new CommodityForView(items))
            .ToList();
        }

        public List<CommodityCategoryForView> GetCommodityCategories()
        {
            var db = new PMABEntities1();
            var query = from items in db.CommodityCategory select items;

            return query.ToList()
            .Select(items => new CommodityCategoryForView(items))
            .ToList();
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
            var db = new PMABEntities1();
            var query = from items in db.employee select items;

            return query.ToList()
            .Select(items => new EmployeeForView(items))
            .ToList();
        }

        public List<EployeeTypeForView> GetEmployeeTypes()
        {
            var db = new PMABEntities1();
            var query = from items in db.employeeType select items;

            return query.ToList()
            .Select(items => new EployeeTypeForView(items))
            .ToList();
        }

        public List<StorageForView> GetStorages()
        {
            var db = new PMABEntities1();
            var query = from items in db.storage select items;

            return query.ToList()
            .Select(items => new StorageForView(items))
            .ToList();
        }

        public List<StorageSizeForView> GetStorageSizes()
        {
            var db = new PMABEntities1();
            var query = from items in db.storageSizes select items;

            return query.ToList()
            .Select(items => new StorageSizeForView(items))
            .ToList();
        }

        public List<StorageStatusForView> GetStorageStautses()
        {
            var db = new PMABEntities1();
            var query = from items in db.storageStatus select items;

            return query.ToList()
            .Select(items => new StorageStatusForView(items))
            .ToList();
        }

        public List<WarhouseForView> GetWarehouses()
        {
            var db = new PMABEntities1();
            var query = from items in db.warhouse select items;

            return query.ToList()
            .Select(items => new WarhouseForView(items))
            .ToList();
        }
    }
}
