using Domain.GeradorTextual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class GeradorTextualPDF : IGeradorTextual
    {
        public string GerarArquivo(string nomeArquivo,string textoBruto)
        {
            return new ArquivoPDF
            {
                NomeArquivo = nomeArquivo,
                Texto = textoBruto,
                Linhas = (int)(textoBruto.Length * 0.5),
                Paginas = (int)(textoBruto.Length * 0.1)
            }.ToString();
        }
    }
}
