using GLB.DATI.Model;

namespace GLB.DATI.Service.Interface
{
    public interface IDatiService
    {
        public Task<string> MontaJSONRegistro(globalModel model);
        public Task<string> MontaJSONCanal(globalModel model);
        public Task<string> MontaJSON_CI(globalModel model);
        public globalModel montaModel(string nReferencia, int i = 0);
        public Task<globalModel> RetornaBASE64();
        public Task<string?> RetornaResponse(string requestJson, string endPoint);
    }
}
