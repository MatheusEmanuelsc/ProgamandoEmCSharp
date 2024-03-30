// O que é a classe File?
// A classe File em C# fornece métodos estáticos para manipular arquivos no sistema operacional.
// Ela permite realizar operações como leitura, escrita, criação, exclusão e cópia de arquivos.

// Funcionalidades da classe File:

// Leitura de arquivos:
// A classe File fornece métodos para ler o conteúdo de um arquivo, como ReadAllText, ReadAllLines e ReadLines.

// Escrita em arquivos:
// A classe File fornece métodos para escrever conteúdo em um arquivo, como WriteAllText, WriteAllLines e AppendAllText.

// Criação e exclusão de arquivos:
// A classe File fornece métodos para criar e excluir arquivos, como Create, CreateText, Delete e Move.

// Cópia de arquivos:
// A classe File fornece métodos para copiar arquivos, como Copy e Move.

// Verificação de existência de arquivos:
// A classe File fornece métodos para verificar se um arquivo existe, como Exists.

// Obtenção de informações de arquivos:
// A classe File fornece métodos para obter informações sobre um arquivo, como tamanho, data de criação e data de modificação.

// Exemplo de uso da classe File:

// Ler o conteúdo de um arquivo
string conteudo = File.ReadAllText("meu_arquivo.txt");

// Escrever conteúdo em um arquivo
File.WriteAllText("meu_arquivo.txt", "Este é o conteúdo do meu arquivo");

// Criar um novo arquivo
File.Create("novo_arquivo.txt");

// Excluir um arquivo
File.Delete("arquivo_a_ser_excluido.txt");

// Copiar um arquivo
File.Copy("arquivo_origem.txt", "arquivo_destino.txt");

// Verificar se um arquivo existe
if (File.Exists("meu_arquivo.txt"))
{
    // ...
}

// Obter o tamanho de um arquivo
long tamanhoArquivo = new FileInfo("meu_arquivo.txt").Length;

// Obter a data de criação de um arquivo
DateTime dataCriacao = File.GetCreationTime("meu_arquivo.txt");

// Obter a data de modificação de um arquivo
DateTime dataModificacao = File.GetLastWriteTime("meu_arquivo.txt");
