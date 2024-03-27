// Classes Abstratas em C#:

// Uma classe abstrata é uma classe que não pode ser instanciada diretamente.
// Ela é projetada para ser usada como uma classe base para outras classes e pode conter métodos abstratos, métodos concretos, propriedades, campos, eventos, etc.

// Sintaxe de declaração de uma classe abstrata:
// abstract class NomeDaClasse
// {
//     // Definições de membros da classe
// }

// Métodos Abstratos:
// Um método abstrato é um método declarado sem implementação na classe abstrata.
// Ele deve ser implementado nas classes derivadas.
// Para declarar um método como abstrato, utilize a palavra-chave "abstract" antes do tipo de retorno.

// Exemplo de classe abstrata com método abstrato:
abstract class Animal
{
    public abstract void EmitirSom(); // Método abstrato
}

// Classes Derivadas:
// As classes que herdam de uma classe abstrata devem fornecer implementações para todos os métodos abstratos definidos na classe base.

// Exemplo de classe derivada de uma classe abstrata:
class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Au au!");
    }
}

// Instanciação de Objetos:
// Como uma classe abstrata não pode ser instanciada diretamente, você só pode criar instâncias das classes derivadas.

// Exemplo de uso de uma classe derivada:
Animal animal = new Cachorro();
animal.EmitirSom(); // Saída: "Au au!"

// Benefícios das Classes Abstratas:
// 1. Projetar uma hierarquia de classes compartilhando comportamentos comuns.
// 2. Forçar a implementação de métodos em classes derivadas.
// 3. Promover o reuso de código e manter a coesão e o baixo acoplamento.

// Classes abstratas são uma parte essencial da programação orientada a objetos em C#, permitindo a criação de hierarquias de classes flexíveis e extensíveis.
