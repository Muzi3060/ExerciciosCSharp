// // // Exercicio 1 

// // // var jogo1 = new JogoResumo { Id = 1, Titulo = "Celeste" };
// // // var jogo2 = new JogoResumo { Id = 1, Titulo = "Celeste" };
// // // var jogo3 = new JogoResumo { Id = 1, Titulo = "Hollow Knight" };

// // // if (jogo1 == jogo2)
// // // {
// // //     Console.WriteLine("jogo1 é igual a jogo2");
// // //     // Como recors trata de igualdade de valor, mesmo sendo instâncias diferentes, o resultado é true.
// // // }
// // // else
// // // {
// // //     Console.WriteLine("jogo1 é diferente de jogo2");
// // // }

// // // if (jogo1 == jogo3)
// // // {
// // //     Console.WriteLine("jogo1 é igual a jogo3");
// // // }
// // // else
// // // {
// // //     Console.WriteLine("jogo1 é diferente de jogo3");
// // //     // Como recors trata de igualdade de valor, mesmo sendo instâncias diferentes, o resultado é false.
// // // }

// // // Console.WriteLine();
// // // Console.WriteLine(ReferenceEquals(jogo1, jogo2));
// // // // Como são instâncias diferentes, o resultado é false.

// // // Exercicio 2

// // // var filme1 = new FilmeResumo(1, "O Poderoso Chefão", 9.2);
// // // var filme2 = new FilmeResumo(1, "O Poderoso Chefão", 9.2);
// // // var filme3 = filme1;

// // // Console.WriteLine(filme1 == filme2);
// // // Console.WriteLine(ReferenceEquals(filme1, filme2));
// // // Console.WriteLine();

// // // Console.WriteLine(filme1 == filme3);
// // // Console.WriteLine(ReferenceEquals(filme1, filme3));

// // // Exercicio 3

// // var hash = new HashSet<JogoBusca>();

// // hash.Add(new JogoBusca(1, "Celeste", "PC"));
// // hash.Add(new JogoBusca(1, "Celeste", "PC"));
// // hash.Add(new JogoBusca(1, "Celeste", "switch"));
// // hash.Add(new JogoBusca(2, "Hollow Knight", "pc"));
// // hash.Add(new JogoBusca(2, "Hollow Knight", "pc"));

// // Console.WriteLine($"Quantidade de jogos no hash: {hash.Count}");
// // Console.WriteLine("Jogos no hash:\n");
// // foreach (var jogo in hash)
// // {
// //     Console.WriteLine($"Id: {jogo.Id}, Titulo: {jogo.Titulo}, Plataforma: {jogo.Plataforma}");
// // }

// // Exercicio 4

// var hash = new HashSet<JogoApi>();
// var hashcolecao = new HashSet<long>();

// hash.Add(new JogoApi(100, "The Witcher 3"));
// hash.Add(new JogoApi(100, "The Witcher 3: Wild Hunt"));
// hash.Add(new JogoApi(200, "Cyberpunk 2077"));

// Console.WriteLine($"Quantidade de jogos: {hash.Count}");

// foreach (var jogo in hash)
// {
//     hashcolecao.Add(jogo.Id);
// }

// Console.WriteLine($"Quantidade de ID: {hashcolecao.Count}");

// Exercicio 5 

var jogo1 = new JogoCatalogo(10, "Celeste", 9.0); // adiciona no hashset
var jogo2 = new JogoCatalogo(10, "Celeste", 9.0); // não adiciona no hashset, pois é igual ao jogo1
var jogo3 = new JogoCatalogo(10, "Celeste", 9.5); // adiciona no hashset
var jogo4 = jogo1; // não adiciona no hashset, pois é a mesma referência do jogo1

Console.WriteLine(jogo1 == jogo2); // true, pois os valores são iguais
Console.WriteLine(jogo1 == jogo3); // false, pois os valores são diferentes
Console.WriteLine(jogo1 == jogo4); // true, pois são a mesma referência

Console.WriteLine(ReferenceEquals(jogo1, jogo2)); // false, pois são instâncias diferentes
Console.WriteLine(ReferenceEquals(jogo1, jogo4)); // true, pois são a mesma referência

var hash = new HashSet<JogoCatalogo>();
hash.Add(jogo1);
hash.Add(jogo2);
hash.Add(jogo3);
hash.Add(jogo4);

Console.WriteLine($"Quantidade de jogos: {hash.Count}");

