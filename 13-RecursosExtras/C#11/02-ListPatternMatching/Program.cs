
// O que é correspondência de padrões de listas?

// A correspondência de padrões de listas é um novo recurso do C# 11 que permite comparar e analisar listas de forma mais concisa e eficiente. 
// Ela utiliza a sintaxe de correspondência de padrões para verificar se uma lista corresponde a um determinado padrão e, em caso positivo, 
// extrair informações específicas da lista.

// Benefícios da correspondência de padrões de listas:

// Código mais conciso: Reduz a quantidade de código necessária para comparar e analisar listas.
// Maior legibilidade: Torna o código mais fácil de entender e interpretar.
// Facilita a extração de informações: Permite extrair facilmente valores específicos da lista.
// Flexibilidade: Suporta uma variedade de padrões para comparação de listas.

// Sintaxe básica:

// A sintaxe básica para correspondência de padrões de listas utiliza o operador is e um padrão de lista. O padrão de lista pode ser composto por:

// Valores literais: Números, strings, valores booleanos, etc.
// Variáveis: Armazenam valores que podem ser comparados com os elementos da lista.
// Wildcards: Representam qualquer elemento da lista.
// Operadores de comparação: Permitem comparar elementos da lista com valores específicos.

// Exemplo:

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

if (numbers is [1, 2, ..]) // Verifica se a lista começa com 1 e 2
{
    Console.WriteLine("A lista começa com 1 e 2");
}

if (numbers is [var first, var second, ..]) // Extrai os dois primeiros elementos da lista
{
    Console.WriteLine($"Primeiro elemento: {first}, Segundo elemento: {second}");
}
// Use code with caution.

// Padrões de lista mais complexos:

// Verificação de tamanho da lista:
if (numbers is [_, _, _, _]) // Verifica se a lista tem 4 elementos
{
    Console.WriteLine("A lista tem 4 elementos");
}
// Use code with caution.

// Verificação de valores específicos:
if (numbers is [1, var x, 3, ..]) // Verifica se o segundo elemento é 2 e o quarto elemento é 3
{
    Console.WriteLine($"Segundo elemento: {x}");
}
// Use code with caution.

// Combinação de padrões:
if (numbers is [1, var x, 2, ..] or [1, 2, var y, ..]) // Verifica se a lista começa com 1 e 2 ou com 1 e 2
{
    Console.WriteLine("A lista começa com 1 e 2 ou com 1 e 2");
}
// Use code with caution.

// Recursos para aprender mais:

// Documentação da Microsoft sobre correspondência de padrões de listas: https://www.wikipedia.org/
// Tutoriais sobre correspondência de padrões de listas: https://www.youtube.com/
// Exemplos de código com correspondência de padrões de listas: https://github.com/

// Conclusão:

// A correspondência de padrões de listas é uma ferramenta poderosa que torna a análise e comparação de listas em C# mais eficiente e concisa. 
// Utilize-a para simplificar seu código, melhorar a legibilidade e extrair informações de listas de maneira mais fácil.
```