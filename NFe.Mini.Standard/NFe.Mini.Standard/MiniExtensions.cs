using NFe.Classes;
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
    }
}
