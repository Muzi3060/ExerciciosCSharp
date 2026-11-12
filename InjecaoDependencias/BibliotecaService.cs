public class BibliotecaService
{
    private readonly INotificador _notificador; // dependencia 
    private readonly IRepostorioJogos _repositorioJogos; // dependencia

    public BibliotecaService(INotificador notificador, IRepostorioJogos repositorioJogos) // dependencia injetada 
    {
        _notificador = notificador ?? throw new ArgumentNullException(nameof(notificador));
        _repositorioJogos = repositorioJogos ?? throw new ArgumentNullException(nameof(repositorioJogos));
    }

    public void AdicionarJogo(string titulo)
    {
        // Lógica para adicionar o jogo à biblioteca
        _repositorioJogos.Salvar(titulo);
        _notificador.Notificar($"Jogo adicionado à biblioteca: {titulo}");
    
    }
}