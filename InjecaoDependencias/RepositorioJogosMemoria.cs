public class RepositorioJogosMemoria : IRepostorioJogos
{
    private readonly List<string> _jogos = [];

    public void Salvar(string titulo)
    {
        _jogos.Add(titulo);
    }

    public List<string> ListarJogos()
    {
    
        return [.. _jogos];
    }


}