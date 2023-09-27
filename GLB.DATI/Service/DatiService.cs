using System;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Xml;
using System.Xml.Linq;
using GLB.DATI.Model;
using GLB.DATI.Service.Interface;
using Newtonsoft.Json.Linq;
using static GLB.DATI.JsonModel.jsonModel;

namespace GLB.DATI.Service
{
    public class DatiService : IDatiService
    {
        public static string urlBase = "https://external.dati-api.com/teste/files/";
        public static string tokenAPI = "vTyu1k4Iyi3jxgyrCk9pR74BveA8UL3t3VzHRWV6";
        public async Task<string> MontaJSONRegistro(globalModel model)
        {
            try
            {
                Registro request = new Registro();

                request.numero_do_embarque = model.NR_EMBARQUE.Replace("PO#", "");
                request.declaracao_importacao = model.DEC_IMP;
                request.numero_da_transmissao_di = model.NR_TRANSMISSAO ?? "";
                request.data_registro_de_di = model.DT_REGISTRO.ToString("yyyy-MM-dd HH:mm:ss");
                request.base64_pdf_di = RetornaBASE64().Result.BASE64_DI ?? "a";
                request.base64_xml_di = "PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiPz4=";

                return JsonSerializer.Serialize(request);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return null; }
        }
        public async Task<string> MontaJSONCanal(globalModel model)
        {
            try
            {
                Canal request = new Canal();

                request.numero_do_embarque = model.NR_EMBARQUE.Replace("PO#", "");
                request.declaracao_importacao_canal = model.DEC_IMP_CANAL;

                return JsonSerializer.Serialize(request);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return null; }
        }
        public async Task<string> MontaJSON_CI(globalModel model)
        {
            try
            {
                CI request = new CI();

                request.numero_do_embarque = model.NR_EMBARQUE.Replace("PO#", "");
                request.data_da_liberacao = model.DT_ENTREGA_TRANSP.ToString("yyyy-MM-dd HH:mm:ss");
                request.data_do_desembaraco = model.DT_DESEMBARACO.ToString("yyyy-MM-dd HH:mm:ss");
                request.base64_pdf = RetornaBASE64().Result.BASE64_DI ?? "a";

                return JsonSerializer.Serialize(request);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return null; }
        }
        globalModel? IDatiService.montaModel(string nReferencia, int i = 0)
        {
            try
            {
                switch (i)
                {
                    case 1:
                        BancoService bddRegistro = new BancoService(nReferencia);
                        return bddRegistro.BuscaRegistro();
                    case 2:
                        BancoService bddCanal = new BancoService(nReferencia);
                        return bddCanal.BuscaCanal();
                    case 3:
                        BancoService bddCI = new BancoService(nReferencia);
                        return bddCI.BuscaCI();
                    default:
                        return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public async Task<globalModel> RetornaBASE64()
        {
            try
            {
                globalModel model = new globalModel();
                // Abre o OpenFileDialog para selecionar um arquivo PDF
                var openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                openFileDialog.Title = "Selecione um arquivo PDF/XML";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lê o arquivo PDF selecionado
                    string FilePath = openFileDialog.FileName;
                    byte[] Bytes = File.ReadAllBytes(FilePath);
                    model.BASE64_DI = Convert.ToBase64String(Bytes);
                    return model;
                }
                else
                {
                    ReferenceEquals(model, new Exception());
                    Environment.Exit(0);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<string?> RetornaResponse(string requestJson, string endPoint)
        {
            try
            {
                HttpClient _client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Put, $"{urlBase}{endPoint}");
                _client.DefaultRequestHeaders.Clear();
                _client.DefaultRequestHeaders.Add("X-Api-Key", tokenAPI);

                var content = new StringContent(requestJson, null, "application/json");
                request.Content = content;
                var response = _client.SendAsync(request);

                Task.WaitAll();

                return JObject.Parse(response.Result.Content.ReadAsStringAsync().Result).ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return null; }
        }
    }
}
