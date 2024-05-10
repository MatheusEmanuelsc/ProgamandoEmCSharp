// Resumo sobre tuplas:
// - Tuplas são uma estrutura de dados que permitem agrupar vários elementos de tipos diferentes em uma única unidade.
// - Elas são úteis para retornar múltiplos valores de um método ou para lidar com dados heterogêneos.
// - Tuplas podem ser declaradas sem especificar os tipos dos elementos ou com tipos explicitamente definidos.
// - Os elementos de uma tupla podem ser acessados usando a notação de ponto ou a desconstrução de tupla.
// - Tuplas podem ser nomeadas, o que torna o código mais legível e expressivo.
// - Elas suportam a comparação de igualdade e podem ser usadas em loops foreach.
// - As tuplas podem ser retornadas como valores de métodos ou passadas como argumentos.

// Declaração de tuplas
var tupla1 = (1, "hello", 3.14);
(int, string, double) tupla2 = (1, "hello", 3.14);

// Acesso aos elementos
Console.WriteLine(tupla1.Item1); // Saída: 1
Console.WriteLine(tupla1.Item2); // Saída: hello
Console.WriteLine(tupla1.Item3); // Saída: 3.14

(int a, string b, double c) = tupla1;
Console.WriteLine(a); // Saída: 1
Console.WriteLine(b); // Saída: hello
Console.WriteLine(c); // Saída: 3.14

// Retorno de múltiplos valores
(string Nome, int Idade) GetInfo()
{
    return ("Alice", 30);
}

var info = GetInfo();
Console.WriteLine(info.Nome); // Saída: Alice
Console.WriteLine(info.Idade); // Saída: 30

// Desconstrução de tupla em foreach
var lista = new List<(string, int)> { ("a", 1), ("b", 2), ("c", 3) };
foreach (var (item1, item2) in lista)
{
    Console.WriteLine($"{item1} - {item2}");
}

// Tuplas nomeadas
var pessoa = (Nome: "Alice", Idade: 30);
Console.WriteLine(pessoa.Nome); // Saída: Alice
Console.WriteLine(pessoa.Idade); // Saída: 30

// Igualdade de tuplas
var tupla3 = (1, "hello", 3.14);
var tupla4 = (1, "hello", 3.14);
Console.WriteLine(tupla3 == tupla4); // Saída: True

// Tuplas como argumentos de métodos
(int, int) SomaEProduto(int a, int b)
{
    return (a + b, a * b);
}

var resultado = SomaEProduto(3, 4);
Console.WriteLine(resultado.Item1); // Saída: 7
Console.WriteLine(resultado.Item2); // Saída: 12
