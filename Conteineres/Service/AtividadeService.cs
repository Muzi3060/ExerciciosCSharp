public class AtividadeService
{
    private IHistoricoAtividades _historico;
    private INotificador _notificador;


    public AtividadeService(IHistoricoAtividades historico, INotificador notificador)
    {
        _historico = historico;
        _notificador = notificador;
    }

    public void RegistrarAtividade(string descricao)
    {
        _historico.Adicionar(descricao);
        _notificador.Notificar($"Atividade registrada: {descricao}");
    }

}
