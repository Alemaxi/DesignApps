// See https://aka.ms/new-console-template for more information

using Builder;
using DesignApps;

new DesenhaCirculo().Desenhar();

Console.WriteLine("\n");

new FazerBolo(
    new BaunilhaChocolateSimplesBuilder(),
    new ChocolateMorangoChantiliBuilder(),
    new SimplesMaracujaAmericanoBuilder()).PrepararBolos();

Console.WriteLine("\n");

new SimuladorMeiotransporte().ExibirMeiosDeTransporte();

Console.WriteLine("\n");

new ConversorDeEnenergias().Converter();