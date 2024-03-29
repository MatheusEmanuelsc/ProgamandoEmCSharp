// Resumo - Bloco try-catch-finally em C#:

// O bloco try-catch-finally em C# é usado para manipular exceções em um programa. Ele permite que você escreva código que pode lançar exceções e capture essas exceções para lidar com elas de maneira controlada.

// Características Principais:
// - O bloco try contém o código que pode gerar uma exceção. Ele é seguido por um ou mais blocos catch para lidar com as exceções lançadas.
// - O bloco catch captura exceções específicas ou genéricas e fornece o código para lidar com elas.
// - O bloco finally (opcional) é usado para executar código que deve ser executado independentemente de ocorrer ou não uma exceção. Ele geralmente é usado para liberar recursos, como fechar arquivos ou conexões de banco de dados.

// Sintaxe:
try
{
    // Código que pode gerar uma exceção
}
catch (TipoDeExcecao1 nomeDaExcecao1)
{
    // Código para lidar com a exceção do TipoDeExcecao1
}
catch (TipoDeExcecao2 nomeDaExcecao2)
{
    // Código para lidar com a exceção do TipoDeExcecao2
}
finally
{
    // Código que será executado sempre, independentemente de ocorrer ou não uma exceção
}

// Exemplo de Uso 1:
try
{
    // Código que pode gerar uma exceção
    int resultado = 10 / 0; // Tentativa de divisão por zero
}
catch (DivideByZeroException ex)
{
    // Código para lidar com a exceção de divisão por zero
    Console.WriteLine("Erro: Tentativa de divisão por zero.");
}
finally
{
    // Código que será executado sempre, independentemente de ocorrer ou não uma exceção
    Console.WriteLine("Bloco finally: Recursos liberados.");
}

// Exemplo de Uso 2:
try
{
    // Código que pode gerar uma exceção
    Console.WriteLine("Bloco try: Tentando executar código que pode gerar uma exceção...");
    int resultado = 10 / 0; // Tentativa de divisão por zero, que lançará uma exceção
    Console.WriteLine("O resultado da divisão é: " + resultado); // Esta linha nunca será alcançada devido à exceção
}
catch (DivideByZeroException ex)
{
    // Código para tratar a exceção específica de divisão por zero
    Console.WriteLine("Bloco catch: Exceção capturada! Mensagem: " + ex.Message);
}
finally
{
    // Código que sempre será executado, independentemente de exceções
    Console.WriteLine("Bloco finally: Executando limpeza ou operações que sempre devem ocorrer...");
}
