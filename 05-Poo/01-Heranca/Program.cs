// Herança em C#:
// A herança é um dos pilares da programação orientada a objetos e permite que uma classe (chamada de classe derivada ou subclasse) herde características (métodos, propriedades, campos) de outra classe (chamada de classe base ou superclasse).
// Isso permite a reutilização de código e cria uma relação "é um" entre as classes.

// Sintaxe de declaração de uma classe derivada:
class Funcionario : Pessoa
{
    // Implementação da subclasse Funcionario
}

// Características da herança:

// 1. Extensão de funcionalidade:
//    Uma classe derivada pode estender ou adicionar funcionalidades à classe base, incluindo novos métodos, propriedades ou campos, além de sobrescrever os membros existentes, conforme necessário.

// 2. Reutilização de código:
//    A herança permite a reutilização de código, uma vez que os membros da classe base são herdados pela classe derivada, reduzindo a duplicação de código e facilitando a manutenção.

// 3. Relação "é um":
//    A herança modela uma relação "é um" entre a classe derivada e a classe base. Por exemplo, se temos uma classe base "Pessoa" e uma classe derivada "Funcionario", podemos dizer que "Funcionario" é um "Pessoa".

// 4. Modificadores de acesso:
//    Os membros herdados podem ter seus modificadores de acesso alterados na classe derivada. Por exemplo, um membro protegido na classe base pode ser acessado diretamente pela classe derivada.

// 5. Construtores:
//    A classe derivada pode chamar o construtor da classe base usando a palavra-chave "base" em seu próprio construtor, garantindo que a inicialização da classe base seja realizada corretamente.

// Exemplo de uso de herança:
class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

class Funcionario : Pessoa
{
    public int NumeroFuncionario { get; set; }
    public double Salario { get; set; }
}

// No exemplo acima, a classe "Funcionario" herda da classe "Pessoa" e adquire todas as suas características, incluindo as propriedades "Nome" e "Idade".
// Além disso, a classe "Funcionario" adiciona sua própria funcionalidade específica, como as propriedades "NumeroFuncionario" e "Salario".

// Herança é uma técnica poderosa na programação orientada a objetos que promove a reutilização de código e permite modelar relações hierárquicas entre classes de forma eficaz.

