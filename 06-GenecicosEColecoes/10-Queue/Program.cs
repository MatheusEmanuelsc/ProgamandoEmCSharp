// Resumo - Classe Queue em C#:

// A classe Queue em C# representa uma coleção de elementos organizados na estrutura de dados FIFO (First In, First Out), onde o primeiro elemento adicionado é o primeiro a ser removido.

// Principais Características:
// - Organiza os elementos em uma estrutura de dados FIFO (First In, First Out), onde o primeiro elemento adicionado é o primeiro a ser removido.
// - Fornece métodos para adicionar, remover e acessar elementos no início e no fim da fila.
// - Eficiente para operações de adição e remoção de elementos no início e no fim da fila.

// Principais Métodos:
// - Enqueue(T): Adiciona um elemento ao final da fila.
// - Dequeue(): Remove e retorna o elemento no início da fila.
// - Peek(): Retorna o elemento no início da fila sem removê-lo.
// - Contains(T): Verifica se um elemento específico está na fila.
// - Clear(): Remove todos os elementos da fila.
// - ToArray(): Copia os elementos da fila para um novo array.

// Propriedades Principais:
// - Count: Retorna o número de elementos presentes na fila.

// Exemplo de Uso:

// Declaração e Inicialização:
Queue<int> fila = new Queue<int>();

// Adição de Elementos:
fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(3);

// Remoção de Elementos:
int elementoRemovido = fila.Dequeue(); // Remove e retorna o elemento 1

// Acesso ao Primeiro Elemento da Fila:
int primeiroElemento = fila.Peek(); // Retorna o elemento 2 sem removê-lo

// Iteração sobre os Elementos:
foreach (var elemento in fila)
{
    Console.WriteLine($"Elemento: {elemento}");
}
