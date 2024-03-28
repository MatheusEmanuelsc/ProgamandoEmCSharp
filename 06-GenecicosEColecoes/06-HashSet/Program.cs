// Resumo - Classe HashSet em C#:

// O HashSet em C# é uma coleção que armazena elementos únicos, sem duplicatas, e não mantém uma ordem específica para os elementos.

// Principais Características:
// - Armazena elementos únicos, garantindo que não haja duplicatas na coleção.
// - Não mantém uma ordem específica para os elementos, eles são armazenados em uma tabela de hash.
// - Fornece acesso rápido aos elementos e operações de adição, remoção e verificação de existência de elementos.

// Principais Métodos:
// - Add(T): Adiciona um elemento à coleção, retornando true se o elemento foi adicionado com sucesso e false se o elemento já existir na coleção.
// - Remove(T): Remove o elemento especificado da coleção, retornando true se o elemento foi removido com sucesso e false se o elemento não existir na coleção.
// - Contains(T): Verifica se a coleção contém o elemento especificado, retornando true se o elemento existir na coleção e false caso contrário.
// - Clear(): Remove todos os elementos da coleção, deixando-a vazia.
// - UnionWith(IEnumerable<T>): Modifica a coleção atual para conter todos os elementos presentes na coleção especificada e na coleção atual.
// - IntersectWith(IEnumerable<T>): Modifica a coleção atual para conter apenas os elementos presentes tanto na coleção especificada quanto na coleção atual.
// - ExceptWith(IEnumerable<T>): Modifica a coleção atual para remover todos os elementos presentes na coleção especificada da coleção atual.
// - SymmetricExceptWith(IEnumerable<T>): Modifica a coleção atual para conter apenas os elementos que estão presentes em uma das coleções, mas não em ambas.

// Propriedades Principais:
// - Count: Retorna o número de elementos presentes na coleção.
// - IsReadOnly: Indica se a coleção é somente leitura, ou seja, se não pode ser modificada após a criação.
// - Comparer: Retorna o comparador usado para determinar a igualdade dos elementos na coleção.

// Exemplo de Uso:

// Declaração e Inicialização:
HashSet<int> conjunto = new HashSet<int>();

// Adição de Elementos:
conjunto.Add(1);
conjunto.Add(2);
conjunto.Add(3);

// Remoção de Elementos:
conjunto.Remove(2);

// Verificação de Existência de Elementos:
bool contemTres = conjunto.Contains(3); // Retorna true

// Iteração sobre os Elementos:
foreach (var elemento in conjunto)
{
    Console.WriteLine($"Elemento: {elemento}");
}

