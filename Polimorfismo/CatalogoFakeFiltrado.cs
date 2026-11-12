public class CatalogoFakeFiltraado : ICatalogoJogos
{
    public List<JogoResumo> BuscarJogos(string jogo)
    {
        var jogos = new List<JogoResumo>
        {
            new(1, "Hollow Knight"),
            new(2, "Celeste"),
            new(3, "Stardew Valley")
        };

        return [.. jogos.Where(j => j.Titulo.Contains(jogo, StringComparison.OrdinalIgnoreCase))];
    }
}