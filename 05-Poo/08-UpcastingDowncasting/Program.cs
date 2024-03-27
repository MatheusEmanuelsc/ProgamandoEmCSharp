// Herança, Upcasting e Downcasting em C#:

// Herança:
// Em C#, herança é o conceito onde uma classe (chamada de classe derivada) pode herdar características (métodos, propriedades, campos) de outra classe (chamada de classe base ou superclasse).
// Isso permite a reutilização de código e cria uma relação "é um" entre as classes, onde a classe derivada é uma extensão da classe base.

// Upcasting:
// Upcasting é o processo de converter uma referência de uma classe derivada para uma referência de uma classe base.
// Isso é feito implicitamente pelo compilador e é seguro, pois uma classe derivada possui todos os membros da classe base, então não há perda de informações.

// Exemplo de Upcasting:
// Classe base
class Animal
{
    public void EmitirSom()
    {
        Console.WriteLine("Som genérico de animal");
    }
}

// Classe derivada
class Cachorro : Animal
{
    public void Latir()
    {
        Console.WriteLine("Au au!");
    }
}

// Upcasting
Animal animal = new Cachorro(); // Upcasting de Cachorro para Animal

// Downcasting:
// Downcasting é o processo de converter uma referência de uma classe base para uma referência de uma classe derivada.
// Isso precisa ser feito explicitamente pelo programador e requer a verificação de tipo para garantir que a conversão seja segura.

// Exemplo de Downcasting:
// Downcasting
if (animal is Cachorro)
{
    Cachorro cachorro = (Cachorro)animal; // Downcasting de Animal para Cachorro
    cachorro.Latir(); // Acessando método específico de Cachorro
}

// É importante ter cuidado ao realizar downcasting, pois se a referência não for do tipo correto, uma exceção InvalidCastException será lançada em tempo de execução.

// Upcasting e downcasting são técnicas importantes na programação orientada a objetos que permitem manipular hierarquias de classes de forma flexível e segura.

