
Console.WriteLine("---------------");
Console.WriteLine("Questão 1: ");

var nome = "Paulo";
var idade = "15";
var nota = "7.5";

Console.WriteLine("Nome: " + nome + ", Idade: " + idade + ", Nota: " + nota);

Console.WriteLine($"Nome: {nome} , Idade: {idade} , Nota: {nota} ");


Console.WriteLine("---------------");


Console.WriteLine("---------------");
Console.WriteLine("Questão 2: ");

Console.WriteLine($"Nome: {nome} , \n Idade: {idade} ,\n Nota: {nota} ");

Console.WriteLine("---------------");


// 3- Para qual tipo de dados você pode converter um float implicitamente ?
// (    ) int 
// (  X  ) double
// (    ) long
// (  X  ) decimal


// 4- Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ? 
// (    ) int para long
// (  X  ) double para long
// (  X  ) double para float
// (  X  ) decimal para float
// (  X  ) long para int
// (    ) double para decimal


Console.WriteLine("---------------");
Console.WriteLine("Questão 5: ");

char letra1, letra2, letra3;
Console.Write("Informe a letra : ");
letra1 = Convert.ToChar(Console.ReadLine());
Console.Write("Informe a letra : ");
letra2 = Convert.ToChar(Console.ReadLine());
Console.Write("Informe a letra : ");
letra3 = Convert.ToChar(Console.ReadLine());
Console.WriteLine(letra3 + " " + letra2 + " " + letra1);
Console.WriteLine($"{letra3} {letra2} {letra1}");

Console.WriteLine("---------------");


// 6- Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
// ( F    )  long resultado = 1.32;
// ( V    )  var nome = “Maria”;
// ( V    )  string resultado =  100.ToString();
// ( V    )  A sequência de escape \n inclui uma nova linha
// ( F    )  float f  = 5.45;  
// ( V    )  decimal valor = (decimal) 10.99f;
// ( F    )  var status = null;
// ( V    )  object o = 12.45m;
// ( V    )  string titulo =  true.ToString(); 
// ( V    )  A sequencia \t inclui uma tabulação vertical


Console.WriteLine("---------------");
Console.WriteLine("Questão 7: ");

Console.WriteLine("Digite o valor 1:");
var valor1 = (double)Console.ReadLine();

Console.WriteLine("Digite o valor 2:");
var valor2 = (double)Console.ReadLine();


Console.Write($"Resultado da soma: {valor1 + valor2}");
Console.Write($"Resultado da subtração: {valor1 - valor2}");
Console.Write($"Resultado da multiplicação: {valor1 * valor2}");
Console.Write($"Resultado da divisão: {valor1 / valor2}");
Console.Write($"Resultado da exponenciação: {Math.Pow(valor1, valor2); }");
Console.Write($"Resultado da resto: {valor1 % valor2}");

Console.WriteLine("---------------");

Console.WriteLine("---------------");
Console.WriteLine("Questão 8: ");

var a = 1, b = 12, c = -13;


var delta = (b ^ 2) - 4 * a * c;

var x1 = (-b + Math.Sqrt(delta)) / (2 * a);
var x1 = (-b - Math.Sqrt(delta)) / (2 * a);

Console.WriteLine($"X1 : {x1}");
Console.WriteLine($"X2 : {x2}");

Console.WriteLine("---------------");


Console.WriteLine("---------------");
Console.WriteLine("Questão 9: ");

Console.WriteLine("digite o usuario")
var user = Console.ReadLine();

Console.WriteLine("digite a senha")
var senha = Console.ReadLine();

var resultado = (user == "admin" || user == "maria") && senha == 123 ? "Login aceito" : "dados invalidos";

Console.WriteLine(resultado);

Console.WriteLine("---------------");



// 10- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis considerando 
// a nomenclatura usada:
// (  V    ) string? nome; é um exemplo de nullable reference type;
// (  V   ) para x igual a 0 , Console.WriteLine(x++);  imprime o valor 1
// ( V    ) A ordem de precedência dos operadores lógicos é :  ! , || e && (NOT, OR e AND)
// ( V    ) para y igual a 0 , Console.WriteLine(++y);  imprime o valor 1
// (  F   ) (10 % 2 == 0) ? “Par” : “Impar”;    Vai retornar “Impar”
// ( F    ) Para x=25 e y=5 , a expressão ( y >= x ) && ( y <= x );  retorna true;
// (  V   ) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
// (  V   ) Para x = 10 , o código Console.WriteLine(x+=x);  imprime o valor 10;
// (  F   ) Para x= 5 , a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
// (  V   ) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
// (  V   ) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?"


Console.WriteLine("---------------");
Console.WriteLine("Questão 11: ");

Console.WriteLine("Digite o valor 1:");
var valor1 = (int)Console.ReadLine();

Console.WriteLine("Digite o valor 2:");
var valor2 = (int)Console.ReadLine();

var result1 = valor1 % 2 == 0 ? "Par" : "Impar";
var result2 = valor2 % 2 == 0 ? "Par" : "Impar";

Console.Write(result1);
Console.Write(result2);

Console.WriteLine("---------------");

Console.WriteLine("---------------");
Console.WriteLine("Questão 12: ");

Console.WriteLine("Digite um número inteiro:");
int x = int.Parse(Console.ReadLine());


const double pi = 3.1415;


Console.WriteLine("x^2: " + (x * x));
Console.WriteLine("pi * x^2: " + (pi * (x * x)));
Console.WriteLine("6 + x * 5: " + (6 + x * 5));
Console.WriteLine("(13 - 2) * x: " + ((13 - 2) * x));
Console.WriteLine("(x + 2) * (20 / x): " + ((x + 2) * (20 / x)));
Console.WriteLine("(12 + x) / (x - 4): " + ((12 + x) / (x - 4)));
Console.WriteLine("3x^2 + x + 10: " + (3 * (x * x) + x + 10));
Console.WriteLine("---------------");




// 13- Considere o seguinte trecho de código:
// int y = 5 ;
// y = (y++)+y+(++y);        ou y = y++ + y + ++y;
// Console.WriteLine(y);

// primeiro trecho e mais legivel e o mais adequado


Console.WriteLine("---------------");
Console.WriteLine("Questão 14: ");

Console.WriteLine("Digite a temperatura em Celsius:");
double celsius = double.Parse(Console.ReadLine());


const double kelvinConstante = 273.0;
const double fahrenheitConstanteA = 9.0 / 5.0;
const double fahrenheitConstanteB = 32.0;


double kelvin = celsius + kelvinConstante;
double fahrenheit = (celsius * fahrenheitConstanteA) + fahrenheitConstanteB;


Console.WriteLine("Temperatura em Kelvin: " + kelvin.ToString("F2"));
Console.WriteLine("Temperatura em Fahrenheit: " + fahrenheit.ToString("F2"));

Console.WriteLine("---------------");

Console.WriteLine("---------------");

Console.WriteLine("Questão 15: ");

// 15 - Escolha a opção que representa a  exibição do resultado para o código usando os 
// operadores de decremento e incremento  (pré e pós) 

// result 5 , 2 , 2, 2