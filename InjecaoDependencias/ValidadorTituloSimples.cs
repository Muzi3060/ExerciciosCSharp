public class ValidadorTituloSimples : IValiadorTitulo
{
    public bool TituloValido(string titulo)
    {
        return !string.IsNullOrWhiteSpace(titulo);
    }
}