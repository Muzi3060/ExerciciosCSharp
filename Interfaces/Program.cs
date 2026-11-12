// Primeira Interface -- Exercicio 1

// ITempoJogoService tempoJogoService = new TempoJogoService();

// // Declaramos a variável com o tipo da interface e instanciamos um objeto da classe concreta.

// Console.WriteLine($"Horas restantes: {tempoJogoService.CalcularHorasRestantes(40, 15)}");

// Contrato com multiplos métodos -- Exercicio 2

// IAvaliacaoService avaliacaoService = new AvaliacaoService();

// Console.WriteLine($"Nota válida: {avaliacaoService.NotaValida(8.5)}");
// Console.WriteLine($"Média: {avaliacaoService.CalcularMedia(8.5, 7.5)}");
// Console.WriteLine($"Classificação: {avaliacaoService.ClassificarNota(4)}");

// Interface aplicada a um serviço de biblioteca -- Exercicio 3 

// IBibliotecaService bibliotecaService = new BibliotecaService();

// try {
//     bibliotecaService.AdicionarJogo("The Legend of Zelda: Breath of the Wild", 9.5);
//     bibliotecaService.AdicionarJogo("Red Dead Redemption 2", 6.5);
//     bibliotecaService.AdicionarJogo("Red Dead Redemption 2", 6.5);
// } catch (Exception ex) {
//     Console.WriteLine($"Erro ao adicionar jogo: {ex.Message}");
// }

// Console.WriteLine($"Total de jogos: {bibliotecaService.ContarJogos()}");
// Console.WriteLine($"Jogo encontrado: {bibliotecaService.BuscarJogo("Red Dead Redemption 2")?.Titulo ?? "não"}");

// -- Exercicio 4 

// IAvaliacaoRepositorio avRepositorio = new AvaliacaoRepositorioMemoria();

// var a1 = new Avaliacao("The Legend of Zelda: Breath of the Wild", 9.5, "Excelente jogo!");
// var a2 = new Avaliacao("Red Dead Redemption 2", 9.5, "Jogo Legal!");

// try {
//     avRepositorio.Salvar(a1);
//     avRepositorio.Salvar(a2);
//     avRepositorio.Salvar(a2); // Tentativa de salvar a mesma avaliação novamente
// } catch (Exception ex) {
//     Console.WriteLine($"Erro ao salvar avaliação: {ex.Message}");
// }

// Console.WriteLine($"Total de avaliações: {avRepositorio.ContarAvaliacoes()}");

// Console.WriteLine($"Avaliação encontrada: {avRepositorio.BuscarPorJogo("Red Dead Redemption 2")?.TituloJogo ?? "não encontrado"}");

// if (avRepositorio.BuscarPorJogo("Red Dead Redemption 2") is Avaliacao avaliacaoEncontrada) {
//     Console.WriteLine($"Nota: {avaliacaoEncontrada.Nota}\nComentário: {avaliacaoEncontrada.Comentario}");
// }

// Miniaplicação com interfaces -- Exercicio 5

IBibliotecaService bibliotecaService = new BibliotecaService();
IAvaliacaoService avaliacaoService = new AvaliacaoService();

try {
    bibliotecaService.AdicionarJogo("The Legend of Zelda: Breath of the Wild", 9.5, 100);
    bibliotecaService.AdicionarJogo("Red Dead Redemption 2", 6.5, 80);
    bibliotecaService.AdicionarJogo("Super Mario Odyssey", 8.0, 30);
    bibliotecaService.AdicionarJogo("Super Mario Odyssey", 8.0, 30); // Tentativa de adicionar o mesmo jogo novamente
} catch (Exception ex) {
    Console.WriteLine($"Erro ao adicionar jogo: {ex.Message}");
}

bibliotecaService.ListarJogos().ForEach(jogo =>
{
    Console.WriteLine($"Título: {jogo.Titulo}, Nota: {jogo.Nota}, Horas Jogadas: {jogo.HorasJogadas}");
});

Console.WriteLine($"Total de jogos: {bibliotecaService.ContarJogos()}");

Console.WriteLine($"Média das notas: {avaliacaoService.CalcularMedia(bibliotecaService.ListaNotas())}");

Console.WriteLine(bibliotecaService.BuscarJogo("Super mario odyssey") is Jogo jogoEncontrado ? $"Jogo '{jogoEncontrado.Titulo}' encontrado" : "Jogo não encontrado");