// Resumo - Coleções Genéricas e Não Genéricas em C#:

// Coleções são estruturas de dados que permitem armazenar e manipular conjuntos de elementos em um programa. Em C#, existem coleções genéricas e não genéricas.

// Coleções Genéricas:
// - As coleções genéricas foram introduzidas no .NET Framework 2.0 e fornecem uma maneira mais segura e eficiente de armazenar elementos.
// - Elas são parametrizadas por um tipo de dado específico e permitem que você especifique o tipo de elementos que deseja armazenar na coleção.
// - Exemplos de coleções genéricas incluem List<T>, Dictionary<TKey, TValue>, Queue<T> e Stack<T>.

// Coleções Não Genéricas Correspondentes:

// ArrayList (para List<T>):
// - ArrayList é uma coleção não genérica que pode armazenar elementos de qualquer tipo de dado, sendo necessário fazer conversão ao recuperar os elementos.
// - Exemplo:
ArrayList listaNaoGenerica = new ArrayList();
listaNaoGenerica.Add(1);
listaNaoGenerica.Add("dois"); // Pode armazenar diferentes tipos de dados
int primeiroElementoNaoGenerica = (int)listaNaoGenerica[0]; // Necessário converter para int

// Hashtable (para Dictionary<TKey, TValue>):
// - Hashtable é uma coleção não genérica que armazena pares chave/valor de objetos de qualquer tipo de dado, sendo necessário fazer conversão ao recuperar os elementos.
// - Exemplo:
Hashtable tabelaNaoGenerica = new Hashtable();
tabelaNaoGenerica.Add("chave1", 1);
tabelaNaoGenerica.Add("chave2", "valor2");
int valorChave1 = (int)tabelaNaoGenerica["chave1"]; // Necessário converter para int

// Queue (para Queue<T>):
// - Queue é uma coleção não genérica que armazena elementos de qualquer tipo de dado, sendo necessário fazer conversão ao recuperar os elementos.
// - Exemplo:
Queue filaNaoGenerica = new Queue();
filaNaoGenerica.Enqueue(1);
filaNaoGenerica.Enqueue("dois"); // Pode armazenar diferentes tipos de dados
int primeiroElementoFila = (int)filaNaoGenerica.Dequeue(); // Necessário converter para int

// Stack (para Stack<T>):
// - Stack é uma coleção não genérica que armazena elementos de qualquer tipo de dado, sendo necessário fazer conversão ao recuperar os elementos.
// - Exemplo:
Stack pilhaNaoGenerica = new Stack();
pilhaNaoGenerica.Push(1);
pilhaNaoGenerica.Push("dois"); // Pode armazenar diferentes tipos de dados
int topoPilha = (int)pilhaNaoGenerica.Pop(); // Necessário converter para int


// SortedList (para SortedList<TKey, TValue>):
// - SortedList é uma coleção não genérica que armazena pares chave/valor de objetos de qualquer tipo de dado, sendo necessário fazer conversão ao recuperar os elementos.
// - Ela mantém os elementos ordenados pela chave, permitindo acesso eficiente aos elementos por meio de uma chave.
// - Exemplo:
SortedList listaOrdenadaNaoGenerica = new SortedList();
listaOrdenadaNaoGenerica.Add("chave1", 1);
listaOrdenadaNaoGenerica.Add("chave2", "valor2");
int valorChave1Ordenada = (int)listaOrdenadaNaoGenerica["chave1"]; // Necessário converter para int
