using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using GLB.DATI.Model;
using GLB.DATI.Service;
using GLB.DATI.Service.Interface;
using RestSharp;

namespace GLB.DATI.Requisicao
{
    public class RequisicaoAPI
    {
        private IDatiService _service = new DatiService();

        public string _nReferencia = "";
        public string _endPoint = "";
        public RequisicaoAPI(string nReferencia, string endPoint)
        {
            _nReferencia = nReferencia;
            _endPoint = endPoint;

        }
        public async Task<string> EnviaAPI()
        {
            try
            {
                switch (_endPoint)
                {
                    case "0":
                        var model = _service.montaModel(_nReferencia, 1);
                        var requestJson = await _service.MontaJSONRegistro(model);

                        return await _service.RetornaResponse(requestJson, "di");
                    case "1":
                        model = _service.montaModel(_nReferencia, 2);
                        requestJson = await _service.MontaJSONCanal(model);

                        return await _service.RetornaResponse(requestJson, "canal");
                    case "2":
                        model = _service.montaModel(_nReferencia, 3);
                        requestJson = await _service.MontaJSON_CI(model);

                        return await _service.RetornaResponse(requestJson, "ci");
                }
                return "";
            }
            catch (Exception ex) { return ex.Message; }
        }
    }
}
