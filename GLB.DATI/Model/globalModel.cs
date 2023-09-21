using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLB.DATI.Model
{
    public class globalModel
    {
        /// <summary>
        /// Código do Embarque com Ref. Cliente
        /// </summary>
        public string NR_EMBARQUE { get; set; }
        /// <summary>
        /// Código da Declaração de Importação com Ref. Cliente
        /// </summary>
        public string DEC_IMP { get; set; }
        /// <summary>
        /// Número da tranmissão da D.I
        /// </summary>
        public string? NR_TRANSMISSAO { get; set; }
        /// <summary>
        /// Data do Registro de D.I
        /// </summary>
        public DateTime DT_REGISTRO { get; set; } = Convert.ToDateTime("2022-01-25 00:00:00");
        /// <summary>
        /// Arquivo em base64
        /// </summary>
        public string BASE64_DI { get; set; }
        /// <summary>
        /// Tipo de Canal do Embarque	
        /// </summary>
        public string DEC_IMP_CANAL { get; set; }
        /// <summary>
        /// 	Data da Liberação
        /// </summary>
        public DateTime DT_ENTREGA_TRANSP { get; set; }
        /// <summary>
        /// Data do Desembaraço
        /// </summary>
        public DateTime DT_DESEMBARACO { get; set; }
    }
}
