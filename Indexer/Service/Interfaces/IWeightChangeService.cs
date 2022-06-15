using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer.Service.Implementations
{
    public interface IWeightChangeService
    {
        Root changeToKilo(Root root);
    }
}
