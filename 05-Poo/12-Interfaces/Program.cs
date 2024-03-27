// Resumo - Interfaces em C#:

// Interfaces em C# são contratos que definem um conjunto de membros (métodos, propriedades, eventos e indexadores) que as classes devem implementar.
// Elas fornecem um mecanismo para definir comportamentos esperados sem especificar a implementação concreta.

// Sintaxe de declaração de uma interface:
// interface IExemplo
// {
//     // Declaração de membros da interface
// }

// 1. Abstração: Interfaces permitem a abstração de comportamentos comuns em um contrato que pode ser implementado por várias classes. Isso promove a coesão e a modularidade do código, facilitando a manutenção e a extensibilidade.

// Exemplo de Abstração:
interface IAnimal
{
    void EmitirSom();
}

class Cachorro : IAnimal
{
    public void EmitirSom()
    {
        Console.WriteLine("Au au!");
    }
}

// 2. Polimorfismo: O uso de interfaces facilita a criação de código polimórfico, onde várias classes podem ser tratadas de forma uniforme, independentemente de sua implementação concreta. Isso promove a flexibilidade e a reutilização de código.

// Exemplo de Polimorfismo:
void FazerSom(IAnimal animal)
{
    animal.EmitirSom();
}

// 3. Múltipla Implementação: Uma classe em C# pode implementar várias interfaces, permitindo que ela forneça múltiplos comportamentos definidos pelas interfaces.

// Exemplo de Múltipla Implementação:
interface ICalculadora
{
    int Somar(int a, int b);
    int Subtrair(int a, int b);
}

class Calculadora : ICalculadora
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public int Subtrair(int a, int b)
    {
        return a - b;
    }
}

// 4. Extensibilidade: Interfaces podem ser usadas para estender a funcionalidade de classes existentes sem modificar sua estrutura. Novas interfaces podem ser introduzidas para especificar novos comportamentos que as classes podem optar por implementar.

// Exemplo de Extensibilidade:
interface IExtensoes
{
    void NovaFuncionalidade();
}

class MinhaClasse : IExtensoes
{
    public void NovaFuncionalidade()
    {
        // Implementação da nova funcionalidade
    }
}

// 5. Implementações Padrão: A partir do C# 8.0, interfaces podem incluir implementações padrão (default implementations) para métodos. Isso permite que interfaces definam comportamentos padrão para métodos, reduzindo a necessidade de duplicação de código em implementações de classes.

// Exemplo de Implementações Padrão:
interface IExemplo
{
    public static abstract void MetodoEstatico(); // Método estático abstrato
}

// Interfaces são uma parte fundamental da programação orientada a objetos em C#, proporcionando uma maneira flexível e poderosa de definir contratos, promover o polimorfismo e facilitar a extensibilidade do código.
