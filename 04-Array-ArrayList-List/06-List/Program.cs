// List<T> é uma coleção genérica fornecida no namespace System.Collections.Generic
// Ela armazena elementos de um tipo específico e oferece melhor desempenho e segurança de tipo em comparação com ArrayList

// Sintaxe para declaração e inicialização de uma List<T>:
List<int> numeros = new List<int>(); // Cria uma lista vazia de inteiros

// Adicionando elementos a uma List<T>:
numeros.Add(10); // Adiciona um inteiro à lista
numeros.Add(20); // Adiciona outro inteiro à lista

// Iterando sobre os elementos de uma List<T> usando um loop 'foreach':
foreach (var numero in numeros)
{
    Console.WriteLine(numero); // Exibe cada número na lista
}

// Acessando elementos de uma List<T> usando índices:
int primeiroNumero = numeros[0]; // Obtém o primeiro número na lista

// Removendo elementos de uma List<T>:
numeros.Remove(10); // Remove o elemento 10 da lista
numeros.RemoveAt(0); // Remove o primeiro elemento da lista

// Verificando se um elemento está presente em uma List<T>:
bool contemNumero20 = numeros.Contains(20); // Retorna true se o número 20 estiver na lista, caso contrário, retorna false

// Limpando todos os elementos de uma List<T>:
numeros.Clear(); // Remove todos os elementos da lista

// List<T> fornece uma maneira mais segura e eficiente de trabalhar com coleções de elementos de um tipo específico em comparação com ArrayList
// Ela oferece uma ampla gama de métodos para adicionar, remover, acessar, verificar e manipular elementos na lista

