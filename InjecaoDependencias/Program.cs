// Exercicio 1 -- injeção de dependencias

// var AtividadeService = new AtividadeService(new RegistroConsole());

// AtividadeService.IniciarAtividade("Estudar C#");


// Exercicio 2 -- injeção de dependencias

// var repositorio = new RepositorioJogosMemoria();
// var biblioteca = new BibliotecaService(new NotificadorConsole(), repositorio);

// biblioteca.AdicionarJogo("The Witcher 3");

// biblioteca = new BibliotecaService(new NotificadorRegraNova(), repositorio);
// biblioteca.AdicionarJogo("Cyberpunk 2077");


// repositorio.ListarJogos().ForEach(jogo => Console.WriteLine($"Jogo: {jogo}"));
// Console.WriteLine(repositorio.ListarJogos().Count.ToString());

// Exercio 3 -- injeção de dependencias

//var repositorioFake = new RepositorioJogosFake();

// var bibliotecaFake = new BibliotecaService(new NotificadorConsole(), repositorioFake);
// bibliotecaFake.AdicionarJogo("Red Dead Redemption 2");

// Console.WriteLine($"Último jogo salvo no repositório fake: {repositorioFake.UltimoJogoSalvo}");

var repositorio = new RepositorioJogosMemoria();

var Cadastro = new CadastroJogoService(repositorio, new ValidadorTituloSimples(), new NotificadorConsole());
Cadastro.CadastrarJogo("Horizon Zero Dawn");
Cadastro.CadastrarJogo("     ");
Cadastro.CadastrarJogo("God of War");

repositorio.ListarJogos().ForEach(jogo => Console.WriteLine($"Jogo: {jogo}"));
Console.WriteLine($"Quantidade de itens: {repositorio.ListarJogos().Count}");