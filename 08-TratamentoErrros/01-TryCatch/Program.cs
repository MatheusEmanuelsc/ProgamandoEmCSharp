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



// Explicação:

// O bloco try é usado para envolver o código que pode lançar uma exceção. Se uma exceção ocorrer dentro deste bloco, o controle será transferido para o bloco catch correspondente.

// O bloco catch é usado para capturar e lidar com exceções que são lançadas dentro do bloco try. Você pode especificar o tipo de exceção que deseja capturar, como DivideByZeroException neste exemplo, ou capturar uma exceção genérica Exception para lidar com qualquer tipo de exceção.

// O bloco finally é usado para definir código que sempre será executado, independentemente de uma exceção ser lançada ou não dentro do bloco try. É comumente usado para limpeza de recursos ou para executar operações que devem ocorrer, mesmo em caso de exceção.