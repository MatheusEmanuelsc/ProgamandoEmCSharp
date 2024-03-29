// Resumo Completo de Delegates Predefinidos em C#: Predicate, Func e Action

/*
1. Delegate Predicate:

   O delegate Predicate<T> representa um método que recebe um objeto do tipo T como entrada e retorna um valor booleano 
   indicando se o objeto atende a uma condição específica.
*/
// Exemplo:
// Definindo um predicate para verificar se um número é par
Predicate<int> isEven = numero => numero % 2 == 0;

// Usando o predicate para filtrar uma lista
List<int> numeros = new List<int>() { 1, 2, 3, 4, 5 };
var numerosPares = numeros.FindAll(isEven);

foreach (var numero in numerosPares)
{
    Console.WriteLine(numero); // Resultado: 2, 4
}


/*
2. Delegate Func:

   O delegate Func<T, TResult> representa um método que recebe um objeto do tipo T como entrada e retorna um valor do 
   tipo TResult.
*/
// Exemplo:
// Definindo um Func para converter um número para string
Func<int, string> converterParaString = numero => numero.ToString();

// Usando o Func para converter uma lista de números para strings
List<int> numeros = new List<int>() { 1, 2, 3, 4, 5 };
var strings = numeros.Select(converterParaString);

foreach (var str in strings)
{
    Console.WriteLine(str); // Resultado: "1", "2", "3", "4", "5"


/*
3. Delegate Action:

   O delegate Action<T> representa um método que recebe um objeto do tipo T como entrada e não retorna nenhum valor.
*/
// Exemplo:
// Definindo um Action para imprimir um número
Action<int> imprimirNumero = numero => Console.WriteLine(numero);

// Usando o Action para imprimir uma lista de números
List<int> numeros = new List<int>() { 1, 2, 3, 4, 5 };
numeros.ForEach(imprimirNumero);

// Resultado:
// 1
// 2
// 3
// 4
// 5


/*
Benefícios dos Delegates Predefinidos:

   - Simplicidade: Facilitam a escrita de código conciso e legível.
   - Reutilização: Permitem a reutilização de código em diferentes contextos.
   - Flexibilidade: Permitem a criação de código mais flexível e adaptável a diferentes necessidades.
   
Considerações:

   - Complexidade: O uso excessivo de delegates pode tornar o código mais difícil de entender e manter.
   - Desempenho: Em alguns casos, o uso de delegates pode ter um impacto no desempenho do código.
*/

// Conclusão:

// Os delegates predefinidos Predicate, Func e Action são ferramentas poderosas que podem ser usadas para escrever 
// código mais conciso, legível e reutilizável em C#. É importante usá-los com moderação e estar ciente dos seus 
// benefícios e considerações.

// Recursos Adicionais:

// Documentação da Microsoft sobre Delegates: https://es.wiktionary.org/wiki/removido
// Artigo sobre Delegates Predefinidos em C#: https://es.wiktionary.org/wiki/removido
// Tutorial sobre Delegates Predefinidos em C#: https://www.youtube.com/watch?v=bXqFI2R5TVs
