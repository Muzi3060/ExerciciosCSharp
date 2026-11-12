public class CatalogoErroFake : ICatalogoJogos
{
    public List<JogoResumo> BuscarJogos(string jogo)
    {
        throw new InvalidOperationException("Falha simulada na conexão com o catálogo de jogos.");
    }
}