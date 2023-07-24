using Domain.MeiosDeTransporte;

namespace FactoryMethod
{
    public static class SimuladorDeMeioDeTransporte
    {
        public static Carro GerarCarro()
        {
            var carro = new Carro
            {
                Largura = 2.5f,
                Comprimento = 4,
                Combustivel = TipoCombustivelEnum.Gasolina,
                QuantidadePortas = 4,
                Nome = "Carro aleatório"
            };
            return carro;
        }

        public static Moto GerarMoto()
        {
            var moto = new Moto
            {
                Largura = 50,
                Cilindradas = 120,
                Nome = "Moto bixada",
                Combustivel = TipoCombustivelEnum.BiCombustivel
            };

            return moto;
        }

        public static Bicicleta GerarBicicleta()
        {
            var bicicleta = new Bicicleta
            {
                PossuiBagageiro = true,
                Nome = "Bicicleta top",
                PossuiAerofolio = true,
                PossuiAmortecedor = true,
                QuantidadeMarchas = 7
            };

            return bicicleta;
        }
    }
}
