public class AvaliacaoRepositorioMemoria : IAvaliacaoRepositorio
{
    private readonly List<Avaliacao> _avaliacoes = [];
    
    public void Salvar(Avaliacao avaliacao)
    {

        avaliacao.TituloJogo = avaliacao.TituloJogo?.Trim() ?? string.Empty;

        if (avaliacao == null) {
            throw new ArgumentNullException(nameof(avaliacao), "A avaliação não pode ser nula.");
        }

        if (string.IsNullOrWhiteSpace(avaliacao.TituloJogo)) {
            throw new ArgumentException("O título do jogo não pode ser nulo ou vazio.", nameof(avaliacao.TituloJogo));
        }

        if (!(avaliacao.Nota >= 0 && avaliacao.Nota <= 10)) {
            throw new ArgumentOutOfRangeException(nameof(avaliacao.Nota), "A nota deve estar entre 0 e 10.");
        }

        if (_avaliacoes.Any(a => a.TituloJogo.Equals(avaliacao.TituloJogo, StringComparison.OrdinalIgnoreCase))) {
            throw new InvalidOperationException($"Já existe uma avaliação para o jogo '{avaliacao.TituloJogo}'.");
        }

        _avaliacoes.Add(avaliacao);
    }

    public Avaliacao? BuscarPorJogo(string titulo) {
        titulo = titulo?.Trim() ?? string.Empty;

        return _avaliacoes.FirstOrDefault(a => a.TituloJogo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
    }

    public int ContarAvaliacoes() => _avaliacoes.Count;
    
}