
double numero = 123.456789;

// Formata para exibir o número com duas casas decimais
Console.WriteLine($"Duas casas decimais: {numero:F2}");

// Formata para exibir o número como notação científica
Console.WriteLine($"Notação científica: {numero:E}");

// Formata para exibir o número como uma porcentagem com duas casas decimais
Console.WriteLine($"Porcentagem: {numero:P2}");

// Formata para exibir o número com separadores de milhares
Console.WriteLine($"Separadores de milhares: {numero:N}");

// Formata para exibir o número com um número específico de casas decimais
Console.WriteLine($"Três casas decimais: {numero:.000}");

// Formata para exibir o número com uma quantidade mínima de dígitos, preenchendo com zeros à esquerda, neste caso, 10 dígitos
Console.WriteLine($"Mínimo de dígitos: {numero:D10}");

// Formata para exibir o número como hexadecimal
Console.WriteLine($"Hexadecimal: {numero:X}");

// Formata para exibir o número em sua representação padrão
Console.WriteLine($"Padrão: {numero}");

// Formata para exibir o número sem casas decimais
Console.WriteLine($"Sem casas decimais: {numero:.0}");

// Formata para exibir o número com uma largura específica, preenchendo com espaços à esquerda
Console.WriteLine($"Largura específica: {numero,10}");

// Formata para exibir o número com uma largura específica, preenchendo com zeros à esquerda
Console.WriteLine($"Largura específica com zeros: {numero,10:F2}");

// Formata para exibir o número com uma largura específica, alinhando à esquerda e preenchendo com espaços à direita
Console.WriteLine($"Alinhamento à esquerda: {numero,-10:F2}");
