public class NotificadorConsole : INotificador
{

    public void Notificar(string mensagem)
    {
        Console.WriteLine($"[NOTIFICAÇÂO] {mensagem}");
    }
}
