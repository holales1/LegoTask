using Models.Models;

namespace Indexer.Service.Interfaces
{
    public interface ITemperatureService
    {
        Root changeToCelcius(Root root);
    }
}
