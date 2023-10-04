using System;
using GLB.DATI.Requisicao;

namespace GLB.DATI 
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                //var process = args[0];
                //var action = args[1];
                Console.WriteLine("Iniciando processo: ");
                //Console.WriteLine(args[0]);

                RequisicaoAPI requisicao = new RequisicaoAPI("DSSAO0126-0423", "0"/*process, action*/);

                var response = requisicao.EnviaAPI().Result;

                MessageBox.Show(response == "" ? "Nenhuma resposta foi recebida!" : response, "RESULTADO", MessageBoxButtons.OK);

                Console.ReadKey();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}