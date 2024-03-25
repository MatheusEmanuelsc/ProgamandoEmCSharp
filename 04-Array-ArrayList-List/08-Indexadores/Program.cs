// Indexadores em C#:
// Indexadores são membros especiais de uma classe que permitem acessar seus elementos como se fossem arrays.
// Eles permitem que você defina a semântica de acesso aos elementos de um objeto de uma forma semelhante ao acesso a elementos de um array.

// Sintaxe de declaração de um indexador:
public TipoElemento this[TipoIndice indice]
{
    get
    {
        // Lógica para recuperar o valor com base no índice
        return valor;
    }
    set
    {
        // Lógica para definir o valor com base no índice
    }
}

// Características dos indexadores:
// 1. O nome "this" é usado para definir um indexador em uma classe.
// 2. É possível ter múltiplos indexadores em uma única classe, desde que eles tenham diferentes assinaturas.
// 3. Os indexadores podem ter qualquer número de parâmetros, mas pelo menos um parâmetro é obrigatório para identificar o elemento desejado.
// 4. Os indexadores podem ser sobrecarregados.
// 5. Eles podem ser definidos como públicos, privados, protegidos ou internos, conforme necessário.

// Exemplo de uso de um indexador:
public class ExemploIndexador
{
    private string[] dados = new string[10];

    public string this[int indice]
    {
        get
        {
            return dados[indice];
        }
        set
        {
            dados[indice] = value;
        }
    }
}

// Uso de indexadores:
ExemploIndexador exemplo = new ExemploIndexador();
exemplo[0] = "Primeiro elemento"; // Define o valor do elemento no índice 0
string valor = exemplo[0]; // Recupera o valor do elemento no índice 0

// Indexadores oferecem uma maneira conveniente de acessar os elementos de uma classe como se fossem arrays, o que pode ser útil em muitas situações.

