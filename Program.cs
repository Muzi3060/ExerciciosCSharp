// // Verificando avaliações -- EXERCICIO 1

// var teste = new AvaliacaoService();

// if (teste.NotaValida(11m))
// {
//     Console.WriteLine("Nota válida.");
// }
// else
// {
//     Console.WriteLine("Nota inválida.");
// }

// // Calculando horas de jogo -- EXERCICIO 2

// var tempoJogoService = new TempoJogoService();

// int horasRestantes = tempoJogoService.CalcularHorasRestantes(-1, 0);
// Console.WriteLine($"Horas restantes: {horasRestantes}");


// // Gerenciando uma biblioteca -- EXERCICIO 3

// var bibliotecaService = new BibliotecaService();

// try {
//     bibliotecaService.AdicionarJogo("Batman");
//     bibliotecaService.AdicionarJogo("Superman");
//     bibliotecaService.AdicionarJogo("Flash");
//     bibliotecaService.AdicionarJogo("");
// }
// catch (ArgumentException ex)
// {
//     Console.WriteLine($"Erro: {ex.Message}");
// }


// Console.WriteLine($"Total de jogos na biblioteca: {bibliotecaService.ContarJogos()}");
// Console.WriteLine("Jogos na biblioteca:");
// foreach (var jogo in bibliotecaService.ListarJogos())
// {
//     Console.WriteLine($"- {jogo}");
// }


// // Separando responsabilidades -- EXERCICIO 4

// var bibliotecaService = new BibliotecaService();

// try {
//     bibliotecaService.AdicionarJogo( "batman", 8.5);
//     bibliotecaService.AdicionarJogo( "Superman", 10.0);
//     bibliotecaService.AdicionarJogo( "Superman", 5.5);
// }
// catch (ArgumentException ex)
// {
//     Console.WriteLine($"Erro: {ex.Message}");
// }



// bibliotecaService.ListarJogos().ForEach(jogo => Console.WriteLine($"Título: {jogo.Titulo}, Nota: {jogo.Notas}"));

//Mini biblioteca de jogos -- EXERCICIO 5

var bibliotecaService = new BibliotecaService();

try {
    bibliotecaService.AdicionarJogo("                  BatMaN     ", 8.5, 7);
    bibliotecaService.AdicionarJogo("Superman", 10.0, 5);
    bibliotecaService.AdicionarJogo("Flash", 7.0, 1);
    bibliotecaService.AdicionarJogo("Superman      ", 4.3, 2);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

Console.WriteLine($"Total de jogos na biblioteca: {bibliotecaService.ContarJogos()}");

Console.WriteLine("Jogos na biblioteca:");
foreach (var jogo in bibliotecaService.ListarJogos())
{
    Console.WriteLine($"- {jogo.Titulo}, Nota: {jogo.Notas}, Horas Jogadas: {jogo.HorasJogadas}");
}

if (bibliotecaService.BuscarJogo("                                                                       bATmAn     "))
{
    Console.WriteLine("O jogo está na biblioteca.");
} 
else
{
    Console.WriteLine("O jogo não está na biblioteca.");
}

AvaliacaoService avaliacaoService = new AvaliacaoService();


Console.WriteLine(avaliacaoService.CalcularMedia(bibliotecaService.ListaNotas()));