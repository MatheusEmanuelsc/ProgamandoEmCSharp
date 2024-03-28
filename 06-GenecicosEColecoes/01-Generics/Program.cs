// Resumo - Genéricos em C#:

// Genéricos são uma característica poderosa da linguagem C# que permitem escrever código flexível e reutilizável. 
// Eles permitem criar classes, métodos e interfaces que podem trabalhar com diferentes tipos de dados, sem precisar reescrever o código para cada tipo.

// Existem diferentes formas de utilizar genéricos em C#, incluindo:

// 1. Genéricos em Classes:
//    - Permite criar classes que podem ser parametrizadas com um ou mais tipos de dados.
//    - Exemplo: Lista<T>, onde T é um tipo de dado que pode ser substituído por qualquer tipo.

// 2. Genéricos em Métodos:
//    - Permite criar métodos que podem aceitar um ou mais tipos de dados genéricos.
//    - Exemplo: Método Imprimir<T>(T item), onde T é um tipo de dado que pode ser especificado ao chamar o método.

// 3. Genéricos em Interfaces:
//    - Permite criar interfaces que podem ser implementadas por classes genéricas.
//    - Exemplo: Interface IList<T>, que define operações para listas parametrizadas por um tipo de dado.

// Além disso, é possível delimitar o escopo dos tipos de dados genéricos usando restrições de tipo, como:

// - where T : struct: Restringe T a tipos de valor (structs).
// - where T : class: Restringe T a tipos de referência (classes).
// - where T : new(): Restringe T a tipos que têm um construtor sem parâmetros.
// - where T : MyBaseClass: Restringe T a tipos que derivam de MyBaseClass.
// - where T : IMyInterface: Restringe T a tipos que implementam a interface IMyInterface.

// Exemplo de Uso de Genéricos em C#:

// 1. Interface Genérica:
//    - Define uma interface genérica com um método que usa um tipo genérico.
public interface IRepositorio<T>
{
    void Salvar(T item);
}

// 2. Método Genérico:
//    - Define um método genérico que recebe um tipo genérico restrito.
public void ImprimirLista<T>(List<T> lista) where T : IComparable
{
    foreach (var item in lista)
    {
        Console.WriteLine(item);
    }
}

// 3. Classe Genérica:
//    - Define uma classe genérica com um tipo genérico restrito.
public class Repositorio<T> : IRepositorio<T> where T : class
{
    public void Salvar(T item)
    {
        // Implementação para salvar o item.
    }
}

