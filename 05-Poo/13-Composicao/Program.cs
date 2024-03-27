// Resumo - Composição em C#:

// Composição é um princípio de design em que objetos complexos são construídos a partir de outros objetos mais simples.
// Em C#, a composição é implementada quando uma classe inclui instâncias de outras classes como membros.

// Exemplo de Composição:
class Motor
{
    public void Ligar()
    {
        // Lógica para ligar o motor
    }

    public void Desligar()
    {
        // Lógica para desligar o motor
    }
}

class Carro
{
    private Motor motor = new Motor(); // Composição: Carro tem um motor

    public void LigarCarro()
    {
        motor.Ligar(); // Chama o método Ligar do objeto Motor
    }

    public void DesligarCarro()
    {
        motor.Desligar(); // Chama o método Desligar do objeto Motor
    }
}

// Neste exemplo, a classe Carro possui uma composição com a classe Motor.
// O objeto Carro contém uma instância da classe Motor como membro, e pode chamar os métodos da classe Motor como se fossem seus próprios métodos.

// Benefícios da Composição:
// 1. Reutilização de código: A composição permite reutilizar funcionalidades existentes encapsuladas em outras classes.
// 2. Separação de responsabilidades: Cada classe é responsável por uma parte específica do comportamento, promovendo a coesão e a modularidade do código.
// 3. Flexibilidade: É possível alterar as partes componentes de um objeto sem afetar outras partes do sistema.

// Composição é uma abordagem poderosa para projetar sistemas modulares e flexíveis em C#, permitindo a construção de objetos complexos a partir de componentes simples.


// outro exemplo



// Definição da classe Produto
class Produto
{
    public int Id { get; }
    public string Nome { get; }
    public decimal Preco { get; }

    // Construtor
    public Produto(int id, string nome, decimal preco)
    {
        Id = id;
        Nome = nome;
        Preco = preco;
    }
}

// Definição da classe Pedido
class Pedido
{
    private readonly Produto produto;

    // Construtor
    public Pedido(Produto produto)
    {
        this.produto = produto;
    }

    // Método para obter o nome do produto
    public string ObterNomeDoProduto()
    {
        return produto.Nome;
    }
}
