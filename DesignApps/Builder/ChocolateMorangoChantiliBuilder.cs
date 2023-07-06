using Domain.Bolo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ChocolateMorangoChantiliBuilder : IBoloBuilder
    {
        Bolo bolo = new Bolo();

        public void FazerMassa()
        {
            bolo.Massa = MassaEnum.chocolate;
        }

        public void Rechear()
        {
            bolo.Recheio = RecheioEnum.morango;
        }

        public void Confeitar()
        {
            bolo.Confeito = ConfeitoEnum.chantili;
        }

        public Bolo ObterBolo => bolo;
    }
}
