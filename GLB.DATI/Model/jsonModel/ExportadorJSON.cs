using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLB.DATI.Model.jsonModel
{
    public class ExportadorJSON
    {
        public class Root
        {
            public string id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string site { get; set; }
            public string country_bacen { get; set; }
            public string zipcode { get; set; }
            public string street { get; set; }
            public string number { get; set; }
            public string complement { get; set; }
            public string province { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string phone { get; set; }
        }
    }
}
