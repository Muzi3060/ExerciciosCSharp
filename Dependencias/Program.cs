try {
        ICatalogoJogos adaptador = new AdaptadorCatalogo(new FornecedorJogosFake());
        var jogos = adaptador.BuscarJogos();


        foreach (var jogo in jogos.JogosValidos)
        {
            Console.WriteLine($"ID: {jogo.Id} | Titulo: {jogo.Titulo} | Nota: {jogo.Nota} | Horas Jogadas: {jogo.HorasJogadas}\n");
        }
        foreach (var erro in jogos.Erros)
        {
            Console.WriteLine(erro);
        }

        Console.WriteLine($"Quantidade de jogos válidos: {jogos.JogosValidos.Count}");
        Console.WriteLine($"Quantidade de erros: {jogos.Erros.Count}");

} catch (ArgumentException ex) {
    Console.WriteLine($"Erro: {ex.Message}");
}