using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class CalculadoraDeResultadosTerminal : ICalculadoraDeResultados
    {
        public float Resultados { get; set; }
        
        public float CalclarResultados()
        {
            return Resultados;
        }
    }
}
