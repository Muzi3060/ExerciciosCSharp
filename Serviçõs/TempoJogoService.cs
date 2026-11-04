public class TempoJogoService
{
    
    public static int CalcularHorasRestantes(int horasEstimadas, int horasJogadas)
    {
        
        if (horasEstimadas < 0 || horasJogadas < 0)
        {
            throw new ArgumentException("Horas estimadas e horas jogadas devem ser valores não negativos.");
        }

        return Math.Max(0, horasEstimadas - horasJogadas);
    }

}