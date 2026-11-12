public interface IAvaliacaoRepositorio
{
    // Contrato Estrutural
    void Salvar(Avaliacao avaliacao);

    Avaliacao? BuscarPorJogo(string titulo);

    int ContarAvaliacoes();
}