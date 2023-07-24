using Adapter;
using Domain.ConversorDeEnergias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignApps
{
    public class ConversorDeEnenergias
    {
        readonly IAdaptadorEolicoEletrico adaptador;
        readonly EnergiaElétrica energiaA;
        readonly EnergiaEolica energiaB;

        public ConversorDeEnenergias()
        {
            adaptador = new AdaptadorEolicoEletrico();

            energiaA = new EnergiaElétrica
            {
                Amperes = 100
            };

            energiaB = new EnergiaEolica
            {
                Joules = 200
            };
        }

        public void Converter()
        {
            Console.WriteLine("Conversor de energias. \n");

            Console.WriteLine($"Eolica: {energiaB.Joules} Joules | Eletrica: {adaptador.ConverterEolicaEletrica(energiaB).Amperes} Amperes");
            Console.WriteLine($"Eletrica: {energiaA.Amperes} Amperes | Eolica: {adaptador.ConverterEletricaEolica(energiaA).Joules} Joules");
        }
    }
}
