public class CadastroJogoService
{

    private readonly IRepostorioJogos _repositorio;
    private readonly IValiadorTitulo _validador;
    private readonly INotificador _notificador;

    public CadastroJogoService(IRepostorioJogos repositorio, IValiadorTitulo validador, INotificador notificador)
    {
        _repositorio = repositorio;
        _validador = validador;
        _notificador = notificador;
    }

    public void CadastrarJogo(string titulo)
    {
        if (_validador.TituloValido(titulo))
        {
            _repositorio.Salvar(titulo);
            _notificador.Notificar($"Jogo '{titulo}' cadastrado com sucesso!");
        }
        else
        {
            _notificador.Notificar($"Título inválido: '{titulo}'. O jogo não foi cadastrado.");
            return;
        }
    }
}