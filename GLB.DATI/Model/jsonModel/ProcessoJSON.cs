using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLB.DATI.Model.jsonModel
{
    public class ProcessoJSON
    {
        public class Root
        {
            public string id { get; set; }
            public object carriage_id { get; set; }
            public string cnpj { get; set; }
            public string cnpj_delivery { get; set; }
            public string agent_destination_id { get; set; }
            public string origin { get; set; }
            public string destination { get; set; }
            public string transport_type { get; set; }
            public string client_reference { get; set; }
            public object container { get; set; }
            public string arrival_date_preview { get; set; }
            public string departure_date_preview { get; set; }
            public object second_arrival_date_preview { get; set; }
            public object second_departure_date_preview { get; set; }
            public string declaracao_date_preview { get; set; }
            public string release_date_preview { get; set; }
            public string delivery_date_preview { get; set; }
            public string receipt_nf_date_preview { get; set; }
            public List<PurchaseOrder> purchase_orders { get; set; }
            public int customer_id { get; set; }
            public int office_id { get; set; }
            public string dati_number { get; set; }
            public int manifesto_type { get; set; }
            public int model_id { get; set; }
        }
        public class PurchaseOrderItem
        {
            public string id { get; set; }
            public string product_id { get; set; }
            public string shipper_id { get; set; }
            public int quantity { get; set; }
            public decimal unity_cost { get; set; }
            public int net_weight { get; set; }
            public int cobertura_cambial { get; set; }
        }

        public class PurchaseOrder
        {
            public string id { get; set; }
            public string number { get; set; }
            public string shipper_id { get; set; }
            public string bacen_code { get; set; }
            public string incoterm { get; set; }
            public object invoice_number { get; set; }
            public object ready_delivery_date { get; set; }
            public string cubagem { get; set; }
            public string cost_center { get; set; }
            public List<PurchaseOrderItem> p_o_items { get; set; }
        }
    }
}
