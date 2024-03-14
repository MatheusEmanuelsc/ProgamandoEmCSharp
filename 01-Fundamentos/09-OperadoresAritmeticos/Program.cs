// Operadores aritméticos:
Console.WriteLine($"Operador de Adição (+): 10 + 5 = {10 + 5}");
Console.WriteLine($"Operador de Subtração (-): 10 - 5 = {10 - 5}");
Console.WriteLine($"Operador de Multiplicação (*): 10 * 5 = {10 * 5}");
Console.WriteLine($"Operador de Divisão (/): 10 / 5 = {10 / 5}");
Console.WriteLine($"Operador de Módulo (%): 10 % 3 = {10 % 3}");
Console.WriteLine($"Operador de Incremento (++) e Decremento (--):");

int x = 10;
Console.WriteLine($"x antes do incremento: {x}");
Console.WriteLine($"x++: {x++}"); // incremento pós-fixado
Console.WriteLine($"x após o incremento: {x}");

int y = 10;
Console.WriteLine($"y antes do decremento: {y}");
Console.WriteLine($"--y: {--y}"); // decremento pré-fixado
Console.WriteLine($"y após o decremento: {y}");

Console.WriteLine($"Operador de Negativo Unário (-): -5 = {-5}");

// Operadores de Atribuição:
int a = 10;
int b = 5;
int c;

c = a; // Operador de Atribuição simples
Console.WriteLine($"Operador de Atribuição simples: c = a, c = {c}");

c += a; // Operador de Atribuição de Adição
Console.WriteLine($"Operador de Atribuição de Adição: c += a, c = {c}");

c -= a; // Operador de Atribuição de Subtração
Console.WriteLine($"Operador de Atribuição de Subtração: c -= a, c = {c}");

c *= a; // Operador de Atribuição de Multiplicação
Console.WriteLine($"Operador de Atribuição de Multiplicação: c *= a, c = {c}");

c /= a; // Operador de Atribuição de Divisão
Console.WriteLine($"Operador de Atribuição de Divisão: c /= a, c = {c}");

c %= a; // Operador de Atribuição de Módulo
Console.WriteLine($"Operador de Atribuição de Módulo: c %= a, c = {c}");



// C# Tem suporte a classe Math