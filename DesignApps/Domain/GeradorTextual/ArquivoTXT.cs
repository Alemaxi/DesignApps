using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.GeradorTextual
{
    public class ArquivoTXT
    {
        public string NomeArquivo { get; set; }
        public string Texto { get; set; }
        public int Linhas { get; set; }


        public override string ToString()
        {
            return $"{NomeArquivo} | {Texto} | {Linhas}";
        }
    }
}
