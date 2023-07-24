namespace Domain.MeiosDeTransporte
{
    public class Bicicleta
    {
        public string Nome { get; set; }
        public int QuantidadeMarchas { get; set; }
        public bool PossuiAerofolio { get; set; }
        public bool PossuiBagageiro { get; set; }
        public bool PossuiAmortecedor { get; set; }
        
        public string ExibirAerofolio()
        {
            return PossuiAerofolio ? "Possui" : "Não possui";
        }

        public string ExibirBagageiro()
        {
            return PossuiBagageiro ? "Possui" : "Não possui";
        }

        public string ExibirAmortecedor()
        {
            return PossuiAmortecedor ? "Possui" : "Não possui";
        }

        public override string ToString()
        {
            return $"{Nome} | {QuantidadeMarchas} | {ObterAerofolio()} | {ObterAmortercedor()} | {ObterBagageiro()}";
        }

        string ObterAerofolio()
        {
            return PossuiAerofolio ? "Possui aerofolio" : "Não possui aerofolio";
        }

        string ObterBagageiro()
        {
            return PossuiBagageiro ? "Possui bagageiro" : "Não possui bagageiro";
        }

        string ObterAmortercedor()
        { 
            return PossuiAmortecedor ? "Possui amortecedor" : "Não possui amortecedor"; 
        }
    }


}
