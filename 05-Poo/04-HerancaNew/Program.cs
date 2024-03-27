// Herança e a palavra-chave "new" em C#:
// A herança é um conceito fundamental na programação orientada a objetos que permite que uma classe (chamada de classe derivada) herde membros (métodos, propriedades, etc.) de outra classe (chamada de classe base).
// A palavra-chave "new" é usada em C# para esconder um membro herdado de uma classe base, substituindo-o por um novo membro na classe derivada.

// Sintaxe de uso da palavra-chave "new":
class ClasseDerivada : ClasseBase
{
    new tipo NomeDoMembro;
}

// Características do uso da palavra-chave "new":

// 1. Esconder membros da classe base:
//    A palavra-chave "new" pode ser usada para esconder (ou ocultar) membros herdados da classe base. Isso significa que o membro da classe derivada será usado em vez do membro da classe base com o mesmo nome.

// 2. Esconder métodos:
//    Ao usar "new" com métodos, a classe derivada fornece uma implementação completamente nova para o método, substituindo completamente a implementação da classe base.

// 3. Esconder propriedades:
//    Ao usar "new" com propriedades, a classe derivada fornece uma nova implementação para a propriedade, substituindo apenas a implementação de leitura ou de gravação, conforme necessário.

// 4. Acessando membros ocultos:
//    É possível acessar membros da classe base (que foram ocultados na classe derivada) usando a palavra-chave "base".

// Exemplo de uso da palavra-chave "new":
class Animal
{
    public void EmitirSom()
    {
        Console.WriteLine("Som genérico de animal");
    }
}

class Cachorro : Animal
{
    new public void EmitirSom()
    {
        Console.WriteLine("Au au!");
    }

    public void EmitirSomAnimal()
    {
        base.EmitirSom(); // Chama o método da classe base
    }
}

// No exemplo acima, a classe Cachorro usa "new" para ocultar o método EmitirSom da classe base Animal e fornecer uma nova implementação específica para Cachorro.
// O método EmitirSomAnimal da classe Cachorro demonstra como chamar o método da classe base usando "base".

// O uso cuidadoso da palavra-chave "new" é importante para garantir que o comportamento esperado seja mantido ao trabalhar com herança e substituição de membros em classes derivadas.
