// Structs com Auto-inicialização em C# 11

// Os structs com auto-inicialização (também conhecidos como auto-default structs) são um recurso introduzido no C# 11 que simplifica a criação e inicialização de structs. Eles eliminam a necessidade de construtores explícitos para inicializar campos não atribuídos no momento da criação da instância.

// Como funciona:

// Campos não inicializados: Quando você declara um struct e deixa alguns campos sem inicialização no construtor, o compilador C# 11 entra em ação.
// Inicialização automática: O compilador identifica os campos não inicializados e os inicializa automaticamente com seus valores padrão antes de executar o código do construtor.

// Benefícios:
// Código mais conciso: Reduz a quantidade de código necessária para criar e inicializar structs, especialmente para structs com muitos campos.
// Menos propensão a erros: Evita erros causados por esquecer de inicializar campos no construtor.
// Melhora a legibilidade: O código fica mais claro e fácil de entender, pois a inicialização implícita é automática.

// Exemplo:

public struct Pessoa
{
  public string Nome { get; set; }
  public int Idade { get; set; }

  public Pessoa(string nome) // Construtor que define apenas o nome
  {
    Nome = nome;
  }
}

Pessoa pessoa1 = new Pessoa("João"); // Idade será inicializada automaticamente com 0 (valor padrão)

Console.WriteLine($"Nome: {pessoa1.Nome}, Idade: {pessoa1.Idade}");
// Use code with caution.

// Observações importantes:

// A auto-inicialização só funciona para campos que possuem valores padrão.
// Se um campo não possui um valor padrão (como uma referência de classe sem inicialização), o compilador emitirá um erro.
// Você ainda pode definir construtores explícitos para inicializar todos os campos manualmente, se necessário.

// Quando usar structs com auto-inicialização:

// Structs imutáveis com valores padrão bem definidos para todos os campos.
// Cenários onde a inicialização explícita de todos os campos no construtor seria redundante.

// Conclusão:

// Structs com auto-inicialização são uma adição valiosa ao C# 11 que torna a criação de structs mais simples e eficiente. Utilize-os para simplificar seu código, melhorar a legibilidade e evitar erros de inicialização.
