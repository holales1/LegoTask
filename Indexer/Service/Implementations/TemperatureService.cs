using Indexer.Service.Interfaces;
using Models.Models;
using System.Linq;

namespace Indexer.Service.Implementations
{
    public class TemperatureService : ITemperatureService
    {
        public TemperatureService()
        {

        }

        public Root changeToCelcius(Root root)
        {
            var materials = root.Materials.Where(c => c.TempUnit!="C");
            foreach (Material material in materials)
            {
                FarenheitToCelsius(material);
            }
            return root;
        }

        private Material FarenheitToCelsius(Material material)
        {
            material.TempUnit = "C";
            int meltingPointCelsius = (material.MeltingPoint - 32) * 5 / 9;
            material.MeltingPoint = meltingPointCelsius;
            return material;
        }
    }
}
