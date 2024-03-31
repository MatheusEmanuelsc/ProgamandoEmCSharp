
// File-Scoped Types em C# 11: Um mergulho profundo

// File-scoped types, introduzidos no C# 11, são um novo modificador de acesso que permite definir tipos (classes, structs, interfaces, enums, delegates) com escopo limitado ao arquivo fonte onde eles são declarados. Isso significa que esses tipos não são visíveis fora do arquivo em que estão definidos.

// Benefícios do File-Scoped Types:

// Prevenção de conflitos de nomes: Reduz a chance de conflitos de nomes com outros tipos no mesmo namespace ou assembly, especialmente em projetos grandes com vários arquivos de código.
// Melhora a encapsulação: Mantém os tipos internos privados ao arquivo, tornando o código mais modular e organizado.
// Código mais limpo: Evita a necessidade de expor tipos internos que não são utilizados em outros arquivos.

// Sintaxe:

// Você define um file-scoped type usando a palavra-chave file como modificador de acesso antes da declaração do tipo.

file class MyClass {
  // ... membros da classe
}

file interface MyInterface {
  // ... membros da interface
}
// Use code with caution.

// Restrições:

// File-scoped types não podem ser usados com outros modificadores de acesso como public, internal, etc.
// Eles não podem ser herdados de ou herdar outros tipos.
// Não é possível declarar construtores públicos para file-scoped types.

// Casos de uso:

// Tipos usados internamente por uma classe específica e não precisam ser expostos externamente.
// Tipos auxiliares usados para processamento interno em um arquivo específico.
// Evitar expor implementações privadas de interfaces.

// Exemplo:

// Imagine que você tenha um arquivo chamado MathOperations.cs que define operações matemáticas básicas. Você pode usar file-scoped types para encapsular classes internas para adição e subtração:

public static class MathOperations
{
  file class Addition
  {
    public static int Add(int a, int b)
    {
      return a + b;
    }
  }

  file class Subtraction
  {
    public static int Subtract(int a, int b)
    {
      return a - b;
    }
  }

  public static int AddNumbers(int a, int b)
  {
    return Addition.Add(a, b);
  }

  public static int SubtractNumbers(int a, int b)
  {
    return Subtraction.Subtract(a, b);
  }
}
// Use code with caution.

// Conclusão:

// File-scoped types são uma adição útil ao C# 11 que ajuda a organizar o código, prevenir conflitos de nomes e melhorar a encapsulação. Utilize-os para tipos internos que não precisam ser expostos em outros arquivos do projeto.
