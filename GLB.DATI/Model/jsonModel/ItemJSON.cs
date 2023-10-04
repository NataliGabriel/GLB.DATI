using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLB.DATI.Model.jsonModel
{
    public class ItemJSON
    {
        public class Root
        {
            public string id { get; set; }
            public string purchase_order_id { get; set; }
            public string product_id { get; set; }
            public int quantity { get; set; }
            public int unity_cost { get; set; }
            public int net_weight { get; set; }
            public string cobertura_cambial { get; set; }
            public string modalidade_cambio { get; set; }
            public int motivo_sem_cobertura_cambial { get; set; }
            public int qtd_parcelas { get; set; }
            public string invoice_number { get; set; }
        }
    }
}
