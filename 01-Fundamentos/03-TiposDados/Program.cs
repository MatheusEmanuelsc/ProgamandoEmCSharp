//+++++++++++++++++++++++++++++++++++++ TIPOS PRIMITIVOS +++++++++++++++++++++++++++++++++++++++++++++++++++++++

// -------------------------------------Tipos Numericos---------------------------------------------------------

// Tipos De dados Integrais


// Tipos de dados inteiros que aceitam positivo e negativo
sbyte valorSByte;     // -128 a 127
short valorShort;     // -32,768 a 32,767
int valorInt;         // -2,147,483,648 a 2,147,483,647
long valorLong;       // -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807

// Tipos de dados inteiros que aceitam apenas positivo
byte valorByte;       // 0 a 255
ushort valorUShort;   // 0 a 65,535
uint valorUInt;       // 0 a 4,294,967,295
ulong valorULong;     // 0 a 18,446,744,073,709,551,615
// o Literal do long quando for declarado devera ter o l exemplo: long  valorLong=23l

// Exibindo os valores padrão dos tipos de dados inteiros
Console.WriteLine("Valores padrão dos tipos de dados inteiros que aceitam positivo e negativo:");
Console.WriteLine("sbyte: " + default(sbyte));
Console.WriteLine("short: " + default(short));
Console.WriteLine("int: " + default(int));
Console.WriteLine("long: " + default(long));

Console.WriteLine();

Console.WriteLine("Valores padrão dos tipos de dados inteiros que aceitam apenas positivo:");
Console.WriteLine("byte: " + default(byte));
Console.WriteLine("ushort: " + default(ushort));
Console.WriteLine("uint: " + default(uint));
Console.WriteLine("ulong: " + default(ulong));


// Tipos Ponto Flutuante

// Tipos de dados com ponto flutuante que aceitam positivo e negativo
float valorFloat;     // Aproximadamente ±1.5 x 10^-45 a ±3.4 x 10^38, com sete dígitos de precisão
double valorDouble;   // Aproximadamente ±5.0 x 10^-324 a ±1.7 x 10^308, com 15-16 dígitos de precisão
decimal valorDecimal; // ±1.0 x 10^-28 a ±7.9 x 10^28, com 28-29 dígitos de precisão
//Mais indicando para calculo finaceiros ou seja quando precisar de um grau maior de precisão

/*
    o Literal do float quando for declarado devera ter o f exemplo: float  valorFloat=23.5f
    o Literal do decimal quando for declarado devera ter o d exemplo: decimal  valorDecimal=23.5d
*/


// Exibindo os valores padrão dos tipos de dados com ponto flutuante
Console.WriteLine("Valores padrão dos tipos de dados com ponto flutuante que aceitam positivo e negativo:");
Console.WriteLine("float: " + default(float));
Console.WriteLine("double: " + default(double));
Console.WriteLine("decimal: " + default(decimal));



//-------------------------------Tipos não Numericos-------------------------------------------------------


// tipo booleano
// aceita apenas 2 valores true ou false
// valor padrão e false

bool valorBool;


//Tipo caracter
//aceita apenas 1 unico caracter
//valor padrão '\0 e a representação em unicode para nulo
char valorChar='a';

// quando for por o valor  no char dera utilizar aspas simples


//+++++++++++++++++++++++++++++++++++++++++TIPO REFERENCIA ++++++++++++++++++++++++++++++++++++++++++



// Tipo String
// Para tulizar use aspas duplas

string valorString="seilar";

//Tipo Object
// aceita todos os tipos poém não e uma boa pratica utilizalo
// além do que vai ficar convertendo os valores toda hora
object valorObject;

//na maioria dos casos se comporta como object
// ele resolvido em tempo de execução
dynamic valorDynamic;