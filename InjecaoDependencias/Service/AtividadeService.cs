public class AtividadeService
{
    // private readonly RegistroConsole _registro = new();
    // Na linha acima, criamos a dependencia dentro do serviço, o que não é uma boa prática.

    private readonly RegistroConsole _registro;

    public AtividadeService(RegistroConsole registro)
    {
        _registro = registro;
    }

    // Agora o serviço agora depende de uma instância de RegistroConsole que é injetada através do construtor.

    public void IniciarAtividade(string nome)
    {
        _registro.Registrar($"Iniciando atividade: {nome}");
    }
}