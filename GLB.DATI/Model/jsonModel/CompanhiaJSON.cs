using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLB.DATI.Model.jsonModel
{
    public class CompanhiaJSON
    {
        public class Root
        {
            public string id { get; set; }
            public string type { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string site { get; set; }
        }
    }
}
