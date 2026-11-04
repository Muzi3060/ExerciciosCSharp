public class BibliotecaService
{
    
    private readonly List<Jogo> jogos = [];

    public void AdicionarJogo(string titulo, double notas, int horasJogadas = 0)
    {
        titulo = titulo?.Trim() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(titulo))
        {
            throw new ArgumentException("Título inválido. Por favor, insira um título válido.");
        }

        if (!AvaliacaoService.NotaValida(notas))
        {
            throw new ArgumentException("Nota inválida. Por favor, insira uma nota válida.");
        }
        
        if (jogos.Any(jogo => jogo.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase)))
        {
            throw new ArgumentException($"Jogo {titulo}, já existe na biblioteca.");
        }

        if (horasJogadas < 0)
        {
            throw new ArgumentException("Horas jogadas inválidas. Por favor, insira um valor válido.");
        }

        jogos.Add(new Jogo(titulo, notas, horasJogadas));
    }

    public int ContarJogos() =>  jogos.Count;
    
    public List<Jogo> ListarJogos() =>  jogos; 
        
    
    public bool BuscarJogo(string titulo) {

        titulo = titulo?.Trim() ?? string.Empty;

        return jogos.Any(jogo => jogo.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
    }

    public List<double> ListaNotas()
    {

        List<double> notas = [];

        foreach (var jogo in jogos)
        {
            notas.Add(jogo.Notas);
        }

        return notas;
    }
}