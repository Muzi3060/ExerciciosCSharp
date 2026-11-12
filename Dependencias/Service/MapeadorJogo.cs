public static class MapeadorJogo
{
     public static JogoResumo Converter(JogoApiDto dto) 
    {
        if (dto.Id <= 0 ||
         string.IsNullOrWhiteSpace(dto.Name) ||
         dto.Rating < 0 || dto.Rating > 100 ||
         dto.PlayTimeMinutes < 0)
    {
        throw new ArgumentException("Dados inválidos para conversão do jogo.");
    }
        return new JogoResumo(dto.Id, dto.Name.Trim(), ConverterNota(dto.Rating), ConverterHorasJogadas(dto.PlayTimeMinutes));
    }

    private static double ConverterNota(double rating)  => rating / 10;
    
    private static double ConverterHorasJogadas(int playTimeMinutes) => playTimeMinutes / 60.0;

    public static ResultadosMapeamento ConverterLista(List<JogoApiDto> jogosExternos)
    {

        List<JogoResumo> jogosInternos =[]; // criamos uma lista local para jogos internos válidos
        List<string> erros = []; // criamos uma lista local para armazenar mensagens de erro

        if (jogosExternos is null || jogosExternos.Count == 0)
        {
            throw new ArgumentException("A lista de jogos externos não pode ser nula ou vazia.");
        }

        foreach (var jogo in jogosExternos)
        {
            try
            {
                jogosInternos.Add(Converter(jogo)); // se o jogo for válido, adicionamos a lista de jogos internos
            }
            catch (ArgumentException ex)
            {
                erros.Add($"Erro ao converter o jogo com ID {jogo.Id}: {ex.Message}"); // se houver um erro na conversão, adicionamos a mensagem de erro à lista de erros
            }
            
        }
        return new ResultadosMapeamento
        {
            JogosValidos = jogosInternos,
            Erros = erros
        };
    }
    
}