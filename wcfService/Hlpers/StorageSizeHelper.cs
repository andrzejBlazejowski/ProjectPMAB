using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wcfService.Model.Entities;

namespace wcfService.Hlpers
{
    public class StorageSizeHelper
    {
        public static string getStorageDimensions(storageSizes storage)
        {
            return storage.x + "x" + storage.y + "x" + storage.z;
        }
        public static string getVerboseStorageDimensions(storageSizes storage)
        {
            return "width: " + storage.x + ", height: " + storage.y + ", depth: " + storage.z;
        }
        public static int getWidth(storageSizes storage)
        {
            return (int)storage.x;
        }
        public static int getHeight(storageSizes storage)
        {
            return (int)storage.y;
        }
        public static int getDepth(storageSizes storage)
        {
            return (int)storage.z;
        }
    }
}