using System;
using GLB.DATI.Requisicao;

namespace GLB.DATI 
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            RequisicaoAPI requisicao = new RequisicaoAPI("DSSAO0198-0523"/*args[0]*/);
            requisicao.EnviaCanal();
        }
    }
}