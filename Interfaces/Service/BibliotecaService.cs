public class BibliotecaService : IBibliotecaService
// classe de serviço 
{

    private readonly List<Jogo> jogos = [];
    public void AdicionarJogo(string titulo, double nota, int horasJogadas)
    {
        titulo = titulo?.Trim() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(titulo))
        {
            throw new ArgumentException("O título do jogo não pode ser nulo ou vazio.", nameof(titulo));
        }

        if (!(nota >= 0 && nota <= 10))
        {
            throw new ArgumentOutOfRangeException(nameof(nota), "A nota do jogo deve estar entre 0 e 10.");
        } 

        if (horasJogadas < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(horasJogadas), "As horas jogadas não podem ser negativas.");
        }

        if (jogos.Any(j => j.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase)))
        {
            throw new InvalidOperationException($"O jogo '{titulo}' já está na biblioteca.");
        }

        
        jogos.Add(new Jogo(titulo, nota, horasJogadas));

    }

    public List<Jogo> ListarJogos() => jogos;

    public Jogo? BuscarJogo(string titulo)
    // o ? no Jogo indica que ele pode retornar um valor nulo, caso o jogo não seja encontrado na biblioteca.
    {
        titulo = titulo?.Trim() ?? string.Empty;

        return jogos.FirstOrDefault(j => j.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        // o FirstOrDefault retorna o primeiro elemento que satisfaz a condição especificada ou um valor padrão (nulo) se nenhum elemento for encontrado.
    }
    public int ContarJogos() => jogos.Count;

    public List<double> ListaNotas()
    {
        return jogos.Select(j => j.Nota).ToList();
    }
}