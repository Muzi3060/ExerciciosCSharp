public class FornecedorJogosFake
{
    // Apenas retorna jogos fake.
    public List<JogoApiDto> ObterJogos()
    {
        return [
            new (1, "The Witcher 3: Wild Hunt", rating: 100, 30),
            new (2, "Red Dead Redemption 2", rating: 95, 120),
            new (3, "Cyberpunk 2077", rating: 34, 22),
            new (4, "Mafia Old Country", rating: 220, 160),
            new (5, "Astrooner", rating: 94, -30),
            new (6, "The elder scrolls V: Skyrim", rating: 500, 120),
            new (7, "Batman Arkham Knight", rating: 200, playTimeMinutes: 130)
        ];
    }
}