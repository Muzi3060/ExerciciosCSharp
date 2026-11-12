public class AdaptadorCatalogo : ICatalogoJogos
{
    private readonly FornecedorJogosFake _fornecedorJogos;

    public AdaptadorCatalogo(FornecedorJogosFake fornecedorJogos)
    {
        _fornecedorJogos = fornecedorJogos; // Armazena a instância do fornecedor de jogos para uso posterior
    }

    public ResultadosMapeamento BuscarJogos()
    {
        var jogosExternos = _fornecedorJogos.ObterJogos(); // Obtém a lista de jogos do fornecedor externo
        return MapeadorJogo.ConverterLista(jogosExternos); // Converte a lista de jogos externos para o formato interno e retorna os resultados
    }
}