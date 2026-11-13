// // Exercicio 1

// // var config = new ConfiguracaoExibicao("Escuro", 20);


// // Console.WriteLine($"Antes de alterar: {config.ItensPorPagina}");
// // Console.WriteLine($"Depois de alterar {config.ItensPorPagina = 30}");
// // Console.WriteLine($"Nome do perfil: {config.NomePerfil}");

// // config.AlterarNomePerfil("Jogador");
// // Console.WriteLine($"Nome do perfil após alteração: {config.NomePerfil}");

// // Console.WriteLine($"Tema atual: {config.Tema}");
// // // config.Tema = "Claro"; Está linha não compila, pois a propriedade Tema é somente para inicialização (init).

// // Exercicio 2

// // var config = new ConfiguracaoBiblioteca("Minha Biblioteca", 20);

// // Console.Clear();
// // Console.WriteLine($"Nome atual da biblioteca: {config.NomeBiblioteca}");
// // Console.WriteLine($"Quantidade itens atual da biblioteca: {config.ItensPorPagina}");

// // config.ItensPorPagina = 99;

// // Console.WriteLine($"\nQuantidade de itens após a alteração: {config.ItensPorPagina}");

// // Exercicio 3

// // var perfil = new PerfilUsuario("João     ", 25);

// // perfil.SubirNivel();
// // perfil.SubirNivel();

// // Console.WriteLine($"Nome: {perfil.Nome} | Idade: {perfil.Idade} | Nível: {perfil.Nivel}");

// // Exercicio 4

// var config = new ConfiguracaoUsuario("João", "Claro", 20)
// {
//     Nome = "Carlos",
//     Tema = "Claro",
//     ItensPorPagina = 99
// };



// Console.WriteLine($"Nome: {config.Nome} Tema: {config.Tema} | Itens por página: {config.ItensPorPagina}");

// Exercicio 5

var progresso = new ProgressoManga("One Piece           ", 3);

for (int i = 0; i < 3; i++)
{
    progresso.AvancarCapitulo();
    Console.WriteLine($"Título: {progresso.Titulo} | Total de Capítulos: {progresso.TotalCapitulos} | Capítulo Atual: {progresso.CapituloAtual} | Concluído: {progresso.Concluido}");
}



// progresso.AvancarCapitulo(); // Isso lançará uma exceção, pois o progresso já foi concluído.
// Console.WriteLine(progresso.CapituloAtual);