
// Existe 2 tipos de  conversão  implicita e explicita


// Maneira implicita
// se o dado for caompativel e e de menor valor  a conversão e automaticamente
int varInt = 100;
double varDouble = varInt;


// maneira explicita
// porem quando vc faz uma de maior valor para uma menor pode ocorrer perda de dados por isso deve ser feito de forma explicita
varInt = (int)varDouble;


// Conversão de tipos

// para string
int varlor1 = 10
Console.WriteLine(varlor1.ToString());



// Conversão Implícita:
// - Realizada automaticamente pelo compilador quando não há risco de perda de dados.
// - Recomendada quando não há risco de perda de precisão ou dados.

// Conversão Explícita (Casting):
// - Feita explicitamente pelo programador utilizando a sintaxe de casting.
// - Recomendada quando há risco de perda de dados ou quando se deseja forçar a conversão.

// Métodos Parse() e TryParse():
// - Utilizados para converter strings em tipos numéricos.
// - Parse() lança uma exceção se a conversão falhar, enquanto TryParse() retorna um booleano indicando o sucesso da conversão.
// - Recomendados quando há uma alta probabilidade de que a string seja válida, mas é necessário tratar a possibilidade de falha.

// Métodos de Conversão de Tipos:
// - Fornecem métodos específicos para converter entre diferentes tipos.
// - Seguros e recomendados quando se sabe o tipo exato de conversão que será feita.

// Conversão de Enumeradores:
// - Utilizada para converter entre valores de enumeração e outros tipos de dados.
// - Recomendada quando se deseja converter entre strings e enumerações.

// Conversão de Tipos Numéricos:
// - Utilizada para converter entre tipos numéricos, como int, double, etc.
// - Recomendada quando se deseja converter entre tipos numéricos, garantindo o tratamento adequado de possíveis erros de conversão.



// Conversão Implícita
int intValue = 10;
double doubleValue = intValue; // Conversão implícita de int para double

// Conversão Explícita (Casting)
double doubleNumber = 10.5;
int intNumber = (int)doubleNumber; // Conversão explícita de double para int

// Métodos Parse() e TryParse() para conversão de strings em tipos numéricos
string numericString = "123";
int parsedInt;
if (int.TryParse(numericString, out parsedInt))
{
    Console.WriteLine("Conversão bem-sucedida: " + parsedInt);
}
else
{
    Console.WriteLine("Conversão falhou.");
}

// Convert.ToInt32() é uma maneira segura de converter strings em tipos numéricos
string strValue = "10";
int convertedInt = Convert.ToInt32(strValue);

// Parse() é uma alternativa, mas lança uma exceção se a conversão falhar
string strValue2 = "abc";
try
{
    int parsedInt2 = int.Parse(strValue2);
    Console.WriteLine("Conversão bem-sucedida: " + parsedInt2);
}
catch (FormatException)
{
    Console.WriteLine("Conversão falhou. A string não estava em um formato correto.");
}

// Conversão de Enumeradores
string enumString = "Value1";
EnumType enumValue;
if (Enum.TryParse(enumString, out enumValue))
{
    Console.WriteLine("Conversão de enumeração bem-sucedida: " + enumValue);
}
else
{
    Console.WriteLine("Conversão de enumeração falhou.");
}

// Conversão de Tipos Numéricos
double numDouble = 10.5;
int numInt = Convert.ToInt32(numDouble);


enum EnumType
{
    Value1,
    Value2,
    Value3
}

// Comentários explicativos adicionais:

// Convert.ToInt32() é uma maneira segura de converter strings em tipos numéricos. Ele converte um valor de qualquer tipo primitivo ou de objeto em um tipo inteiro de 32 bits.
// Parse() é uma alternativa, mas lança uma exceção (FormatException) se a conversão falhar. Este método é utilizado para converter a representação de cadeia de caracteres de um número em um valor numérico inteiro.
// TryParse() é uma alternativa mais segura ao Parse(), pois não lança uma exceção em caso de falha na conversão. Ele tenta converter a representação de cadeia de caracteres de um número em um valor numérico inteiro e retorna um booleano indicando se a conversão foi bem-sucedida.

