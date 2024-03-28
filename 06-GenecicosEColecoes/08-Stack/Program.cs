// Resumo - Classe Stack em C#:

// A classe Stack em C# representa uma coleção de elementos organizados na estrutura de dados LIFO (Last In, First Out), onde o último elemento adicionado é o primeiro a ser removido.

// Principais Características:
// - Organiza os elementos em uma estrutura de dados LIFO (Last In, First Out), onde o último elemento adicionado é o primeiro a ser removido.
// - Fornece métodos para adicionar, remover e acessar elementos no topo da pilha.
// - Eficiente para operações de adição e remoção de elementos no topo da pilha.

// Principais Métodos:
// - Push(T): Adiciona um elemento ao topo da pilha.
// - Pop(): Remove e retorna o elemento no topo da pilha.
// - Peek(): Retorna o elemento no topo da pilha sem removê-lo.
// - Contains(T): Verifica se um elemento específico está na pilha.
// - Clear(): Remove todos os elementos da pilha.
// - ToArray(): Copia os elementos da pilha para um novo array.

// Propriedades Principais:
// - Count: Retorna o número de elementos presentes na pilha.
// - IsEmpty: Indica se a pilha está vazia.

// Exemplo de Uso:

// Declaração e Inicialização:
Stack<int> pilha = new Stack<int>();

// Adição de Elementos:
pilha.Push(1);
pilha.Push(2);
pilha.Push(3);

// Remoção de Elementos:
int elementoRemovido = pilha.Pop(); // Remove e retorna o elemento 3

// Acesso ao Topo da Pilha:
int topoDaPilha = pilha.Peek(); // Retorna o elemento 2 sem removê-lo

// Iteração sobre os Elementos:
foreach (var elemento in pilha)
{
    Console.WriteLine($"Elemento: {elemento}");
}

