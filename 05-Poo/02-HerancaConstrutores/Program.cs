// Herança e Construtores em C#:
// Quando uma classe derivada herda de uma classe base, os construtores da classe base não são herdados automaticamente pela classe derivada.
// No entanto, a classe derivada precisa chamar explicitamente um construtor da classe base para garantir que a inicialização da classe base seja realizada corretamente.

// Sintaxe para chamar o construtor da classe base a partir de uma classe derivada:
class Subclasse : Superclasse
{
    public Subclasse(/* parâmetros */)
        : base(/* argumentos */)
    {
        // Inicialização adicional da subclasse
    }
}

// Características dos construtores em herança:

// 1. Chamada explícita do construtor da classe base:
//    Na declaração do construtor da classe derivada, a palavra-chave "base" é usada para chamar um construtor específico da classe base. Isso garante que a inicialização da classe base seja realizada antes da inicialização da classe derivada.

// 2. Especificação dos argumentos:
//    Ao chamar o construtor da classe base usando a palavra-chave "base", os argumentos necessários pelo construtor da classe base devem ser fornecidos na chamada.

// 3. Herança de construtores:
//    Se a classe base tiver vários construtores, a classe derivada deve escolher qual construtor da classe base chamar usando a palavra-chave "base" na declaração do construtor da classe derivada.

// 4. Construtores padrão:
//    Se nenhum construtor for explicitamente definido na classe derivada, o compilador fornecerá um construtor padrão para a classe derivada. Esse construtor padrão chamará implicitamente o construtor padrão da classe base.

// Exemplo de uso de construtores em herança:
class Animal
{
    public string Nome { get; set; }

    public Animal(string nome)
    {
        Nome = nome;
    }
}

class Cachorro : Animal
{
    public string Raca { get; set; }

    public Cachorro(string nome, string raca)
        : base(nome)
    {
        Raca = raca;
    }
}

// No exemplo acima, a classe Cachorro herda da classe Animal e chama explicitamente o construtor da classe base usando a palavra-chave "base" em seu próprio construtor. Isso garante que a inicialização da classe base (atribuição do nome) seja realizada antes da inicialização específica da classe derivada (atribuição da raça).

// Construtores em herança garantem que a inicialização das classes base e derivada ocorra de forma ordenada e consistente, permitindo uma hierarquia de inicialização adequada.
