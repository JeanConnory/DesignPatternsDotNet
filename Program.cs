//using DesignPatterns.PatternsCriacionais.FactoryMethod;
//using DesignPatterns.PatternsCriacionais.AbstractFactory;
//using DesignPatterns.PatternsCriacionais.Singleton;
//using DesignPatterns.PatternsCriacionais.Builder;
//using DesignPatterns.PatternsCriacionais.Prototype;
//using DesignPatterns.PatternsEstruturais.Adapter;
//using DesignPatterns.PatternsEstruturais.Flyweight;

//using DesignPatterns.PatternsEstruturais.Bridge;
//using DesignPatterns.PatternsEstruturais.Bridge.Abstracao;
//using DesignPatterns.PatternsEstruturais.Bridge.Implementacao;
//using DesignPatterns.PatternsEstruturais.Composite;
//using DesignPatterns.PatternsEstruturais.Decorator;
//using DesignPatterns.PatternsEstruturais.Facade;
//using DesignPatterns.PatternsEstruturais.Proxy;

Console.WriteLine("\n Design Patterns \n");

//Client client = new Client();
//client.ExecutarCriacaoProduto();
//client.ConsultarRotinaAluno();
//client.ConsumirDB();
//client.ConsumirDadosStudio();
//client.Consumir();
//

 #region Estruturais

//CloudComputing cloud = new CloudComputing();
//cloud.ProcessarContas("setembro");

//Client client;
//Random random;

//while (true)
//{
//    client = new Client();
//    random = new Random();

//    if(random.Next(2) == 1)
//        client.Material = new CanetaEsferografica();
//    else
//		client.Material = new PincelMarcador();

//    if (random.Next(1, 3) == 1)
//        client.Material.CorImplementacao = new Azul();
//    else if(random.Next(1, 3) == 2)
//		client.Material.CorImplementacao = new Preto();
//    else
//		client.Material.CorImplementacao = new Vermelho();

//    client.ConsultarCanetasPinceisNoEstoque();

//	Console.WriteLine("Pressione <Enter> para continuar ou qualquer tecla para finalizar...");
//    ConsoleKeyInfo key = Console.ReadKey();

//    if(key.KeyChar != 13)
//         break; 

//}

//FacadeManager facade = new FacadeManager();
//facade.ExecutarComplexidade();

//Client client = new Client();
//client.TentarConexaoClientVpn();

 #endregion