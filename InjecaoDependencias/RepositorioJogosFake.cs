public class RepositorioJogosFake : IRepostorioJogos
{
    
    public string? UltimoJogoSalvo { get; private set; }


    
    public void Salvar(string titulo)
    {
        UltimoJogoSalvo = titulo;
        Console.WriteLine($"[FAKE] Salvando o jogo {titulo}");
    }


}