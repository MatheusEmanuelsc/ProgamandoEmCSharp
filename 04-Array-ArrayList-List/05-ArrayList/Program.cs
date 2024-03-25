// ArrayList é uma coleção dinâmica fornecida no namespace System.Collections
// Ele permite armazenar elementos de qualquer tipo e redimensiona automaticamente conforme necessário

// Sintaxe para declaração e inicialização de um ArrayList:
ArrayList lista = new ArrayList(); // Cria um ArrayList vazio

// Adicionando elementos a um ArrayList:
lista.Add(10); // Adiciona um inteiro
lista.Add("Texto"); // Adiciona uma string
lista.Add(3.14); // Adiciona um número de ponto flutuante

// Iterando sobre os elementos de um ArrayList usando um loop 'foreach':
foreach (var item in lista)
{
    Console.WriteLine(item); // Exibe cada item da lista
}

// Outra forma de iterar sobre os elementos de um ArrayList usando um loop 'for':
for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine(lista[i]); // Exibe cada item da lista
}

// Removendo elementos de um ArrayList:
lista.Remove(10); // Remove o elemento inteiro da lista
lista.RemoveAt(1); // Remove o elemento na posição 1 da lista

// Verificando se um elemento está presente em um ArrayList:
bool contemTexto = lista.Contains("Texto"); // Retorna true se "Texto" estiver na lista, caso contrário, retorna false

// Limpando todos os elementos de um ArrayList:
lista.Clear(); // Remove todos os elementos da lista

// ArrayList oferece flexibilidade para armazenar uma coleção de elementos de diferentes tipos, mas isso pode resultar em perda de desempenho devido ao boxing e unboxing de tipos de valor
// Recomenda-se o uso de coleções genéricas como List<T> sempre que possível para evitar esse custo de desempenho


// Verificando se um ArrayList está vazio:
bool estaVazio = lista.Count == 0; // Retorna true se o ArrayList estiver vazio, caso contrário, retorna false

// Obtendo o índice de um elemento específico em um ArrayList:
int indiceTexto = lista.IndexOf("Texto"); // Retorna o índice do primeiro "Texto" encontrado na lista, ou -1 se não encontrado

// Ordenando os elementos de um ArrayList:
lista.Sort(); // Ordena os elementos na ordem natural (crescente) usando a ordem padrão de classificação

// Revertendo a ordem dos elementos em um ArrayList:
lista.Reverse(); // Inverte a ordem dos elementos na lista

// Convertendo um ArrayList em um array de um tipo específico:
int[] array = (int[])lista.ToArray(typeof(int)); // Converte os elementos do ArrayList em um array de inteiros

// Verificando se um elemento específico está presente em um ArrayList usando um predicado:
bool contemNumeroPar = lista.Exists(x => (int)x % 2 == 0); // Retorna true se algum número par estiver na lista, caso contrário, retorna false

// Copiando os elementos de um ArrayList para outro ArrayList:
ArrayList outraLista = new ArrayList();
outraLista.AddRange(lista); // Copia todos os elementos do ArrayList 'lista' para o ArrayList 'outraLista'

// Obtendo uma sublista de um ArrayList:
ArrayList subLista = lista.GetRange(0, 2); // Retorna uma nova ArrayList contendo os elementos da posição 0 até a posição 1 da lista original

// ArrayList oferece uma ampla variedade de métodos para manipular e trabalhar com coleções de elementos dinâmicos em C#
