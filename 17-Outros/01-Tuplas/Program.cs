// Resumo sobre tuplas:
// - Tuplas são uma estrutura de dados que permitem agrupar vários elementos de tipos diferentes em uma única unidade.
// - Elas são úteis para retornar múltiplos valores de um método ou para lidar com dados heterogêneos.
// - Tuplas podem ser declaradas sem especificar os tipos dos elementos ou com tipos explicitamente definidos.
// - Os elementos de uma tupla podem ser acessados usando a notação de ponto ou a desconstrução de tupla.
// - Tuplas podem ser nomeadas, o que torna o código mais legível e expressivo.
// - Elas suportam a comparação de igualdade e podem ser usadas em loops foreach.
// - As tuplas podem ser retornadas como valores de métodos ou passadas como argumentos.
// - O descarte de tuplas permite ignorar valores específicos de uma tupla ao desestruturá-la.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
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

        var (nome, _) = GetInfo(); // Descarte do segundo valor da tupla
        Console.WriteLine($"Nome: {nome}"); // Saída: Nome: Alice

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
        Console.WriteLine($"Soma: {resultado.Item1}, Produto: {resultado.Item2}"); // Saída: Soma: 7, Produto: 12

        // Descarte de tuplas
        var (_, valor) = GetInfo();
        Console.WriteLine($"Idade: {valor}"); // Saída: Idade: 30

        // Retorno de tupla em métodos
        (int, int) DivisaoEresto(int x, int y)
        {
            return (x / y, x % y);
        }

        var divisao = DivisaoEresto(10, 3);
        Console.WriteLine($"Divisão: {divisao.Item1}, Resto: {divisao.Item2}"); // Saída: Divisão: 3, Resto: 1
    }
}
