using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CirculoMalfeitoEComNomeBonito: ICirculoFactory
    {
        public Circulo Desenhar()
        {
            return new Circulo { Raio=5, MalFeito=true, NomeBonito=true };
        }
    }
}
