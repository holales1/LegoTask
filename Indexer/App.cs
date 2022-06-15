using Indexer.Database;
using Indexer.Service.Implementations;
using Indexer.Service.Interfaces;
using Models.Models;
using System;

namespace Indexer
{
    public class App
    {
        public App()
        {
        }

        public void Run()
        {
            DatabaseLego db = new DatabaseLego();
            IReadJsonService readJsonService = new ReadJsonService();
            ITemperatureService temperatureService = new TemperatureService();
            ICurrencyChangeService currencyChangeService = new CurrencyChangeService();
            IWeightChangeService weightChangeService = new WeightChangeService();
            Console.WriteLine("Starting insert in database");

            Root root = readJsonService.GetAllData();
            temperatureService.changeToCelcius(root);
            currencyChangeService.changeToEuro(root);
            weightChangeService.changeToKilo(root);
            db.InsertAllVendors(root);
            db.InsertAllMaterials(root);
            Console.WriteLine("Done");
        }
    }
}
