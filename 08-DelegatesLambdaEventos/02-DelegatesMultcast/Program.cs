// Resumo sobre Multicast Delegates em C#

/*
    Delegates em C# podem ser multicast, o que significa que eles podem referenciar vários métodos simultaneamente. 
    Quando um multicast delegate é invocado, todos os métodos referenciados por ele são chamados sequencialmente.

    Como funcionam os Multicast Delegates?
    - Ao declarar um delegate, não é especificado um limite para o número de métodos que ele pode referenciar.
    - O operador += é usado para adicionar um novo método ao delegate.
    - O operador -= é usado para remover um método do delegate.
    - Quando um delegate multicast é invocado, todos os métodos referenciados por ele são chamados na ordem em que foram adicionados.

    Exemplo de uso de Multicast Delegates:
*/

// Declarar o delegate
public delegate void MyDelegate(string message);

// Métodos que serão referenciados pelo delegate
public void Method1(string message)
{
    Console.WriteLine("Method1: " + message);
}

public void Method2(string message)
{
    Console.WriteLine("Method2: " + message);
}

// Adicionar métodos ao delegate e invocá-lo
static void Main(string[] args)
{
    MyDelegate myDelegate = null;

    myDelegate += Method1;  // Adiciona Method1 ao delegate
    myDelegate += Method2;  // Adiciona Method2 ao delegate

    myDelegate("Hello, world!");  // Invoca o delegate
}

// Saída:
// Method1: Hello, world!
// Method2: Hello, world!

/*
    Observações:
    - Ao remover um método de um delegate multicast, apenas a primeira ocorrência desse método é removida.
    - A ordem de adição dos métodos ao delegate determina a ordem em que eles serão chamados.

    Benefícios de usar Multicast Delegates:
    - Maior flexibilidade: Permitem que vários métodos sejam notificados por um único evento.
    - Código mais desacoplado: Ajudam a desacoplar o código, pois os objetos que se inscrevem em um evento não precisam saber quais outros objetos também estão inscritos.

    Desvantagens de usar Multicast Delegates:
    - Potencial para problemas de performance: Se um delegate multicast referenciar muitos métodos, pode haver um impacto no desempenho ao invocá-lo.
    - Código mais complexo: O uso excessivo de multicast delegates pode tornar o código mais difícil de entender e manter.

    Conclusão:
    - Multicast delegates são uma ferramenta poderosa para implementar eventos e callbacks em C#. 
    - No entanto, é importante usá-los com moderação para evitar problemas de performance e complexidade do código.
*/
