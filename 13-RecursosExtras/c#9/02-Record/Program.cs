// Introdução:

// O Record é um tipo de classe especial introduzido no C# 9.0 para representar dados imutáveis e comparáveis. São projetados para serem concisos, eficientes e fáceis de usar, tornando-os ideais para modelar entidades com um conjunto bem definido de propriedades.

// Características dos Records:

// Imutabilidade: Uma vez criado, um Record não pode ser modificado. Isso garante a consistência do estado do objeto e facilita o raciocínio sobre o código.
// Comparação de valor: Dois Records são considerados iguais se seus valores de propriedade forem iguais. Isso simplifica a comparação de objetos e a implementação de coleções.
// Desconstrução: Records podem ser facilmente desconstruídos em seus componentes individuais, facilitando o acesso aos valores das propriedades.
// Construtores com nome: Records podem ter construtores com nome para inicializar suas propriedades de forma flexível.
// ToString() implícito: Records possuem uma implementação implícita do método ToString() que gera uma string de representação textual clara e concisa.
// Suporte a interfaces: Records podem implementar interfaces para fornecer funcionalidades adicionais.
// Herança: Records podem herdar de outras classes e Records, permitindo reuso de código e implementação de polimorfismo.

// Exemplos de Records:

public record Pessoa(string Nome, int Idade); // Record simples com duas propriedades

public record Ponto3D(double X, double Y, double Z) : IComparable<Ponto3D> // Record com herança e implementação de interface
{
    public int CompareTo(Ponto3D other) => ...; // Implementação da comparação de valor
}

// Benefícios do uso de Records:

// Código mais conciso: Reduz a quantidade de código necessária para definir classes imutáveis.
// Maior segurança: Garante a imutabilidade dos dados, evitando erros de modificação acidental.
// Melhor legibilidade: O código fica mais claro e fácil de entender.
// Desempenho eficiente: Records são otimizados para uso eficiente de memória e CPU.

// Palavra-chave "with":

// A palavra-chave with é usada em conjunto com Records para criar novas instâncias com base em um Record existente, modificando apenas as propriedades especificadas. Isso torna a atualização de valores específicos em um Record muito mais concisa e legível.

// Exemplo:

Pessoa pessoa1 = new Pessoa("João", 30);
Pessoa pessoa2 = pessoa1 with { Idade = 31 }; // Cria uma nova pessoa com a idade alterada

Console.WriteLine(pessoa1.Idade); // Saída: 30
Console.WriteLine(pessoa2.Idade); // Saída: 31

// Casos de uso:

// Atualização de propriedades específicas: Permite modificar valores específicos em um Record sem precisar recriar toda a instância.
// Criação de variantes de um Record: Facilita a criação de novas instâncias com pequenas alterações em relação a um Record base.
// Implementação de padrões de design: Pode ser usado para implementar padrões como Builder e Immutable.

// Observações:

// A palavra-chave with só pode ser usada com Records.
// As propriedades que você deseja modificar precisam ser especificadas após o with.
// Você pode usar expressões para definir os novos valores das propriedades.

// Recursos adicionais:

// Documentação oficial da Microsoft sobre Records: https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/records
// Tutoriais e exemplos de uso de Records: https://m.youtube.com/watch?v=M_TQgNKAie8

// Conclusão:

// Records são uma ferramenta poderosa e versátil para modelar dados imutáveis em C#. Eles oferecem diversos benefícios em termos de concisão, segurança, legibilidade e desempenho. A palavra-chave with complementa o uso de Records, permitindo a atualização de propriedades específicas de forma concisa e legível. Se você precisa trabalhar com dados imutáveis, considere usar Records para simplificar seu código e melhorar a qualidade geral do seu software. 

// Exemplos Adicionais de Records em C# 9.0

// 1. Record com Propriedade de Navegação:

public record Pessoa(string Nome, int Idade)
{
    public Endereço Endereço { get; init; } // Propriedade de navegação para um Record Endereço
}

public record Endereço(string Rua, string Cidade, string CEP)
{
}

// 2. Record com Propriedade Computada:

public record Pessoa(string Nome, DateTime DataNascimento)
{
    public int Idade => DateTime.Now.Year - DataNascimento.Year; // Propriedade computada que calcula a idade

    public string Signo => GetSigno(DataNascimento.Month, DataNascimento.Day); // Propriedade computada que obtém o signo

    private static string GetSigno(int mes, int dia)
    {
        // Implementação da lógica para obter o signo
    }
}

// 3. Record com Construtor com Nome:

public record Pessoa(string Nome, int Idade)
{
    public Pessoa(string nomeCompleto) : this(nomeCompleto.Split(' ')[0], nomeCompleto.Split(' ')[1])
    {
    }
}

Pessoa pessoa1 = new Pessoa("João Silva"); // Usa o construtor com nome para inicializar com nome completo

// 4. Record com Herança:

public record Animal(string Nome, string Especie)

public record Cachorro(string Nome, string Raca) : Animal(Nome, "Cachorro")

public record Gato(string Nome, string Cor) : Animal(Nome, "Gato")

// 5. Comparação de Records:

Pessoa pessoa1 = new Pessoa("João", 30);
Pessoa pessoa2 = new Pessoa("João", 30);

if (pessoa1 == pessoa2)
{
    Console.WriteLine("As pessoas são iguais");
}

// 6. Desconstrução de Records:

Pessoa pessoa = new Pessoa("João", 30);

(string nome, int idade) = pessoa;

Console.WriteLine($"Nome: {nome}, Idade: {idade}");

// 7. Usando a palavra-chave "with":

Pessoa pessoa1 = new Pessoa("João", 30);
Pessoa pessoa2 = pessoa1 with { Idade = 31 };

Console.WriteLine(pessoa1.Idade); // Saída: 30
Console.WriteLine(pessoa2.Idade); // Saída: 31

// 8. Usando Records em Coleções:

List<Pessoa> pessoas = new List<Pessoa>()
{
    new Pessoa("João", 30),
    new Pessoa("Maria", 25),
    new Pessoa("Pedro", 40),
};

var pessoaMaisVelha = pessoas.OrderBy(p => p.Idade).Last();

Console.WriteLine($"Pessoa mais velha: {pessoaMaisVelha.Nome}");

// 9. Usando Records em APIs:

public record PessoaDto(string Nome, int Idade);

public class PessoaService
{
    public PessoaDto GetPessoa(int id)
    {
        // Implementação da lógica para obter a pessoa do banco de dados
        return new PessoaDto("João", 30);
    }
}

