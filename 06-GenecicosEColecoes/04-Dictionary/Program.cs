// Resumo - Classe Dictionary em C#:

// A classe Dictionary em C# é uma implementação de uma coleção de pares chave/valor. Ela armazena dados na forma de pares, onde cada par consiste em uma chave única e um valor associado.

// Principais Características:
// - Armazena pares chave/valor onde as chaves são únicas dentro do dicionário.
// - Fornece acesso rápido aos valores associados às chaves.
// - Permite adicionar, remover, atualizar e pesquisar elementos com base nas chaves.
// - Implementa uma tabela de hash para garantir a eficiência nas operações de busca, inserção e remoção.
// - A comparação de chaves é baseada no método Equals e GetHashCode implementado pela chave, o que permite a identificação única das chaves.

// Propriedades Principais:
// - Count: Retorna o número de pares chave/valor no dicionário.
// - IsReadOnly: Indica se o dicionário é somente leitura, ou seja, se não pode ser modificado após a criação.
// - Comparer: Retorna o comparador usado para determinar a igualdade das chaves no dicionário.
// - Keys: Retorna uma coleção contendo todas as chaves presentes no dicionário.
// - Values: Retorna uma coleção contendo todos os valores associados às chaves presentes no dicionário.
// - Item: Permite acessar ou modificar o valor associado a uma chave específica no dicionário.

// Comparação Padrão e Customizada:
// - O comparador padrão usado pela classe Dictionary é o comparador padrão do tipo de dados da chave.
// - Para tipos de dados simples, como inteiros ou strings, o comparador padrão já está definido e implementado.
// - Em alguns casos, pode ser necessário fornecer um comparador personalizado para determinar a igualdade das chaves com base em critérios específicos.
// - Isso pode ser feito passando um objeto comparador personalizado para o construtor do Dictionary.

// Principais Métodos:
// - Add(TKey, TValue): Adiciona um par chave/valor ao dicionário.
// - TryAdd(TKey, TValue): Tenta adicionar um par chave/valor ao dicionário, retornando true se a operação foi bem-sucedida ou false se a chave já existir.
// - Remove(TKey): Remove o par chave/valor associado à chave especificada.
// - ContainsKey(TKey): Verifica se o dicionário contém a chave especificada.
// - TryGetValue(TKey, out TValue): Tenta obter o valor associado à chave especificada, sem lançar exceções se a chave não existir.
// - Clear(): Remove todos os pares chave/valor do dicionário.

// Ordenação do Dicionário:
// - Você pode ordenar um dicionário em C# criando uma nova instância de SortedDictionary<TKey, TValue> ou SortedList<TKey, TValue> e passando o dicionário existente para o construtor.

// Exemplo de Uso:

// Declaração e Inicialização:
Dictionary<string, int> dicionario = new Dictionary<string, int>();
dicionario.Add("chave1", 10);
dicionario.Add("chave2", 20);

// Ordenação do Dicionário:
var dicionarioOrdenado = new SortedDictionary<string, int>(dicionario);

// Iteração sobre os Elementos Ordenados:
foreach (var parChaveValor in dicionarioOrdenado)
{
    Console.WriteLine($"Chave: {parChaveValor.Key}, Valor: {parChaveValor.Value}");
}
