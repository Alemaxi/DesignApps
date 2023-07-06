using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Bolo
{
    public class Bolo
    {
        public MassaEnum Massa { get; set; }
        public RecheioEnum Recheio { get; set; }
        public ConfeitoEnum Confeito { get; set; }


        public string ToString()
        {
            return $"{NomeMassa()} | {NomeRecheio()} | {NomeConfeito()}";
        }

        public string NomeMassa()
        {
            switch(Massa)
            {
                case MassaEnum.simples:
                    return "simples";
                case MassaEnum.chocolate:
                    return "Chocolate";
                case MassaEnum.baunilha:
                    return "Baunilha";
                default:
                    return "Cenoura";
            }
        }

        public string NomeRecheio()
        {
            switch(Recheio)
            {
                case RecheioEnum.chocolate:
                    return "Chocolate";
                case RecheioEnum.morango:
                    return "Morango";
                default:
                    return "Maracujá";
            }
        }

        public string NomeConfeito()
        {
            switch(Confeito)
            {
                case ConfeitoEnum.simples:
                    return "Simples";
                case ConfeitoEnum.glacê:
                    return "Glacê";
                case ConfeitoEnum.chantili:
                    return "Chantili";
                default:
                    return "Pasta americana";
            }
        }
    }
}
