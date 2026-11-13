public class ConfiguracaoExibicao
{

    public ConfiguracaoExibicao(string tema, int itensPorPagina)
    {
        Tema = tema;
        ItensPorPagina = itensPorPagina;
    }

    public string Tema { get; init; } 
    public int ItensPorPagina { get; set; }

    public string NomePerfil { get; private set; } = "Visitante";

    public void AlterarNomePerfil(string novoNome)
    {
        if (string.IsNullOrWhiteSpace(novoNome))
        {
            throw new ArgumentException("O nome do perfil não pode ser nulo ou vazio.", nameof(novoNome));
        }

        NomePerfil = novoNome;
    }

}