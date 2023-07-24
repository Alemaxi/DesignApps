using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.MeiosDeTransporte
{
    public class Carro : GeneralAutoMotores
    {
        public string Nome { get; set; }
        public float Largura { get; set; }
        public float Comprimento { get; set; }
        public int QuantidadePortas { get; set; }


        public override string ToString()
        {
            return $"{Nome} | { Largura} | { Comprimento } | { QuantidadePortas } | {ObterCombustivel()}";
        }
    }
}
