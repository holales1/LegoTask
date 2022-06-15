using Indexer.Service.Interfaces;
using Models.Models;
using Newtonsoft.Json;
using System.IO;

namespace Indexer.Service.Implementations
{
    public class ReadJsonService : IReadJsonService
    {
        public ReadJsonService()
        {

        }

        public Root GetAllData()
        {
            string jsonRoot = File.ReadAllText(@".\material_vendor_data.json");
            Root myDeserializedRoot = JsonConvert.DeserializeObject<Root>(jsonRoot);
            return myDeserializedRoot;
        }
    }
}
