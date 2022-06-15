using Models.Models;
using System.Collections.Generic;

namespace LegoForm.Cache
{
    public class CacheLego
    {
        private List<Material> materials;
        private List<Vendor> vendors;
        public CacheLego(List<Vendor> vendors, List<Material> materials)
        {
            this.vendors = vendors;
            this.materials = materials;
        }

        public List<Material> GetMaterials()
        {
            return this.materials;
        }

        public List<Vendor> GetVendors()
        {
            return this.vendors;
        }
    }
}
