using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignApps
{
    public class GeradorTextual
    {
        public IGeradorTextual geradorTXT;
        public IGeradorTextual geradorPDF;

        public GeradorTextual()
        {
            geradorTXT = new GeradorTextualTXT();
            geradorPDF = new GeradorTextualPDF();
        }

        public void gerarArquivos()
        {
            Console.WriteLine("Bridge \n");

            Console.WriteLine(geradorTXT.GerarArquivo("Arquivo TXT","Esta é a representação de um txt"));

            Console.WriteLine(geradorPDF.GerarArquivo("Arquivo PDF","Esta é a representação de um pdf"));
        }
    }
}
