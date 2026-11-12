using System.Text;

public class PesquisaJogoService 
{
    public static string Pesquisar(ICatalogoJogos catalogo, string jogo)
    {
        try
        {
            var jogos = catalogo.BuscarJogos(jogo);

            if (jogos.Count > 0)
            {
                var resultado = new StringBuilder();

                foreach (var item in jogos)
                {
                    resultado.AppendLine($"ID: {item.Id}, Título: {item.Titulo}");
                }

                return resultado.ToString();
            }
            else
            {
                return "Nenhum jogo encontrado.";
            }
        }
        catch (InvalidOperationException ex)
        {
            return $"Erro ao buscar jogos: {ex.Message}";
        }

    }
}