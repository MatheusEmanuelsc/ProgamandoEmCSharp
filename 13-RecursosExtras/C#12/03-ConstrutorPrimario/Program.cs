```csharp
// Os construtores primários são uma novidade introduzida na linguagem C# 12. 
// Eles oferecem uma maneira simplificada e concisa de definir construtores para classes e structs.

// Características:

// Sintaxe simplificada: O construtor primário é definido diretamente na declaração da classe ou struct, 
// eliminando a necessidade de uma definição separada como em construtores tradicionais.
// Propriedades automáticas: Os parâmetros do construtor primário se tornam automaticamente propriedades públicas somente leitura 
// da classe ou struct.
// Sem inicialização manual: Não é necessário atribuir valores explicitamente aos campos da classe ou struct dentro do construtor primário. 
// O construtor inicializa automaticamente os campos com os valores passados aos parâmetros.

// Exemplo:

public class Pessoa
{
    public string Nome { get; } // Propriedade automática
    public int Idade { get; }  // Propriedade automática

    public Pessoa(string nome, int idade) // Construtor primário
    {
        // Não é necessária inicialização manual
    }
}
// Use code with caution.

// Vantagens:

// Código mais conciso: Reduz a quantidade de código necessária para definir construtores e propriedades.
// Melhora a legibilidade: Torna o código mais fácil de entender e interpretar.
// Menos propensão a erros: Evita erros comuns de inicialização de campos.

// Restrições:

// Apenas para parâmetros com inicializadores: Os parâmetros do construtor primário devem ter inicializadores 
// (valor padrão, expressão, etc.).
// Não é possível misturar com construtores tradicionais: Uma classe ou struct com construtor primário 
// não pode ter construtores tradicionais definidos separadamente.

// Quando usar construtores primários:

// Classes ou structs com um conjunto limitado de propriedades imutáveis.
// Cenários onde todos os campos precisam ser inicializados no momento da criação da instância.

// Conclusão:

// Os construtores primários são uma adição valiosa ao C#, tornando a definição de classes e structs imutáveis 
// mais simples e eficiente. Utilize-os para simplificar seu código e melhorar a legibilidade, mas lembre-se 
// das restrições e casos de uso adequados.
