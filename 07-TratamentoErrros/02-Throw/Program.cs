// Resumo - Lançamento e Relançamento de Exceções em C#:

// O lançamento de exceções em C# é usado para sinalizar condições excepcionais durante a execução do programa. Isso permite que você notifique o código chamador sobre problemas que ocorreram durante a execução.

// Características Principais:
// - Exceções podem ser lançadas explicitamente usando a palavra-chave throw.
// - Você pode lançar exceções pré-definidas do .NET, como ArgumentException, InvalidOperationException, etc., ou criar suas próprias exceções personalizadas derivando da classe Exception.
// - As exceções podem conter informações adicionais, como mensagens de erro, detalhes do problema e exceções internas, para ajudar na depuração e tratamento adequado.

// Sintaxe de Lançamento:
throw new TipoDeExcecao("mensagem de erro");

// Exemplo de Lançamento de Exceção:
int idade = -5;
if (idade < 0)
{
    throw new ArgumentException("Idade não pode ser negativa.");
}

// Relançamento de Exceções:
// - O relançamento de exceções ocorre quando você captura uma exceção em um bloco catch e decide lançá-la novamente para o código chamador ou para outro bloco catch.
// - Você pode relançar a mesma exceção capturada ou criar uma nova exceção baseada na exceção original.
// - Isso é útil quando você deseja tratar a exceção em um nível mais alto da pilha de chamadas ou quando deseja adicionar informações adicionais à exceção antes de relançá-la.

// Sintaxe de Relançamento:
catch (TipoDeExcecao ex)
{
    // Código para tratamento da exceção
    // Relançamento da exceção
    throw;
}

// Exemplo de Relançamento de Exceção:
try
{
    // Código que pode gerar uma exceção
    int resultado = 10 / 0; // Tentativa de divisão por zero
}
catch (DivideByZeroException ex)
{
    // Log da exceção
    Console.WriteLine("Erro: Tentativa de divisão por zero.");
    // Relançamento da exceção original
    throw;
}
