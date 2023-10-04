using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLB.DATI.Model.jsonModel
{
    public class PedidoJSON
    {
        public class Root
        {
            public string id { get; set; }
            public string shipper_id { get; set; }
            public string file_id { get; set; }
            public string incoterm { get; set; }
            public string number { get; set; }
            public List<POItem> p_o_items { get; set; }
            public int bacen_code { get; set; }
            public DateTime ready_delivery_date { get; set; }
            public string cost_center { get; set; }
            public List<POInvoice> po_invoices { get; set; }
        }
        public class POItem
        {
            public string id { get; set; }
            public string product_id { get; set; }
            public int quantity { get; set; }
            public decimal unity_cost { get; set; }
            public decimal net_weight { get; set; }
            public string cobertura_cambial { get; set; }
            public string modalidade_cambio { get; set; }
            public int motivo_sem_cobertura_cambial { get; set; }
            public int qtd_parcelas { get; set; }
            public string invoice_number { get; set; }
        }

        public class POInvoice
        {
            public string invoice_number { get; set; }
            public int invoice_increase { get; set; }
            public int invoice_advance { get; set; }
        }

        public class PurchaseOrder
        {
            public string id { get; set; }
            public string shipper_id { get; set; }
            public string file_id { get; set; }
            public string incoterm { get; set; }
            public string number { get; set; }
            public List<POItem> p_o_items { get; set; }
            public int bacen_code { get; set; }
            public DateTime ready_delivery_date { get; set; }
            public string cost_center { get; set; }
            public List<POInvoice> po_invoices { get; set; }
        }
    }
}
