// Herança e a Classe Object em C#:
// Em C#, todas as classes direta ou indiretamente herdam da classe Object, que está no namespace System.
// A classe Object é a classe base de todas as outras classes em C#, o que significa que ela fornece funcionalidades básicas que todas as classes podem usar.

// Funcionalidades da classe Object:

// 1. Equals(object obj):
//    Método que determina se o objeto atual é igual a outro objeto. Por padrão, ele compara referências de objetos, mas pode ser substituído em classes derivadas para implementar a lógica de comparação personalizada.

// 2. GetHashCode():
//    Método que retorna um código hash para o objeto atual. Esse código hash é geralmente usado em algoritmos de hash e em estruturas de dados baseadas em hash, como tabelas de hash.

// 3. GetType():
//    Método que retorna o tipo do objeto atual como um objeto Type, que contém informações sobre a classe, incluindo métodos, propriedades e outros detalhes de implementação.

// 4. ToString():
//    Método que retorna uma representação de string do objeto atual. Por padrão, ele retorna o nome completo da classe. Esse método pode ser substituído em classes derivadas para fornecer uma representação personalizada do objeto.

// 5. Finalize():
//    Método chamado pelo coletor de lixo antes de liberar a memória associada a um objeto. Ele pode ser substituído em classes derivadas para realizar a liberação de recursos não gerenciados.

// Herança e a classe Object:

// 1. Todas as classes em C# herdam diretamente ou indiretamente da classe Object.
// 2. Isso significa que todos os objetos em C# compartilham as funcionalidades básicas fornecidas pela classe Object.
// 3. A herança da classe Object é implícita e não requer uma declaração explícita na definição da classe.

// Exemplo de uso da classe Object:
class MinhaClasse // Herda implicitamente da classe Object
{
    // Implementação da classe
}

// No exemplo acima, a classe MinhaClasse herda implicitamente da classe Object e, portanto, possui todas as funcionalidades básicas fornecidas pela classe Object, como Equals, GetHashCode, GetType e ToString.

// A classe Object desempenha um papel fundamental na hierarquia de classes em C#, fornecendo funcionalidades essenciais que são compartilhadas por todas as classes no ambiente de execução do .NET.
