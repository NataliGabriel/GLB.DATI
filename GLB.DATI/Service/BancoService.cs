using System;
using System.Collections.Generic;
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
        public SqlConnection _conexao = new SqlConnection(@"Data Source= localhost;
                                                            Initial Catalog=SISTEMA_GLOBAL;
                                                            Trusted_Connection=True;
                                                            MultipleActiveResultSets=True;
                                                            Connection Timeout=5"); 
        public string _nRefencia = "";
        public BancoService(string nReferencia)
        {
            _nRefencia = nReferencia;
        }
        public globalModel? BuscaRegistro()
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

            return _conexao.QueryFirst<globalModel?>(sSql);

        } 
        public globalModel? BuscaCanal()
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
        public globalModel? BuscaCI()
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
    }
}
