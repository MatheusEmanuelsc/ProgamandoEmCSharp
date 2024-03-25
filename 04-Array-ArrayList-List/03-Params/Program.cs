// O modificador 'params' é usado em métodos para permitir que um número variável de argumentos seja passado como parâmetro
// Ele é especialmente útil quando o número exato de argumentos não é conhecido antecipadamente ou quando os argumentos podem variar de uma chamada de método para outra

// Sintaxe de uso do modificador 'params':
public void MetodoComParams(params int[] numeros)
{
    // Corpo do método
}

// No exemplo acima, 'numeros' é um parâmetro do tipo array de inteiros marcado com o modificador 'params'
// Isso permite que o método seja chamado com zero ou mais argumentos inteiros, que são empacotados automaticamente em um array

// Exemplo de chamada de método usando 'params':
MetodoComParams(1, 2, 3); // Chama o método com 3 argumentos inteiros
MetodoComParams(); // Chama o método sem argumentos inteiros (um array vazio será passado)

// O modificador 'params' deve ser o último parâmetro na lista de parâmetros do método
// É possível ter outros parâmetros antes do parâmetro 'params', mas não é permitido ter parâmetros após ele

// Quando um método possui um parâmetro marcado como 'params', ele pode ser chamado sem especificar explicitamente um array de argumentos
// Os argumentos fornecidos na chamada do método serão empacotados automaticamente em um array

// O uso de 'params' simplifica a chamada de métodos com um número variável de argumentos e torna o código mais limpo e legível
// No entanto, é importante ter cuidado ao usar 'params', pois pode resultar em uma sobrecarga de memória se muitos argumentos forem passados frequentemente
