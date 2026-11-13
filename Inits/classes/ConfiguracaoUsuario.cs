class ConfiguracaoUsuario
{
    private string _nome = string.Empty;
    private string _tema = string.Empty;
    private int _itensPorPagina;
    
    public string Nome 
    { 
        get
        {
            return _nome;
        }

        init
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O nome não pode ser nulo ou vazio.", nameof(value));
            }
            _nome = value;
        }
    }
    public string Tema 
    { 
        get
        {
            return _tema;
        }

        init
        {
            if (!(value == "Claro" || value == "Escuro"))
            {
                throw new ArgumentException("O tema precisa ser 'Claro' ou 'Escuro'.", nameof(value));
            }
            _tema = value;
        }
    }
    public int ItensPorPagina 
    { 
        get
        {
            return _itensPorPagina;
        }

        init
        {
            if (!(value >= 5 && value <= 100))
            {
                throw new ArgumentException("A quantidade de itens por página deve ser um valor entre 5 e 100.", nameof(value));
            }
            _itensPorPagina = value;
        }
    }

    public ConfiguracaoUsuario(string nome, string tema, int itensPorPagina)
    {
        Nome = nome;
        Tema = tema;
        ItensPorPagina = itensPorPagina;
    }
}