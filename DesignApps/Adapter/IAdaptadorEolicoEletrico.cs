using Domain.ConversorDeEnergias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IAdaptadorEolicoEletrico
    {
        public EnergiaElétrica ConverterEolicaEletrica(EnergiaEolica eolica);
        public EnergiaEolica ConverterEletricaEolica(EnergiaElétrica eletrica);
    }
}
