// List<T> é uma coleção genérica fornecida no namespace System.Collections.Generic
// Ela armazena elementos de um tipo específico e oferece melhor desempenho e segurança de tipo em comparação com ArrayList

// Métodos Find da classe List<T>:
// Existem cinco sobrecargas do método Find na classe List<T>, que permitem encontrar elementos com base em diferentes critérios.

// 1. Find(Predicate<T> match):
// Este método encontra o primeiro elemento que corresponde a um predicado especificado dentro da lista.
// Retorna o primeiro elemento que satisfaz as condições definidas pelo predicado ou o valor padrão do tipo se nenhum elemento for encontrado.

// Sintaxe:
T elementoEncontrado = lista.Find(predicado);

// 2. FindLast(Predicate<T> match):
// Este método encontra o último elemento que corresponde a um predicado especificado dentro da lista.
// Retorna o último elemento que satisfaz as condições definidas pelo predicado ou o valor padrão do tipo se nenhum elemento for encontrado.

// Sintaxe:
T ultimoElementoEncontrado = lista.FindLast(predicado);

// 3. FindAll(Predicate<T> match):
// Este método encontra todos os elementos que correspondem a um predicado especificado dentro da lista.
// Retorna uma lista contendo todos os elementos que satisfazem as condições definidas pelo predicado.

// Sintaxe:
List<T> elementosEncontrados = lista.FindAll(predicado);

// 4. FindIndex(Predicate<T> match):
// Este método encontra o índice do primeiro elemento que corresponde a um predicado especificado dentro da lista.
// Retorna o índice do primeiro elemento que satisfaz as condições definidas pelo predicado ou -1 se nenhum elemento for encontrado.

// Sintaxe:
int indice = lista.FindIndex(predicado);

// 5. FindLastIndex(Predicate<T> match):
// Este método encontra o índice do último elemento que corresponde a um predicado especificado dentro da lista.
// Retorna o índice do último elemento que satisfaz as condições definidas pelo predicado ou -1 se nenhum elemento for encontrado.

// Sintaxe:
int ultimoIndice = lista.FindLastIndex(predicado);

// Os métodos Find da classe List<T> são úteis para encontrar elementos específicos em uma lista com base em determinados critérios definidos pelo predicado.
// Eles fornecem uma maneira conveniente e eficiente de buscar elementos em uma lista genérica em C#.
