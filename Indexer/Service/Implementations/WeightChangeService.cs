using Models.Models;
using System.Linq;

namespace Indexer.Service.Implementations
{
    public class WeightChangeService : IWeightChangeService
    {
        public WeightChangeService()
        {

        }

        public Root changeToKilo(Root root)
        {
            var materials = root.Materials.Where(c => c.Unit != "kg");
            foreach (Material material in materials)
            {
                PoundToKilo(material);
            }
            return root;
        }

        private Material PoundToKilo(Material material)
        {
            material.Unit = "kg";
            int pricePerUnit = (int)(material.PricePerUnit * 2.205);
            material.PricePerUnit = pricePerUnit;
            return material;
        }
    }
}
