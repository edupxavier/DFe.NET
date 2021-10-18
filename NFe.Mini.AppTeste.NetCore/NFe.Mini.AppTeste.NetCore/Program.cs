using NFe.Mini.Standard;
using System;
using System.IO;

namespace NFe.Mini.AppTeste.NetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = @"C:\Temp\xml\Autorizada\Transportadas";
            var arqs = Directory.GetFiles(dir, "*.xml");

            Console.WriteLine($"Processando {arqs.Length} no diretório {dir}...");

            int ok = 0, erro = 0;
            foreach (var arq in arqs)
            {
                try
                {
                    string xml = File.ReadAllText(arq);
                    Console.WriteLine($" - {Path.GetFileName(arq)}");
                    ok++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($" - {Path.GetFileName(arq)}: ERRO");
                    Console.WriteLine($"   {ex.GetType().Name}: {ex.Message}");
                    erro++;
                }
            }
            Console.WriteLine($"\n\n{arqs} arquivos, {ok} ok, {erro} com erro");
        }
    }
}
