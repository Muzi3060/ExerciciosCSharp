public interface IBibliotecaService
// interface
{
    void AdicionarJogo(string titulo, double nota, int horasJogadas);

    Jogo? BuscarJogo(string titulo);

    List<Jogo> ListarJogos();

    int ContarJogos();

    List<double> ListaNotas();
}