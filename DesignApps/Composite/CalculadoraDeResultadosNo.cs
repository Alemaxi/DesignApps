using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class CalculadoraDeResultadosNo : ICalculadoraDeResultados
    {
        public float Resultados { get; set; }

        public List<ICalculadoraDeResultados> Descendentes { get; set; } = new List<ICalculadoraDeResultados>();

        public float CalclarResultados()
        {
            return Resultados + Descendentes.Sum(x =>  x.CalclarResultados() );
        }
    }
}
