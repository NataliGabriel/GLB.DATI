using System.Net.Http.Headers;
using System.Text.Json;
using GLB.DATI.Model;
using GLB.DATI.Service.Interface;
using static GLB.DATI.JsonModel.jsonModel;

namespace GLB.DATI.Service
{
    public class DatiService : IDatiService
    {
        public async Task<string> MontaJSONRegistro(globalModel model)
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
        public async Task<string> MontaJSONCanal(globalModel model)
        {
            Canal request = new Canal();

            request.numero_do_embarque = model.NR_EMBARQUE.Replace("PO#", "");
            request.declaracao_importacao_canal = model.DEC_IMP_CANAL;

            return JsonSerializer.Serialize(request);
        }
        public async Task<string> MontaJSON_CI(globalModel model)
        {
            CI request = new CI();

            request.numero_do_embarque = model.NR_EMBARQUE.Replace("PO#", "");
            request.data_da_liberacao = model.DT_ENTREGA_TRANSP.ToString("yyyy-MM-dd HH:mm:ss");
            request.data_do_desembaraco = model.DT_DESEMBARACO.ToString("yyyy-MM-dd HH:mm:ss");
            request.base64_pdf = RetornaBASE64().Result.BASE64_DI ?? "a";

            return JsonSerializer.Serialize(request);
        }
        globalModel? IDatiService.montaModel(string nReferencia)
        {
            try
            {
                BancoService bdd = new BancoService(nReferencia);
                switch (nReferencia)
                {
                    case "":
                        return bdd.BuscaRegistro();
                    case "1":
                        return bdd.BuscaCanal();
                    case "2":
                        return bdd.BuscaCI();
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
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


    }
}
