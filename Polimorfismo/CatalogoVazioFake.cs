public class CatalogoVazioFake : ICatalogoJogos
{
    public List<JogoResumo> BuscarJogos(string jogo)
    {
        return new List<JogoResumo>();
    }
}