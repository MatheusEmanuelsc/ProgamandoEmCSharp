// Exemplo de uso de um tipo anônimo
var pessoa = new { Nome = "João", Idade = 30 };

// Os tipos anônimos permitem criar objetos temporários sem definir uma classe explicitamente
// Eles são úteis para retornar múltiplos valores de uma consulta ou expressão sem a necessidade de definir uma classe específica para isso

// Os tipos anônimos são criados usando a palavra-chave 'var' seguida por uma inicialização de objeto com propriedades nomeadas
// As propriedades são definidas usando a sintaxe 'NomeDaPropriedade = Valor'

// Os tipos anônimos são imutáveis, o que significa que não podem ser alterados após a sua criação

// Os tipos anônimos são frequentemente usados ​​em consultas LINQ para projetar resultados específicos sem a necessidade de definir classes de modelo separadas

// Embora os tipos anônimos sejam úteis para situações simples, eles não oferecem a mesma flexibilidade e reutilização que as classes definidas explicitamente
// Eles não podem ser usados como parâmetros de método ou retornados de métodos (exceto em métodos com assinaturas 'out' ou 'ref')
// Além disso, não é possível acessar suas propriedades fora do escopo em que foram criados

