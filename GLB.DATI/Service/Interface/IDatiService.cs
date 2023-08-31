using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GLB.DATI.JsonModel;
using GLB.DATI.Model;

namespace GLB.DATI.Service.Interface
{
    public interface IDatiService
    {
        public Task<string> MontaJSONRegistro(globalModel model);
        public Task<string> MontaJSONCanal(globalModel model);
        public Task<string> MontaJSON_CI(globalModel model);
        public globalModel montaModel(string nReferencia);
        public Task<globalModel> RetornaBASE64();

    }
}
