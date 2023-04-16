// See https://aka.ms/new-console-template for more information

//using DesignPatterns.PatternsCriacionais.FactoryMethod;

//using DesignPatterns.PatternsCriacionais.AbstractFactory;

//using DesignPatterns.PatternsCriacionais.Singleton;

//using DesignPatterns.PatternsCriacionais.Builder;

//using DesignPatterns.PatternsCriacionais.Prototype;

using DesignPatterns.PatternsEstruturais.Adapter;

Console.WriteLine("\n Design Patterns \n");

//Client client = new Client();
//client.ExecutarCriacaoProduto();
//client.ConsultarRotinaAluno();
//client.ConsumirDB();
//client.ConsumirDadosStudio();
///client.Consumir();
///

// Estruturais

CloudComputing cloud = new CloudComputing();
cloud.ProcessarContas("setembro");