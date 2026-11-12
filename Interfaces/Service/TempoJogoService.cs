public class TempoJogoService : ITempoJogoService
{
    public int CalcularHorasRestantes(int horasTotais, int horasJogadas)
    {
        if (horasTotais < 0 || horasJogadas < 0 || horasJogadas > horasTotais)
        {
            throw new ArgumentException("Dados inválidos. Confira os valores novamente...");
        }
        

        return horasTotais - horasJogadas;
    }
}