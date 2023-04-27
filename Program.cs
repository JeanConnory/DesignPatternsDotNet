#region UsingCriacionais
//using DesignPatterns.PatternsCriacionais.AbstractFactory;
//using DesignPatterns.PatternsCriacionais.Builder;
//using DesignPatterns.PatternsCriacionais.FactoryMethod;
//using DesignPatterns.PatternsCriacionais.Prototype;
//using DesignPatterns.PatternsCriacionais.Singleton;
#endregion

#region Estruturais
//using DesignPatterns.PatternsEstruturais.Adapter;
//using DesignPatterns.PatternsEstruturais.Bridge;
//using DesignPatterns.PatternsEstruturais.Bridge.Abstracao;
//using DesignPatterns.PatternsEstruturais.Bridge.Implementacao;
//using DesignPatterns.PatternsEstruturais.Composite;
//using DesignPatterns.PatternsEstruturais.Decorator;
//using DesignPatterns.PatternsEstruturais.Facade;
//using DesignPatterns.PatternsEstruturais.Flyweight;
//using DesignPatterns.PatternsEstruturais.Proxy;
#endregion

//using DesignPatterns.PatternsComportamentais.ChainOfResponsability;
//using DesignPatterns.PatternsComportamentais.Command;
//using DesignPatterns.PatternsComportamentais.Strategy;
//using DesignPatterns.PatternsComportamentais.Interpreter.Jumanji;
//using DesignPatterns.PatternsComportamentais.Observer;
//using DesignPatterns.PatternsComportamentais.TemplateMethod;
//using DesignPatterns.PatternsComportamentais.Visitor;
//using DesignPatterns.PatternsComportamentais.Iterator;
//using DesignPatterns.PatternsComportamentais.Mediator;
//using DesignPatterns.PatternsComportamentais.Memento;
using DesignPatterns.PatternsComportamentais.State;

Console.WriteLine("\n Design Patterns \n");

#region Criacionais

//Client client = new Client();
//client.ExecutarCriacaoProduto();
//client.ConsultarRotinaAluno();
//client.ConsumirDB();
//client.ConsumirDadosStudio();
//client.Consumir();

#endregion

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

#region Comportamentais

//Client client = new Client();
//client.ConsumirEndpointJSON();

//ApresentaPopup apresentaPopup = new ApresentaPopup();
//apresentaPopup.ApresentarHabilidadesPopup();

//SendEmail sendEmail = new SendEmail();
//sendEmail.EnviarEmail();

//Fiscal fiscal = new Fiscal();
//fiscal.CalcularImpostos();

//Client client = new Client();
//client.FalarComandos();

//RotinaTaxaServicos rotinaTaxaServicos = new RotinaTaxaServicos();
//rotinaTaxaServicos.ExecutarRotina();

//Sender sender = new Sender();
//sender.RealizarCheckout();

//Client client = new Client();
//client.ConsumirEstruturaDados();

//Chat chat = new Chat();
//chat.Conversar();

//VideoCassete videoCassete = new VideoCassete();
//videoCassete.ExecutarAcaoVideo();

Client client = new Client();
client.ExecutarContext();

#endregion