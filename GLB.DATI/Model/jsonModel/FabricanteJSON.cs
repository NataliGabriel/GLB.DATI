using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLB.DATI.Model.jsonModel
{
    public class FabricanteJSON
    {
        public class Root
        {
            public int id { get; set; }
            public string country_bacen { get; set; }
            public int shipper_id { get; set; }
            public string name { get; set; }
            public string zipcode { get; set; }
            public string address { get; set; }
            public string number { get; set; }
            public string complement { get; set; }
            public string province { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }
    }
}
