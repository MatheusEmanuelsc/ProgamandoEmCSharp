// Arrays bidimensionais (ou matrizes) em C# são estruturas de dados que armazenam elementos em linhas e colunas, formando uma grade ou tabela

// Sintaxe para declaração e inicialização de uma matriz bidimensional:
int[,] matriz = new int[3, 3]; // Declara uma matriz bidimensional 3x3 de inteiros

// Os elementos de uma matriz bidimensional são acessados usando dois índices: um para a linha e outro para a coluna
// O índice da linha e o índice da coluna são separados por uma vírgula dentro dos colchetes []

// Exemplo de atribuição de valor a um elemento de matriz:
matriz[0, 0] = 1; // Define o elemento na linha 0 e coluna 0 como 1

// Iterando sobre uma matriz bidimensional usando loops 'for':
for (int linha = 0; linha < matriz.GetLength(0); linha++)
{
    for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
    {
        Console.Write(matriz[linha, coluna] + " "); // Exibe o elemento na posição [linha, coluna]
    }
    Console.WriteLine(); // Quebra de linha após cada linha
}

// Para obter o comprimento de uma dimensão específica de uma matriz, use o método GetLength(dimensão)
// O argumento 'dimensão' especifica qual dimensão (0 para linhas, 1 para colunas, etc.) você deseja obter o comprimento

// Matrizes bidimensionais são frequentemente usadas para representar dados tabulares, como grades de jogos, tabelas de classificação, imagens e muito mais

