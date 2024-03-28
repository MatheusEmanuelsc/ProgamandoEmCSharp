// Resumo - ReadOnlyCollection em C#:

// ReadOnlyCollection em C# é uma classe que fornece uma visualização somente leitura de uma coleção existente.
// Isso significa que você pode acessar os elementos da coleção, mas não pode modificá-los.

// Características Principais:
// - Fornece uma visualização somente leitura de uma coleção existente.
// - Útil quando você deseja fornecer acesso de leitura a uma coleção, mas deseja evitar modificações inadvertidas.

// Construtor Principal:
// - ReadOnlyCollection<T>(ICollection<T> list): Cria uma nova instância de ReadOnlyCollection<T> que é uma visualização somente leitura da lista especificada.

// Métodos Principais:
// - Contains(T item): Verifica se um elemento específico está na coleção.
// - CopyTo(T[] array, int arrayIndex): Copia os elementos da coleção para uma matriz, começando em um índice específico na matriz.
// - GetEnumerator(): Retorna um enumerador que itera pela coleção.

// Propriedades Principais:
// - Count: Retorna o número de elementos presentes na coleção.

// Exemplo de Uso:

// Declaração e Inicialização:
List<int> lista = new List<int> { 1, 2, 3, 4, 5 };
ReadOnlyCollection<int> readOnlyCollection = new ReadOnlyCollection<int>(lista);

// Acesso de Leitura aos Elementos:
foreach (var elemento in readOnlyCollection)
{
    Console.WriteLine($"Elemento: {elemento}");
}

// Verificação de Existência de Elementos:
bool contemElemento = readOnlyCollection.Contains(3);
Console.WriteLine($"Contém o elemento 3: {contemElemento}");

// Copiar Elementos para uma Matriz:
int[] array = new int[5];
readOnlyCollection.CopyTo(array, 0);
