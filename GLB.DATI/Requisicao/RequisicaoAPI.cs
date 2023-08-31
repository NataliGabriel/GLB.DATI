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
        public string pathAPI = "https://external.dati-api.com/teste";
        private IDatiService _service = new DatiService();
        public string _nReferencia = "";
        public HttpClient _client = new HttpClient();
        public RequisicaoAPI(string nReferencia)
        {
            _nReferencia = nReferencia;
        }
        public async Task<bool> EnviaRegistro()
        {
            try
            {
                var model = _service.montaModel(_nReferencia);
                var requestJson = await _service.MontaJSONRegistro(model);

                var request = new HttpRequestMessage(HttpMethod.Put, "https://external.dati-api.com/teste/files/di");
                _client.DefaultRequestHeaders.Clear();
                _client.DefaultRequestHeaders.Add("X-Api-Key", "6Ujm3CezUH8B6XIShRmRnaBvackdBeL6aVwOJ1Ap");

                var content = new StringContent(requestJson, null, "application/json");
                request.Content = content;
                var response = _client.SendAsync(request);
                Task.WaitAll();

                Console.WriteLine(await response.Result.Content.ReadAsStringAsync());
                return true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, ""); return false; }
        }
        public async Task<bool> EnviaCanal()
        {
            try
            {
                var model = _service.montaModel(_nReferencia);
                var requestJson = await _service.MontaJSONCanal(model);

                var request = new HttpRequestMessage(HttpMethod.Put, "https://external.dati-api.com/teste/files/canal");
                _client.DefaultRequestHeaders.Clear();
                _client.DefaultRequestHeaders.Add("X-Api-Key", "6Ujm3CezUH8B6XIShRmRnaBvackdBeL6aVwOJ1Ap");

                var content = new StringContent(requestJson, null, "application/json");
                request.Content = content;
                var response = _client.SendAsync(request);
                Task.WaitAll();
                var responseTxt = await response.Result.Content.ReadAsStringAsync();
                Console.WriteLine(response.Status);

                return true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, ""); return false; }
        }
        public async Task<bool> EnviaCI()
        {
            try
            {
                var model = _service.montaModel(_nReferencia);
                var requestJson = await _service.MontaJSON_CI(model);

                var request = new HttpRequestMessage(HttpMethod.Put, "https://external.dati-api.com/teste/files/ci");
                _client.DefaultRequestHeaders.Clear();
                _client.DefaultRequestHeaders.Add("X-Api-Key", "6Ujm3CezUH8B6XIShRmRnaBvackdBeL6aVwOJ1Ap");

                var content = new StringContent(requestJson, null, "application/json");
                request.Content = content;
                var response = _client.SendAsync(request);
                Task.WaitAll();
                var responseTxt = await response.Result.Content.ReadAsStringAsync();
                Console.WriteLine(response.Status);

                return true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, ""); return false; }
        }
    }
}
