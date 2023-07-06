using Domain.Bolo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class BaunilhaChocolateSimplesBuilder : IBoloBuilder
    {
        Bolo bolo = new Bolo();

        public void FazerMassa()
        {
            bolo.Massa = MassaEnum.baunilha;
        }

        public void Rechear()
        {
            bolo.Recheio = RecheioEnum.chocolate;
        }

        public void Confeitar()
        {
            bolo.Confeito = ConfeitoEnum.simples;
        }

        public Bolo ObterBolo => bolo;
    }
}
