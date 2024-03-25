// Um array (ou vetor) em C# é uma estrutura de dados que armazena uma coleção fixa de elementos do mesmo tipo
// Os elementos do array são acessados por meio de um índice inteiro, que começa em 0 e vai até o comprimento do array menos um

// Sintaxe para declaração e inicialização de um array:
int[] numeros = new int[5]; // Declara um array de inteiros com 5 elementos

// Os elementos de um array podem ser acessados e atribuídos individualmente usando a sintaxe de índice:
numeros[0] = 10; // Define o primeiro elemento do array como 10
int primeiroElemento = numeros[0]; // Recupera o valor do primeiro elemento do array

// Um array também pode ser inicializado diretamente com valores:
int[] numeros = new int[] { 10, 20, 30, 40, 50 }; // Inicializa um array de inteiros com valores específicos

// É possível obter o comprimento de um array usando a propriedade Length:
int tamanhoDoArray = numeros.Length; // Retorna 5, o número de elementos no array

// Percorrendo e iterando um array com um laço for:
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]); // Exibe cada elemento do array
}

// Iterando um array com um laço foreach:
foreach (int numero in numeros)
{
    Console.WriteLine(numero); // Exibe cada elemento do array
}

// Os arrays podem conter elementos de qualquer tipo, incluindo tipos primitivos, tipos de classe e até outros arrays (matrizes)

// Existem também arrays multidimensionais, como matrizes bidimensionais (ou arrays 2D), que são declarados assim:
int[,] matriz = new int[3, 3]; // Declara uma matriz bidimensional de inteiros 3x3

// Além disso, existem arrays de arrays, chamados de arrays jagged, que são declarados assim:
int[][] arrayJagged = new int[3][]; // Declara um array de arrays de inteiros com 3 elementos, onde cada elemento pode ser um array de inteiros de comprimento variável

// Arrays em C# são tipos de referência, o que significa que a variável de array armazena uma referência à localização de memória onde os elementos do array estão armazenados
// Portanto, ao passar um array para um método, é passada a referência ao array, não uma cópia dos elementos

// Arrays têm um tamanho fixo uma vez que são criados. Se você precisar de uma coleção com tamanho dinâmico, pode-se usar tipos de coleção genéricos como List<T>
