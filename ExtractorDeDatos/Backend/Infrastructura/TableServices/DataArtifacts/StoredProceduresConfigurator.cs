using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Infrastructura.TableServices.DataArtifacts
{
    public class StoredProceduresConfigurator : IStoredProceduresConfigurator
    {
        public Dictionary<string, string> procedimientoAlmacenados { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public StoredProceduresConfigurator()
        {
            procedimientoAlmacenados = new Dictionary<string, string>();
        }
        public void AddStoreProcedure(string alias, string storedProcedure)
        {
            procedimientoAlmacenados.Add(alias, storedProcedure);
        }

        public string GetProcedure(string alias)
        {
            return procedimientoAlmacenados[alias];
        }
    }
}
