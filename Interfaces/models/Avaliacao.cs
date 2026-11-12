public class Avaliacao(string tituloJogo, double nota, string comentario)
{
    public string TituloJogo { get; set; } = tituloJogo;
    public double Nota { get; set; } = nota;
    public string Comentario { get; set; } = comentario;
}