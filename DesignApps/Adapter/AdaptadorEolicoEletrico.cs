using Domain.ConversorDeEnergias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AdaptadorEolicoEletrico : IAdaptadorEolicoEletrico
    {
        public EnergiaElétrica ConverterEolicaEletrica(EnergiaEolica eolica)
        {
            return new EnergiaElétrica
            {
                Amperes = eolica.Joules * 0.4f
            };
        }

        public EnergiaEolica ConverterEletricaEolica(EnergiaElétrica eletrica)
        {
            return new EnergiaEolica
            {
                Joules = eletrica.Amperes * 0.75f
            };
        }
    }
}
