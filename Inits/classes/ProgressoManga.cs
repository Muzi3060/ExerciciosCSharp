class ProgressoManga
{
    private string _titulo = string.Empty;
    private int _totalCapitulos;

    public string Titulo 
    { 
        get
        {
            return _titulo;
        }

        init
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O título não pode ser nulo ou vazio.", nameof(value));
            }
            _titulo = value.Trim();
        }
    }

    public int TotalCapitulos 
    { 
        get
        {
            return _totalCapitulos;
        }

        init
        {
            if (value <= 0)
            {
                throw new ArgumentException("O total de capítulos deve ser um valor maior que zero.", nameof(value));
            }
            _totalCapitulos = value;
        }
    }

    public int CapituloAtual { get; private set; } = 0;
    public bool Concluido { get
        {
            return CapituloAtual >= TotalCapitulos;
        }
    }

    public ProgressoManga(string titulo, int totalCapitulos)
    {
        Titulo = titulo;
        TotalCapitulos = totalCapitulos;
    }

    public void AvancarCapitulo()
    {
        if (Concluido)
        {
            throw new InvalidOperationException("O progresso do manga já foi concluído.");
        }

        CapituloAtual++;
    }
}