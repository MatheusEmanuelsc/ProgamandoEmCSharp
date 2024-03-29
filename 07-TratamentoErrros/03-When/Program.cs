// Resumo - Filtros de Exceção em C#:

// Os filtros de exceção em C# são usados para condicionar a captura de exceções com base em uma expressão booleana. Eles permitem que você especifique condições adicionais para a captura de exceções, além do tipo de exceção.

// Características Principais:
// - Os filtros de exceção são introduzidos com a palavra-chave when após o bloco catch.
// - Eles consistem em uma expressão booleana que avalia se a captura da exceção deve ocorrer ou não.
// - Se a expressão retornar true, o bloco catch será executado; caso contrário, a exceção será propagada para blocos catch subsequentes ou para o código chamador.

// Sintaxe:
try
{
    // Código que pode gerar uma exceção
}
catch (TipoDeExcecao ex) when (condicao)
{
    // Código para tratamento da exceção, condicionado pela expressão booleana
}

// Exemplo de Uso:
try
{
    int resultado = 10 / 0; // Tentativa de divisão por zero
}
catch (DivideByZeroException ex) when (ex.Message.Contains("zero"))
{
    Console.WriteLine("Erro: Tentativa de divisão por zero.");
}

// Explicação:
// - Na sintaxe acima, "condicao" representa uma expressão booleana que determina se o bloco catch deve ser executado com base nas propriedades da exceção capturada.
// - Se a condição especificada for avaliada como true para a exceção capturada, o bloco catch será executado; caso contrário, a exceção será propagada para blocos catch subsequentes ou para o código chamador.
