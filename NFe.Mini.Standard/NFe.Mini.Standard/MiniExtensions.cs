using NFe.Classes;
using NFe.Danfe.Base.NFe;
using NFe.Danfe.Fast.Standard.NFe;
using NFe.Utils.NFe;
using System;
using System.IO;

namespace NFe.Mini.Standard
{
    public static class MiniExts
    {
        public static Classes.NFe CarregaNFe(string xml)
        {
            return new Classes.NFe().CarregarDeXmlString(xml);


            //nfeProc proc = null;
            //try
            //{
            //    nfeProc = new nfeProc().CarregarDeXmlString(xml);
                
            //}
            //catch //Carregar NFe ainda não transmitida à sefaz, como uma pré-visualização.
            //{
            //    //proc = new nfeProc() { NFe = new Classes.NFe().CarregarDeXmlString(xml), protNFe = new Classes.Protocolo.protNFe() };
            //    //return proc.NFe;
            //}
        }


        public static void GerarDanfePdf(Classes.NFe nfe, string arquivoPDF)
        {
            var report = GeraClasseDanfeFrNFe(nfe);
            byte[] bytes = report.ExportarPdf();
            File.WriteAllBytes(arquivoPDF, bytes);
        }

        private static DanfeFrNfe GeraClasseDanfeFrNFe(Classes.NFe nfe)
        {
            var proc = new nfeProc()
            {
                NFe = nfe,
                protNFe = new Classes.Protocolo.protNFe()
            };

            DanfeFrNfe danfe = new DanfeFrNfe(proc: proc, configuracaoDanfeNfe: new ConfiguracaoDanfeNfe()
            {
                //Logomarca = configuracaoDanfeNfe.Logomarca,
                //DuasLinhas = false,
                //DocumentoCancelado = false,
                //QuebrarLinhasObservacao = configuracaoDanfeNfe.QuebrarLinhasObservacao,
                //ExibirResumoCanhoto = configuracaoDanfeNfe.ExibirResumoCanhoto,
                //ResumoCanhoto = configuracaoDanfeNfe.ResumoCanhoto,
                //ChaveContingencia = configuracaoDanfeNfe.ChaveContingencia,
                //ExibeCampoFatura = configuracaoDanfeNfe.ExibeCampoFatura,
                //ImprimirISSQN = configuracaoDanfeNfe.ImprimirISSQN,
                //ImprimirDescPorc = configuracaoDanfeNfe.ImprimirDescPorc,
                //ImprimirTotalLiquido = configuracaoDanfeNfe.ImprimirTotalLiquido,
                //ImprimirUnidQtdeValor = configuracaoDanfeNfe.ImprimirUnidQtdeValor,
                //ExibirTotalTributos = configuracaoDanfeNfe.ExibirTotalTributos,
                //ExibeRetencoes = configuracaoDanfeNfe.ExibeRetencoes
            },
            desenvolvedor: "NOME DA SOFTWARE HOUSE",
            arquivoRelatorio: string.Empty);

            return danfe;
        }
    }
}
