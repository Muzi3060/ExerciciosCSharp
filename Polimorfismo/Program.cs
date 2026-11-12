// Duas implementações, um contrato -- Exercicio 1

// INotificacaoService notificacao = new NotificacaoEmailService();
// Console.WriteLine(notificacao.EnviarNotificacao("Olá, tudo bem? (pelo E-mail)"));

// notificacao = new NotificacaoConsoleService();
// Console.WriteLine(notificacao.EnviarNotificacao("Olá, tudo bem? (pelo Console)"));

// Implementação fake -- Exercicio 2 

// ICatalogoJogos catalogo = new CatalogoComJogosFake();
// catalogo = new CatalogoVazioFake();

// var jogos = catalogo.BuscarJogos("Hollow Knight");

// if (jogos.Any()) {

//     foreach (var jogo in jogos){
//         Console.WriteLine($"ID: {jogo.Id}, Título: {jogo.Titulo}");
//     }

// }else{
//     Console.WriteLine("Nenhum jogo encontrado.");
// }

// Implementação fake com erro -- Exercicio 3 e 4

List<ICatalogoJogos> catalogos = [
        new CatalogoComJogosFake(),
        new CatalogoVazioFake(),
        new CatalogoErroFake(),
        new CatalogoFakeFiltraado()
    ];


foreach (var catalogo in catalogos)
{
    Console.WriteLine(PesquisaJogoService.Pesquisar(catalogo, "Stardew Valley"));
}


