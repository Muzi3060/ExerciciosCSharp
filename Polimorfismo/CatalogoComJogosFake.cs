public class CatalogoComJogosFake : ICatalogoJogos
{
    public List<JogoResumo> BuscarJogos(string jogo)
    {
        return
        [
            new (1, "Hollow Knight"),
            new (2, "Celeste"),
            new (3, "Stardew Valley")
        ];
    }

}