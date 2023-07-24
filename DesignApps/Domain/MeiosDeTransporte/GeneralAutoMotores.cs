using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.MeiosDeTransporte
{
    public abstract class GeneralAutoMotores
    {
        public TipoCombustivelEnum Combustivel { get; set; }

        public string ObterCombustivel()
        {
            switch (Combustivel)
            {
                case TipoCombustivelEnum.Gasolina:
                    return "Gasolina";

                case TipoCombustivelEnum.Alcool:
                    return "Alcool";

                default:
                    return "Bicombustivel";
            }
        }
    }
}
