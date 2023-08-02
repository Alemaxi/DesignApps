using Domain.GeradorTextual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class GeradorTextualTXT : IGeradorTextual
    {
        public string GerarArquivo(string nomeArquivo,string textoBruto)
        {
            return new ArquivoTXT
            {
                NomeArquivo = nomeArquivo,
                Texto = textoBruto,
                Linhas = (int)(textoBruto.Length * 0.5)
            }.ToString(); throw new NotImplementedException();
        }
    }
}
