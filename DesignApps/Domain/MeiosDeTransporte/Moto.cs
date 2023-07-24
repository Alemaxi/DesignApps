using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.MeiosDeTransporte
{
    public class Moto : GeneralAutoMotores
    {
        public string Nome { get; set; }
        public float Largura { get; set; }
        public int Cilindradas { get; set; }


        public override string ToString()
        {
            return $"{Nome} | {Largura} | {Cilindradas} | {ObterCombustivel()}";
        }
    }
}
