// Resumo - Classe SortedDictionary em C#:

// O SortedDictionary em C# é uma implementação de uma coleção de pares chave/valor que mantém as chaves ordenadas de acordo com uma comparação definida.

// Principais Características:
// - Armazena pares chave/valor onde as chaves são únicas dentro do dicionário.
// - Mantém as chaves ordenadas com base em uma comparação definida durante a inicialização.
// - Fornece acesso rápido aos valores associados às chaves.
// - Permite adicionar, remover, atualizar e pesquisar elementos com base nas chaves.
// - Implementa uma árvore de busca binária para garantir a eficiência nas operações de busca, inserção e remoção, resultando em complexidade logarítmica.

// Propriedades Principais:
// - Count: Retorna o número de pares chave/valor no dicionário.
// - Comparer: Retorna o comparador usado para ordenar as chaves no dicionário.
// - Keys: Retorna uma coleção contendo todas as chaves presentes no dicionário, em ordem.
// - Values: Retorna uma coleção contendo todos os valores associados às chaves presentes no dicionário, na mesma ordem que as chaves.

// Principais Métodos:
// - Add(TKey, TValue): Adiciona um par chave/valor ao dicionário.
// - Remove(TKey): Remove o par chave/valor associado à chave especificada.
// - ContainsKey(TKey): Verifica se o dicionário contém a chave especificada.
// - TryGetValue(TKey, out TValue): Tenta obter o valor associado à chave especificada, sem lançar exceções se a chave não existir.
// - Clear(): Remove todos os pares chave/valor do dicionário.
// - GetEnumerator(): Retorna um enumerador que itera pelos pares chave/valor do dicionário na ordem das chaves.

// Comparação Padrão e Customizada:
// - Por padrão, o SortedDictionary usa a comparação padrão do tipo de dados da chave para ordenar as chaves.
// - É possível fornecer um comparador personalizado durante a inicialização para definir a ordem das chaves de acordo com critérios específicos.

// Exemplo de Uso:

// Declaração e Inicialização:
SortedDictionary<string, int> dicionarioOrdenado = new SortedDictionary<string, int>();
dicionarioOrdenado.Add("chave2", 20);
dicionarioOrdenado.Add("chave1", 10);

// Iteração sobre os Elementos Ordenados:
foreach (var parChaveValor in dicionarioOrdenado)
{
    Console.WriteLine($"Chave: {parChaveValor.Key}, Valor: {parChaveValor.Value}");
}

