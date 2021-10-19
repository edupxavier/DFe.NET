using NFe.Mini.Standard;
using System;
using System.IO;

namespace Teste
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
                NFe.Classes.NFe nfe = null;
                try
                {
                    string xml = File.ReadAllText(arq);
                    Console.WriteLine($" - {Path.GetFileName(arq)}");
                    nfe = MiniExts.CarregaNFe(xml);
                    ok++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($" - {Path.GetFileName(arq)}: ERRO");
                    Console.WriteLine($"   {ex.GetType().Name}: {ex.Message}");
                    erro++;
                    continue;
                }



                string arquivoPDF = Path.Combine(dir, "Danfe", Path.GetFileNameWithoutExtension(arq) + ".pdf");
                try
                {
                    MiniExts.GerarDanfePdf(nfe, arquivoPDF);
                    Console.WriteLine($"   {Path.GetFileName(arquivoPDF)}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"   Erro gerando PDF:");
                    Console.WriteLine($"   {ex.GetType().Name}: {ex.Message}");
                    erro++;
                }


            }
            Console.WriteLine($"\n\n{arqs.Length} arquivos, {ok} ok, {erro} com erro");
        }

    }
}

