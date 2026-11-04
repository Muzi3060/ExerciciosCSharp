public class AvaliacaoService
{
    public static bool NotaValida(double nota)
    {
        return nota >= 0 && nota <= 10; 
    }

    public double CalcularMedia(List<double> notas) 
    {

        if (!notas.Any())
            {
                throw new ArgumentException("A lista de notas está vazia. Não é possível calcular a média.");
            }
        
        foreach (var nota in notas)
        {
            if (!NotaValida(nota))
            {
                throw new ArgumentException($"Nota inválida: {nota}. As notas devem estar entre 0 e 10.");
            }

        }

        return notas.Average();
        // aqui o average faz o loop a soma e divide pelo count, tudo automaticamente e entrega a média.
        // se fosse com o sum, ficaria assim: return notas.Sum() / notas.Count;
    
    }
    
}






