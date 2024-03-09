
// \a - Alerta sonoro (emite um som de alerta)
Console.WriteLine("Hello\aWorld");

// \b - Retrocesso (move o cursor uma posição para trás)
Console.WriteLine("Hello\bWorld");

// \f - Avanço de página (avança para a próxima página)
Console.WriteLine("Hello\fWorld");

// \n - Nova linha (insere uma nova linha)
Console.WriteLine("Hello\nWorld");

// \r - Retorno de carro (move o cursor para o início da linha)
Console.WriteLine("Hello\rWorld");

// \t - Tabulação horizontal (insere um espaço de tabulação horizontal)
Console.WriteLine("Hello\tWorld");

// \v - Tabulação vertical (insere um espaço de tabulação vertical)
Console.WriteLine("Hello\vWorld");

// \\ - Barra invertida (insere uma barra invertida)
Console.WriteLine("Hello\\World");

// \' - Aspas simples (insere uma aspas simples)
Console.WriteLine("Hello\'World");

// \" - Aspas duplas (insere uma aspas dupla)
Console.WriteLine("Hello\"World");

// \? - Ponto de interrogação (insere um ponto de interrogação)
Console.WriteLine("Hello\?World");

// \xhh - Caractere Unicode com valor hexadecimal (insere um caractere Unicode com valor hexadecimal)
Console.WriteLine("\x48\x65\x6C\x6C\x6F World"); // Hello World

// \uhhhh - Caractere Unicode com valor hexadecimal (para 4 dígitos) (insere um caractere Unicode com valor hexadecimal de 4 dígitos)
Console.WriteLine("\u0048\u0065\u006C\u006C\u006F World"); // Hello World

// \Uhhhhhhhh - Caractere Unicode com valor hexadecimal (para 8 dígitos) (insere um caractere Unicode com valor hexadecimal de 8 dígitos)
Console.WriteLine("\U00000048\U00000065\U0000006C\U0000006C\U0000006F World"); // Hello World

