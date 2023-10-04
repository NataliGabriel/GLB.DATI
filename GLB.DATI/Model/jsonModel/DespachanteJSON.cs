using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLB.DATI.Model.jsonModel
{
    public class DespachanteJSON
    {
        public class Registro
        {
            public string numero_do_embarque { get; set; }
            public string declaracao_importacao { get; set; }
            public string? numero_da_transmissao_di { get; set; }
            public string data_registro_de_di { get; set; }
            public string base64_pdf_di { get; set; }
            public string base64_xml_di { get; set; }
        }
        public class Canal
        {
            public string numero_do_embarque { get; set; }
            public string declaracao_importacao_canal { get; set; }
        }
        public class CI
        {
            public string numero_do_embarque { get; set; }
            public string data_da_liberacao { get; set; }
            public string data_do_desembaraco { get; set; }
            public string base64_pdf { get; set; }
        }
    }
}
