// Operadores Relacionais:
int x = 10;
int y = 5;

Console.WriteLine($"Operador Igual a (==): {x} == {y} é {x == y}");
Console.WriteLine($"Operador Diferente de (!=): {x} != {y} é {x != y}");
Console.WriteLine($"Operador Maior que (>): {x} > {y} é {x > y}");
Console.WriteLine($"Operador Menor que (<): {x} < {y} é {x < y}");
Console.WriteLine($"Operador Maior ou Igual a (>=): {x} >= {y} é {x >= y}");
Console.WriteLine($"Operador Menor ou Igual a (<=): {x} <= {y} é {x <= y}");

// Operadores Lógicos:
bool a = true;
bool b = false;

Console.WriteLine($"Operador E lógico (&&): {a} && {b} é {a && b}");
Console.WriteLine($"Operador OU lógico (||): {a} || {b} é {a || b}");
Console.WriteLine($"Operador NÃO lógico (!): !{a} é {!a}");


//Operador Ternario
int x = 10;
int y = 5;

// Operador Ternário (condição ? expressão1 : expressão2)
Console.WriteLine($"O maior número entre {x} e {y} é {(x > y ? x : y)}");

// Outro exemplo
string result = (x % 2 == 0) ? "par" : "ímpar";
Console.WriteLine($"O número {x} é {result}");
