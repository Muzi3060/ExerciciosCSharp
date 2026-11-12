public interface IAvaliacaoService
{
    bool NotaValida(double nota);

    double CalcularMedia(List<double> notas);
}

public interface IAvaliacaoServiceClassificacao
{
    string ClassificarNota(double nota);
}