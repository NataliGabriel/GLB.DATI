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
                Console.Write("Iniciando processo ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("DSSAO0024-0523");
                Console.ResetColor();
                RequisicaoAPI requisicao = new RequisicaoAPI("DSSAO0024-0523", "1"/*args[0]*/);

                var response = requisicao.EnviaAPI().Result;
                MessageBox.Show(response, "RESULTADO", MessageBoxButtons.OK);

                Console.ReadKey();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}