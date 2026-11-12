using Microsoft.Extensions.DependencyInjection;
//
// // Exercicio 1 - Transient
//
// // var services = new ServiceCollection(); // Criamos uma coleção para registrar serviços
// //
// // services.AddTransient<ContadorService>(); // Registramos ContadorSerivce como Transient
// //
// // using var provider = services.BuildServiceProvider(); // Construímos o provdor que será responsável por resolver os serviços registrados
// //
// //
// // var contador1 = provider.GetRequiredService<ContadorService>();
// // var contador2 = provider.GetRequiredService<ContadorService>();
// //
// // // Solicitamos 2 instâncias de ContadorService
// //
// // contador1.Incrementar();
// // contador1.Incrementar();
// //
// // contador2.Incrementar();
// //
// //
// // Console.WriteLine($"Contador 1: {contador1.Contador}");
// // Console.WriteLine($"Contador 2: {contador2.Contador}");
//
// // Exercicio 2 - Scoped
//
// var services = new ServiceCollection(); // Criando a coleção de serviços
//
// services.AddScoped<ContadorService>(); // Registrando como Scoped
//
// using var provider = services.BuildServiceProvider(); // Construindo o provedor
//
// using var escopo1 = provider.CreateScope(); // Criando o escopo 1
// using var escopo2 = provider.CreateScope(); // Criando o escopo 2
//
// var contador1 = escopo1.ServiceProvider.GetRequiredService<ContadorService>();
// var contador2 = escopo1.ServiceProvider.GetRequiredService<ContadorService>();
//
// var contador3 = escopo2.ServiceProvider.GetRequiredService<ContadorService>();
// var contador4 = escopo2.ServiceProvider.GetRequiredService<ContadorService>();
//
// contador1.Incrementar();
// contador1.Incrementar();
//
// contador3.Incrementar();
//
//
// Console.WriteLine($"Contador 1: {contador1.Contador}");
// Console.WriteLine($"Contador 2: {contador2.Contador}");
// Console.WriteLine($"Contador 3: {contador3.Contador}");
// Console.WriteLine($"Contador 4: {contador4.Contador}");

// Exercicio 3 - Juntando todos

// var services = new ServiceCollection();
//
// services.AddTransient<GeradorOperacaoService>();
// services.AddScoped<SessaoService>();
// services.AddSingleton<ConfiguracaoService>();
//
// using var provider = services.BuildServiceProvider();
//
// using var escopo1 = provider.CreateScope();
// using var escopo2 = provider.CreateScope();
//
// // ESCOPO 1
//
// var operacao1 = escopo1.ServiceProvider.GetRequiredService<GeradorOperacaoService>();
// var operacao2 = escopo1.ServiceProvider.GetRequiredService<GeradorOperacaoService>();
//
// var operacao3 = escopo1.ServiceProvider.GetRequiredService<SessaoService>();
// var operacao4 = escopo1.ServiceProvider.GetRequiredService<SessaoService>();
//
// var operacao5 = escopo1.ServiceProvider.GetRequiredService<ConfiguracaoService>();
// var operacao6 = escopo1.ServiceProvider.GetRequiredService<ConfiguracaoService>();
//
// // ESCOPO 2
//
// var operacao7 = escopo2.ServiceProvider.GetRequiredService<GeradorOperacaoService>();
// var operacao8 = escopo2.ServiceProvider.GetRequiredService<GeradorOperacaoService>();
//
// var operacao9 = escopo2.ServiceProvider.GetRequiredService<SessaoService>();
// var operacao10 = escopo2.ServiceProvider.GetRequiredService<SessaoService>();
//
// var operacao11 = escopo2.ServiceProvider.GetRequiredService<ConfiguracaoService>();
// var operacao12 = escopo2.ServiceProvider.GetRequiredService<ConfiguracaoService>();
//
// Console.WriteLine($"Transient no mesmo escopo: {ReferenceEquals(operacao1, operacao2)}");
// Console.WriteLine($"Scoped no mesmo escopo: {ReferenceEquals(operacao3, operacao4)}");
// Console.WriteLine($"Scoped entre escopos: {ReferenceEquals(operacao3, operacao9)}");
// Console.WriteLine($"Singleton entre escopos: {ReferenceEquals(operacao5, operacao11)}");

// Criando coleção de serviços
var services = new ServiceCollection();

// Registrando serviços
services.AddTransient<INotificador, NotificadorConsole>();
services.AddScoped<AtividadeService>();
services.AddSingleton<IHistoricoAtividades, HistoricoAtividadesMemoria>();

using var provider = services.BuildServiceProvider();
using var escopo1 = provider.CreateScope();
using var escopo2 = provider.CreateScope();

// Solicitando o serviço
var operacao1 = escopo1.ServiceProvider.GetRequiredService<AtividadeService>();
var operacao2 = escopo2.ServiceProvider.GetRequiredService<AtividadeService>();
var historico = provider.GetRequiredService<IHistoricoAtividades>();

operacao1.RegistrarAtividade("Joguei Elden Ring");
operacao1.RegistrarAtividade("Assisti Frieren");

operacao2.RegistrarAtividade("Li Berserk");

Console.WriteLine("\nHiatórico:");
foreach (var atividade in historico.Listar())
{
    Console.WriteLine(atividade);
}
