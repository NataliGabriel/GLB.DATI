using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLB.DATI.Model.jsonModel
{
    public class ProdutoJSON
    {
        public class Root
        {
            public string id { get; set; }
            public string shipper_id { get; set; }
            public string name { get; set; }
            public int ncm { get; set; }
            public string part_number { get; set; }
            public string factory_id { get; set; }
            public string provenance_country_bacen { get; set; }
            public object naladi_sh { get; set; }
            public object naladi_ncca { get; set; }
            public string unit_id { get; set; }
            public string application_product { get; set; }
            public string condition_product { get; set; }
            public bool in_camex { get; set; }
            public bool in_icms_reduction { get; set; }
            public string incoterm { get; set; }
            public object reduction_icms { get; set; }
            public object icms { get; set; }
            public string modalidade_despacho { get; set; }
            public string metodo_valoracao { get; set; }
            public bool mercadoria_parcelada { get; set; }
            public object net_weight { get; set; }
            public object gross_weight { get; set; }
            public string ncm_highlight { get; set; }
            public object mva { get; set; }
            public int bacen_code { get; set; }
            public string modal { get; set; }
            public string dimension { get; set; }
            public string modelo { get; set; }
            public string marca { get; set; }
            public string package_type { get; set; }
            public object medida_estatistica { get; set; }
            public string li_orgao_anuente { get; set; }
            public string li_type { get; set; }
            public bool li_exists { get; set; }
            public bool in_icms_bem_superfluo { get; set; }
            public string final_destination { get; set; }
            public string regime_tributacao_ii { get; set; }
            public string fundamento_legal_ii { get; set; }
            public string regime_tributacao_ipi { get; set; }
            public string regime_tributacao_pis_cofins { get; set; }
            public string regime_tributacao_icms { get; set; }
            public string shipper_relation_factory { get; set; }
            public object value { get; set; }
            public string cobertura_cambial { get; set; }
            public string modalidade_cambio { get; set; }
            public int motivo_sem_cobertura_cambial { get; set; }
            public object qtd_parcelas { get; set; }
            public object cfop { get; set; }
            public string name_en { get; set; }
            public string operation { get; set; }
            public object discount_certified { get; set; }
            public bool isento_afrmm { get; set; }
            public object factory_unknown_country { get; set; }
            public string group { get; set; }
            public string subgroup { get; set; }
            public string fundamento_legal_pis_cofins { get; set; }
            public object aliq_interna_st { get; set; }
            public List<Level> levels { get; set; }
            public List<Decree> decrees { get; set; }
        }
        public class Level
        {
            public string nivel { get; set; }
            public string atributo { get; set; }
            public string especificacao { get; set; }
        }

        public class Decree
        {
            public string id { get; set; }
        }
    } 
}
