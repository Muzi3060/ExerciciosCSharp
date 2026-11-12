public class AvaliacaoService : IAvaliacaoService
{
    public bool NotaValida(double nota) => nota >= 0 && nota <= 10;
    // retorna true se a nota estiver entre 0 e 10.

    public double CalcularMedia(List<double> notas)
    {
        if (notas == null || !notas.Any())
        {
            throw new ArgumentException("A lista de notas não pode ser nula ou vazia.", nameof(notas));
        }

        if (notas.Any(n => !NotaValida(n)))
        {
            throw new ArgumentException("Uma ou mais notas são inválidas. Confira os valores novamente...");
        }

        return notas.Average();
    }


    // método de um exercicio anterior.

    // public string ClassificarNota(double nota)
    // {
    //     if (!NotaValida(nota))
    //     {
    //         throw new ArgumentException("Nota inválida. Confira o valor novamente...");
    //     }

    //     return nota switch
    //     {
    //         < 5 => "Ruim",
    //         < 7 => "Regular",
    //         < 9 => "Bom",
    //         _ => "Excelente",
    //     };
    // }
    
}