using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLB.DATI.Model.jsonModel
{
    public class DespesasJSON
    {
        public class Root
        {
            public string id { get; set; }
            public string file_id { get; set; }
            public string payment_term_id { get; set; }
            public string provider_company_type { get; set; }
            public string provider_company_code { get; set; }
            public int category_id { get; set; }
            public object description { get; set; }
            public int currency { get; set; }
            public decimal value { get; set; }
            public object rate { get; set; }
            public object payment_date { get; set; }
        }
    }
}
