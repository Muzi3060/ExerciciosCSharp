class PerfilUsuario
{
    public string Nome { get; init;}
    public int Idade { get; init;}
    public int Nivel {get; private set;} = 1;

    public PerfilUsuario(string nome, int idade)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("O nome não pode ser nulo ou vazio.", nameof(nome));
        }

        if (!(idade >= 13 && idade <= 120))
        {
            throw new ArgumentOutOfRangeException(nameof(idade), "A idade deve estar entre 13 e 120 anos.");
        }

        Nome = nome.Trim();
        Idade = idade;
    }

    public void SubirNivel()
    {
        Nivel++;
    }

}