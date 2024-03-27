// Herança e Sealed em C#:
// O modificador "sealed" é usado em C# para impedir que uma classe seja herdada por outras classes. Isso significa que uma classe marcada como "sealed" não pode ser usada como classe base para outra classe.

// Sintaxe de uso do modificador "sealed":
sealed class ClasseBase
{
    // Implementação da classe
}

// Características do uso do modificador "sealed":

// 1. Impedimento de herança:
//    Ao marcar uma classe como "sealed", você está indicando que não deseja que outras classes herdem dela. Isso é útil quando você deseja proteger a integridade ou a implementação de uma classe e garantir que ela não seja estendida ou modificada.

// 2. Prevenção de polimorfismo:
//    Ao selar uma classe, você impede que ela seja usada como base para a criação de novas classes que possam substituir seus membros (métodos, propriedades, etc.). Isso pode ser útil quando você deseja garantir que certos comportamentos não sejam alterados em subclasses.

// 3. Segurança do código:
//    O uso de classes seladas pode ajudar a garantir a integridade do código, evitando a introdução de comportamentos inesperados ou erros de implementação em classes derivadas.

// 4. Performance:
//    Classes seladas podem potencialmente otimizar a execução do código, pois o compilador pode aplicar algumas otimizações sabendo que a classe não será estendida.

// Exemplo de uso do modificador "sealed":
sealed class ClasseBase
{
    // Implementação da classe
}

// No exemplo acima, a classe "ClasseBase" é marcada como "sealed", o que significa que não pode ser herdada por outras classes. Qualquer tentativa de herdar dessa classe resultará em um erro de compilação.

// O modificador "sealed" é útil quando você deseja restringir a herança de uma classe para garantir a integridade do código ou proteger sua implementação contra modificações indesejadas.

