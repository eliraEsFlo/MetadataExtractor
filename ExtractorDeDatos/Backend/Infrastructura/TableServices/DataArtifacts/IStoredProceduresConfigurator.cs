using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Infrastructura.TableServices.DataArtifacts
{
    public interface IStoredProceduresConfigurator
    {
        Dictionary<string, string> procedimientoAlmacenados { get; set; }
        string GetProcedure(string alias);

        void AddStoreProcedure(string alias, string storedProcedure);
    }
}
