public class HistoricoAtividadesMemoria : IHistoricoAtividades
{
    private readonly List<string> lista = [];

    public void Adicionar(string atividade)
    {
        lista.Add(atividade);
    }

    public List<string> Listar()
    {
        return [.. lista];
    }

}
