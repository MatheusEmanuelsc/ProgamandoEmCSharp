// Resumo - GetHashCode() e Equals() em C#:

// GetHashCode():
// - GetHashCode() é um método da classe Object em C# que retorna um código hash inteiro representando o objeto atual.
// - Este método é usado em algoritmos de hash e coleções que requerem acesso rápido aos objetos com base em seus valores hash.
// - A implementação padrão de GetHashCode() retorna um valor inteiro que é exclusivo para cada instância do objeto, mas isso pode variar dependendo da implementação específica da classe.
// - É importante que dois objetos que são considerados iguais pelo método Equals() tenham o mesmo valor retornado pelo método GetHashCode().

// Equals():
// - Equals() é um método da classe Object em C# que é usado para comparar dois objetos quanto à igualdade.
// - A implementação padrão de Equals() compara referências de memória para determinar se dois objetos são iguais.
// - Em muitas classes em C#, o método Equals() é substituído para realizar uma comparação de igualdade com base nos valores dos campos da classe.
// - É importante que a implementação de Equals() seja consistente com o método GetHashCode(), ou seja, se dois objetos são considerados iguais por Equals(), seus valores de hash devem ser iguais.

// Melhores práticas ao sobrescrever GetHashCode() e Equals():
// - Se uma classe sobrescrever Equals(), também deve sobrescrever GetHashCode() para garantir consistência.
// - GetHashCode() deve retornar o mesmo valor para dois objetos que são considerados iguais por Equals().
// - Se o custo computacional para calcular um hash único for muito alto, considere armazenar o hash calculado em uma variável e retorná-lo em chamadas subsequentes a GetHashCode().

// Exemplo de Implementação de GetHashCode() e Equals():

public class Pessoa
{
    public string Nome { get; }
    public int Idade { get; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Nome, Idade);
    }

    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Pessoa))
            return false;

        Pessoa outraPessoa = (Pessoa)obj;
        return Nome == outraPessoa.Nome && Idade == outraPessoa.Idade;
    }
}

// Uso:
var pessoa1 = new Pessoa("Alice", 30);
var pessoa2 = new Pessoa("Alice", 30);

Console.WriteLine(pessoa1.Equals(pessoa2)); // Saída: True
Console.WriteLine(pessoa1.GetHashCode() == pessoa2.GetHashCode()); // Saída: True

