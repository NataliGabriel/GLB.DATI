using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLB.DATI.Model.jsonModel
{
    public class CourierJSON
    {
        public class Root
        {
            public string shipper_id { get; set; }
            public int courier_id { get; set; }
            public string client_reference { get; set; }
            public string tracking { get; set; }
            public string origin { get; set; }
            public string destination { get; set; }
            public string transport_type { get; set; }
            public string type { get; set; }
            public string tax { get; set; }
            public int icms_value { get; set; }
            public string conta_contabil { get; set; }
            public string unidade_custo { get; set; }
            public string centro_custo { get; set; }
            public bool rateio { get; set; }
            public List<ShipmentItem> items { get; set; }
            public List<ShipmentInvoice> invoices { get; set; }
            public string cnpj_delivery { get; set; }
            public int moeda { get; set; }
        }
        public class ShipmentItem
        {
            public string description { get; set; }
            public int quantity { get; set; }
            public int unity_value { get; set; }
            public string code { get; set; }
        }

        public class ShipmentInvoice
        {
            public string number { get; set; }
            public int increase_value { get; set; }
            public int advance_value { get; set; }
        }
    }
}
