// Atributos Genéricos em C# 11

// Atributos genéricos, introduzidos no C# 11, fornecem uma maneira mais flexível e poderosa de associar metadados a elementos do código usando tipos genéricos. Eles permitem que os atributos especifiquem o tipo de dados que eles aceitam, tornando o código mais reutilizável e menos propenso a erros.

// Benefícios dos Atributos Genéricos:

// Melhora da tipagem: Aumenta a segurança do código ao garantir que os atributos recebam o tipo de dados correto.
// Reutilização: Permite criar atributos genéricos que podem ser usados com vários tipos de dados.
// Menos código repetitivo: Evita a necessidade de criar atributos separados para cada tipo de dado que você deseja usar.
// Redução de erros: A verificação de tipo em tempo de compilação captura erros de uso incorreto de atributos.

// Como funcionam:

// Definição de um atributo genérico: Você declara um atributo usando a palavra-chave class seguida do nome do atributo e o símbolo <T>, indicando o tipo genérico.
// Restrições de tipo (opcional): Você pode definir restrições sobre o tipo genérico usando interfaces ou classes base entre colchetes <T : IComparable<T>>.
// Parâmetros do atributo: O atributo genérico pode ter parâmetros que aceitam o tipo genérico T ou outros tipos específicos.

// Exemplo:

public class ValidarValorAttribute<T> where T : IComparable<T>
{
  public T ValorMinimo { get; set; }
  public T ValorMaximo { get; set; }

  public ValidarValorAttribute(T valorMinimo, T valorMaximo)
  {
    ValorMinimo = valorMinimo;
    ValorMaximo = valorMaximo;
  }
}

public class Pessoa
{
  [ValidarValor(18, 120)] // Atributo genérico com restrição e parâmetros
  public int Idade { get; set; }
}
// Use code with caution.

// Observações importantes:

// Atributos genéricos não podem ser usados diretamente com o tipo dynamic.
// Você pode acessar o tipo genérico T dentro do atributo usando o nome T.

// Quando usar atributos genéricos:

// Cenários onde você precisa associar metadados a elementos do código com base em diferentes tipos de dados.
// Criando validações ou decorações que precisam funcionar com vários tipos.

// Conclusão:

// Atributos genéricos são uma adição valiosa ao C# 11 que melhora a tipagem, a reutilização de código e a segurança geral do código. Utilize-os para criar metadados flexíveis e adaptáveis para seus elementos de código.
