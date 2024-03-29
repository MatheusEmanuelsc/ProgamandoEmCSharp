// Resumo sobre Expressões Lambda em C#

/*
   Expressões Lambda:

   Expressões Lambda, também conhecidas como funções anônimas, são uma forma concisa de definir funções inline em C#. 
   Elas permitem definir o corpo de uma função diretamente no local onde ela é usada.

   Sintaxe:
   A sintaxe geral de uma expressão lambda é a seguinte:
*/

// (parâmetros) => expressão

// parâmetros (opcional): Uma lista separada por vírgulas dos parâmetros da função.
// =>: Operador lambda que separa os parâmetros da expressão.
// expressão: O corpo da função, que pode ser uma única expressão ou um bloco de código delimitado por chaves {}.

/*
   Exemplos:
*/

// Função simples:
int somar = (x, y) => x + y;
int resultado = somar(5, 3); // resultado será 8

// Função com bloco de código:
string formatarString = (texto) =>
{
    texto = texto.Trim();
    return texto.ToUpper();
};

string textoFormatado = formatarString("  oLá MuNDo  ");  // textoFormatado será "OLÁ MUNDO"

/*
   Vantagens:
*/

// Concisão: Permitem escrever código mais conciso e legível, especialmente para funções simples.
// Flexibilidade: Podem ser usadas em diversos contextos, como delegates, collections e eventos.
// Reutilização: Simplificam a reutilização de pequenos trechos de código.

/*
   Desvantagens:
*/

// Legibilidade: Em alguns casos, expressões lambda complexas podem ser menos legíveis do que métodos nomeados.
// Depuração: Podem dificultar a depuração do código, pois não possuem um nome identificador.

/*
   Cenários de uso:
*/

// Delegates: Expressões lambda são frequentemente usadas para criar delegates sem a necessidade de declarar métodos separados.
// LINQ: LINQ (Language Integrated Query) usa expressões lambda para filtrar, ordenar e realizar outras operações em coleções de dados.
// Eventos: Expressões lambda podem ser usadas para se inscrever em eventos e definir o código que será executado quando o evento for acionado.
