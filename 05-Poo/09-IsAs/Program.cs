// Operador "is" e Padrão de Correspondência "as" em C#:

// Operador "is":
// O operador "is" é usado para verificar se um objeto é de um determinado tipo em tempo de execução.
// Ele retorna true se o objeto for do tipo especificado e false caso contrário.

// Exemplo de uso do operador "is":
object obj = "Olá, mundo!";
if (obj is string)
{
    Console.WriteLine("O objeto é uma string.");
}
else
{
    Console.WriteLine("O objeto não é uma string.");
}

// Padrão de Correspondência "as":
// O padrão de correspondência "as" é usado para tentar converter um objeto para um tipo especificado. Se a conversão for bem-sucedida, o resultado será o objeto convertido; caso contrário, será null.

// Exemplo de uso do padrão de correspondência "as":
object obj2 = "123";
string str = obj2 as string;
if (str != null)
{
    Console.WriteLine("A conversão para string foi bem-sucedida: " + str);
}
else
{
    Console.WriteLine("A conversão para string falhou.");
}

// O operador "is" e o padrão de correspondência "as" são úteis para verificar tipos e realizar conversões seguras em tempo de execução em C#.
