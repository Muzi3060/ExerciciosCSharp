public class NotificacaoConsoleService : INotificacaoService
{
    public string EnviarNotificacao(string mensagem)
    {
        return $"Enviando notificação por console: {mensagem}";
    }
}