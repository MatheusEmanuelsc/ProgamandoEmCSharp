// Resumo - Classe SortedSet em C#:

// O SortedSet em C# é uma coleção que armazena elementos únicos e os mantém ordenados em ordem crescente ou decrescente, conforme especificado durante a inicialização.

// Principais Características:
// - Armazena elementos únicos e os mantém ordenados com base em uma comparação definida durante a inicialização.
// - Não permite elementos duplicados na coleção.
// - Fornece acesso rápido aos elementos e suporta operações eficientes como adição, remoção e busca.

// Principais Métodos:
// - Add(T): Adiciona um elemento ao conjunto, retornando true se o elemento foi adicionado com sucesso e false se o elemento já existir na coleção.
// - Remove(T): Remove o elemento especificado do conjunto, retornando true se o elemento foi removido com sucesso e false se o elemento não existir na coleção.
// - Contains(T): Verifica se o conjunto contém o elemento especificado, retornando true se o elemento existir na coleção e false caso contrário.
// - Clear(): Remove todos os elementos do conjunto, deixando-o vazio.
// - UnionWith(IEnumerable<T>): Modifica o conjunto atual para conter todos os elementos presentes na coleção especificada e no conjunto atual.
// - IntersectWith(IEnumerable<T>): Modifica o conjunto atual para conter apenas os elementos presentes tanto na coleção especificada quanto no conjunto atual.
// - ExceptWith(IEnumerable<T>): Modifica o conjunto atual para remover todos os elementos presentes na coleção especificada do conjunto atual.
// - SymmetricExceptWith(IEnumerable<T>): Modifica o conjunto atual para conter apenas os elementos que estão presentes em uma das coleções, mas não em ambas.

// Propriedades Principais:
// - Count: Retorna o número de elementos presentes no conjunto.
// - Comparer: Retorna o comparador usado para ordenar os elementos no conjunto.
// - IsReadOnly: Indica se o conjunto é somente leitura, ou seja, se não pode ser modificado após a criação.

// Exemplo de Uso:

// Declaração e Inicialização:
SortedSet<int> conjuntoOrdenado = new SortedSet<int>();

// Adição de Elementos:
conjuntoOrdenado.Add(3);
conjuntoOrdenado.Add(1);
conjuntoOrdenado.Add(2);

// Remoção de Elementos:
conjuntoOrdenado.Remove(2);

// Verificação de Existência de Elementos:
bool contemTres = conjuntoOrdenado.Contains(3); // Retorna true

// Iteração sobre os Elementos:
foreach (var elemento in conjuntoOrdenado)
{
    Console.WriteLine($"Elemento: {elemento}");
}

