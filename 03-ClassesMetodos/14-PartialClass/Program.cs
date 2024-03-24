// Partial class (classe parcial) é uma funcionalidade que permite dividir a definição de uma classe em múltiplos arquivos
// Cada arquivo contendo uma parte da definição da classe é marcado com a palavra-chave 'partial'

// Exemplo de uso de uma classe parcial
// Arquivo 1: MyClassPart1.cs
partial class MyClass
{
    public void Metodo1()
    {
        // Implementação do método 1
    }
}

// Arquivo 2: MyClassPart2.cs
partial class MyClass
{
    public void Metodo2()
    {
        // Implementação do método 2
    }
}

// Neste exemplo, 'MyClass' é uma classe parcial dividida em duas partes, em dois arquivos diferentes
// Ambas as partes compartilham o mesmo nome de classe e pertencem ao mesmo namespace

// Classes parciais são úteis para dividir grandes definições de classe em arquivos menores, facilitando a manutenção e organização do código

// As partes de uma classe parcial podem ser definidas em qualquer ordem e até mesmo em assemblies diferentes

// As partes de uma classe parcial devem ter o mesmo nível de acessibilidade (public, internal, etc.), o mesmo tipo de classe e o mesmo nome

// Quando a aplicação é compilada, o compilador combina todas as partes da classe parcial em uma única definição de classe

// Classes parciais são comumente usadas em geração de código automático (por exemplo, por ferramentas de design visual) e em cenários de separação de preocupações (como MVC)

// É importante notar que membros estáticos (campos, métodos, propriedades) não podem ser definidos em classes parciais
