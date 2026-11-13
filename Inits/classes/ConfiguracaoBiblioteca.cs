class ConfiguracaoBiblioteca
{

    private  int _ItensPorPagina;
    public string NomeBiblioteca { get; init; }
    public int ItensPorPagina 
    { 

        get
        {
            return _ItensPorPagina;
        }
    
        set
        {
            if (!(value >= 5 && value <= 100))
            {
                throw new ArgumentOutOfRangeException("ItensPorPagina", "O valor deve estar entre 5 e 100.");
            }

            _ItensPorPagina = value;
        }
    }

    public ConfiguracaoBiblioteca(string nomeBiblioteca, int itensPorPagina)
    {
        NomeBiblioteca = nomeBiblioteca;
        ItensPorPagina = itensPorPagina;
    }
}