// Resumo sobre deconstrutores:
// - Os deconstrutores permitem extrair os valores de um objeto em componentes individuais.
// - Eles são úteis quando você deseja desmembrar um objeto complexo em suas partes constituintes.
// - Um deconstrutor é um método especial com o nome 'Deconstruct', que pode ser declarado em uma classe ou struct.
// - O deconstrutor pode ter qualquer número de parâmetros de saída, que representam os componentes individuais do objeto.
// - Os deconstrutores podem ser usados em conjunto com a sintaxe de desconstrução para extrair os valores de um objeto.

// Exemplo de classe com deconstrutor
class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    // Deconstrutor
    public void Deconstruct(out string nome, out int idade)
    {
        nome = Nome;
        idade = Idade;
    }
}

// Exemplo de uso de deconstrutor
class Program
{
    static void Main()
    {
        var pessoa = new Pessoa("Alice", 30);

        // Utilizando a sintaxe de desconstrução
        var (nome, idade) = pessoa;
        Console.WriteLine($"Nome: {nome}, Idade: {idade}"); // Saída: Nome: Alice, Idade: 30
    }
}
