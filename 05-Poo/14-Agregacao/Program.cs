// Resumo - Agregação em C#:

// Agregação é um conceito de relacionamento entre classes em que uma classe "contém" ou "é composta por" outra classe. 
// Em C#, isso é representado quando uma classe tem uma ou mais instâncias de outra classe como membros, mas essas instâncias podem existir independentemente da classe que as contém.

// Principais características da Agregação:

// 1. Associação Fraca: A classe que contém os objetos agregados não é responsável por criar ou destruir esses objetos. 
//    Eles podem existir independentemente da classe contenedora e podem ser compartilhados entre várias instâncias de diferentes classes.

// 2. Relacionamento Todo-Parte: A agregação é frequentemente usada para modelar um relacionamento "todo-parte", 
//    onde uma classe representa um "todo" que consiste em várias partes representadas por outras classes.

// 3. Reutilização de Objetos: A agregação permite a reutilização de objetos, pois as instâncias dos objetos agregados 
//    podem ser compartilhadas entre várias classes.

// 4. Flexibilidade e Modularidade: A agregação torna o código mais flexível e modular, pois permite que as partes de um sistema 
//    sejam alteradas ou substituídas independentemente umas das outras.

// Exemplo de Agregação em C#:

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
    private Produto produto; // Agregação: Pedido tem um Produto

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
