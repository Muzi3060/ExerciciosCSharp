public class NotificadorRegraNova : INotificador
{
    public void Notificar(string mensagem)
    {
        Console.WriteLine($"[AVISO] {mensagem}");
    }
}