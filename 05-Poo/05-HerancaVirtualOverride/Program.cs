// Herança Virtual e Override em C#:
// Em C#, você pode modificar o comportamento de métodos herdados de uma classe base em uma classe derivada usando herança virtual e a palavra-chave "override".
// Isso permite que você substitua a implementação de um método na classe derivada, mantendo a estrutura geral da classe base.

// Herança Virtual:

// 1. Métodos virtuais:
//    Um método virtual em uma classe base pode ser sobrescrito em classes derivadas. Isso permite que a implementação do método seja substituída nas classes derivadas.
//    Para declarar um método como virtual, você deve usar a palavra-chave "virtual".

// Exemplo de declaração de método virtual:
class ClasseBase
{
    public virtual void MetodoVirtual()
    {
        // Implementação do método na classe base
    }
}

// Override:

// 1. Sobrescrita de método:
//    Ao herdar de uma classe base que possui um método virtual, você pode substituir a implementação desse método na classe derivada usando a palavra-chave "override".
//    O método na classe derivada deve ter a mesma assinatura (nome, tipo de retorno e parâmetros) do método virtual na classe base.

// Exemplo de sobrescrita de método usando "override":
class ClasseDerivada : ClasseBase
{
    public override void MetodoVirtual()
    {
        // Nova implementação do método na classe derivada
    }
}

// Características do uso de herança virtual e override:

// 1. Flexibilidade de implementação:
//    O uso de métodos virtuais e override permite que você substitua o comportamento de métodos em classes derivadas sem modificar a classe base.
//    Isso facilita a personalização do comportamento de métodos para atender às necessidades específicas de uma classe derivada.

// 2. Polimorfismo:
//    Herança virtual e override são fundamentais para o polimorfismo em C#, onde um objeto pode se comportar de diferentes maneiras com base em sua classe real.

// 3. Controle de chamada:
//    Ao chamar um método na classe derivada, o compilador garante que a implementação correta (da classe derivada) do método seja chamada, mesmo que o método seja chamado através de uma referência da classe base.

// Herança virtual e override são recursos poderosos em C# que permitem uma hierarquia de classes flexível e orientada a objetos, promovendo o reuso de código e a capacidade de adaptação a requisitos específicos.

