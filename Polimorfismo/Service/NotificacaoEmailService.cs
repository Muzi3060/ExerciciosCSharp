public class NotificacaoEmailService : INotificacaoService
{
    public string EnviarNotificacao(string mensagem)
    {
        return $"Enviando notificação por e-mail: {mensagem}";
    }
}