

Console.Clear();
Console.WriteLine("---------------");
Console.WriteLine("Questão 1: ");
int idade = 35;
Console.WriteLine($"idade : {idade}");
Console.WriteLine("---------------");


Console.WriteLine("---------------");
Console.WriteLine("Questão 2: ");
string nome = "Maria";
Console.WriteLine($"Nome : {nome}");
Console.WriteLine("---------------");

Console.WriteLine("---------------");
Console.WriteLine("Questão 3: ");
double altura = 3.45;
Console.WriteLine($"Altura : {altura}");
Console.WriteLine("---------------");

Console.WriteLine("---------------");
Console.WriteLine("Questão 4: ");
DateOnly data = new DateOnly(1999, 09, 04);
Console.WriteLine($"Data  : {data}");
Console.WriteLine("---------------");

Console.WriteLine("---------------");
Console.WriteLine("Questão 5: ");
const int ano = 12;
Console.WriteLine($"Ano  : {ano}");
Console.WriteLine("---------------");

Console.WriteLine("---------------");
Console.WriteLine("Questão 6: ");
double? nota = 7.80;
Console.WriteLine($"Nota  : {nota}");
Console.WriteLine("---------------");

// 7- Quais as diferenças entre os tipos por valor e os tipos por referência ?

// tipos valor são armzenados na propria variavel enquanto a os tipos referencia guarda apenas a referencia aonde estar armazenada

// 8- Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:
// (      int          )  x = 10;   
// (      double       )  numero = 7.99;
// (      char         )  letra = 'C';  
// (      float        )  temperatura = 27.4f;  
// (      boolean      )  ativo  = false;  
// (      string       )  nome = "Manoel";
// (      Decimal      )  salario = 950.99m;
// (      DateTime     )  hoje =  DateTime.Now


// 9- Dada as variáveis declaradas a seguir classifique-as em tipos por valor(V) e tipos por 
// referência (R) :
// ( V    ) int n = 1;   
// ( R    ) string titulo = "A vida";    
// ( V    ) float f = 12.45f;  
// ( V    ) double d = 5.45;  
// ( V    ) decimal valor = 10.99m;
// ( V   ) char sexo = ‘M’;
// ( R    ) object o = null;


// 10- O que é um nullable type e qual a sua utilidade ?

// Permite valores nullos

// 11- O que é Camel Case ? Dê um exemplo de sua aplicação.

// quando se criar uma variavel com 2 nomes a primeira letra a conta da segunda palavra devera vir maiúscula

// 12- O que é Pascal Case ? Dê um exemplo de sua aplicação.

// A primeira letra de classes e propriedades deve ser maiúscula.

Console.WriteLine("---------------");
Console.WriteLine("Questão 13: ");
int x = 77;
int y = 66;
Console.WriteLine($" x + y = {x+y}");
Console.WriteLine("---------------");



// 14- Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e 
// string.
// bool	false
// char	\0 (caractere nulo)
// int	0
// double	0.0
// float	0.0f
// decimal	0.0m
// string	"" (string vazia)


// 15- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis 
// considerando a nomenclatura usada:
// (  F    ) double 1valor = 12.45; 
// (  F    ) string #nome = "Pedro";    
// (  V    ) float _temperatura = 12.45f;  
// (  F    ) double int = 5;  
// (  F    ) decimal renda extra = 91.45m;
// (  F    ) bool status$conta = false;
// (  V    ) string titulo3 = “Tópico 1”; 
// (  V    ) float salario_mensal = 1999.55f;
// (  V    ) int percentualValorDesconto = 5;
// (  V    ) const bool MENSALIDADE_EM_DIA = true;