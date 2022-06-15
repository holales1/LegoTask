using Indexer.Service.Interfaces;
using Models.Models;
using System;
using System.Linq;

namespace Indexer.Service.Implementations
{
    public class CurrencyChangeService : ICurrencyChangeService
    {
        public CurrencyChangeService()
        {

        }

        public Root changeToEuro(Root root)
        {
            var materials = root.Materials.Where(c => c.Currency != "EURO");
            foreach (Material material in materials)
            {
                checkCurrency(material);
            }
            return root;
        }

        private Material checkCurrency(Material material)
        {
            switch (material.Currency)
            {
                case "USD":
                    return USDToEuro(material);

                case "DKK":
                    return DkkToEuro(material);

                default:
                    return PoundToEuro(material);
            }
        }

        private Material DkkToEuro(Material material)
        {
            material.Currency = "EURO";
            int pricePerUnit = (int)(material.PricePerUnit*0.134433);
            material.PricePerUnit = pricePerUnit;
            return material;
        }

        private Material PoundToEuro(Material material)
        {
            material.Currency = "EURO";
            int pricePerUnit = (int)(material.PricePerUnit * 1.15);
            material.PricePerUnit = pricePerUnit;
            return material;
        }

        private Material USDToEuro(Material material)
        {
            material.Currency = "EURO";
            int pricePerUnit = (int)(material.PricePerUnit * 0.958626);
            material.PricePerUnit = pricePerUnit;
            return material;
        }
    }
}
