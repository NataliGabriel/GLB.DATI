using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using GLB.DATI.Model;

namespace GLB.DATI.Service
{
    public class BancoService
    {
        public static string ipGlobal = ConfigurationManager.AppSettings["ipConexao"];
        public static string SenhaGlobal = ConfigurationManager.AppSettings["pass"] == "k" ? "kurumin" : "S0lut@3e4r";

        public SqlConnection _conexao = new SqlConnection(@$"Data Source= {ipGlobal};
                                                            Initial Catalog=SISTEMA_GLOBAL;
                                                            Persist Security Info=True;
                                                            User ID=global;
                                                            Password={SenhaGlobal};
                                                            MultipleActiveResultSets=True;
                                                            Connection Timeout=5");
        public string _nRefencia = "";
        public BancoService(string nReferencia)
        {
            _nRefencia = nReferencia;
        }
        public globalModel? BuscaRegistro()
        {
            try
            {


                string sSql = @$"SELECT 
                            	NR_DI AS DEC_IMP, 
                            	DATA_REG_DI_SISCOMEX AS DT_REGISTRO, 
                            	DT_NR_TRANS_REG AS NR_TRANSMISSAO, 
                            	S_REFERENCIA AS NR_EMBARQUE
                            FROM 
                            	V_BROKER 
                            		WHERE 
                            			N_REFERENCIA = '{_nRefencia}'";

                return _conexao.QueryFirst<globalModel>(sSql);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return null; }
        }
        public globalModel? BuscaCanal()
        {
            try
            {
                string sSql = @$"SELECT
                                CASE
                                    WHEN CANAL = 'D' THEN 'Verde'
                                    WHEN CANAL = 'L' THEN 'Amarelo'
                                    WHEN CANAL = 'V' THEN 'Vermelho'
                                    WHEN CANAL = 'C' THEN 'Cinza'
                                    ELSE CANAL
                                END AS DEC_IMP_CANAL,
                                S_REFERENCIA AS NR_EMBARQUE
                            FROM
                                V_BROKER
                            		WHERE 
                            			N_REFERENCIA = '{_nRefencia}'";

                return _conexao.QueryFirst<globalModel?>(sSql);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return null; }
        }
        public globalModel? BuscaCI()
        {
            try
            {
                string sSql = @$"SELECT
                                S_REFERENCIA AS NR_EMBARQUE,
								DT_ENTREGA_TRANSP,
								DT_DESEMBARACO
                            FROM
                                V_BROKER
                            		WHERE 
                            			N_REFERENCIA ='{_nRefencia}'";

                return _conexao.QueryFirst<globalModel?>(sSql);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return null; }
        }
    }
}
