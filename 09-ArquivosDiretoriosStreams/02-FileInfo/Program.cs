// Resumo Completo sobre a Classe FileInfo em C#

// A classe FileInfo em C# representa um arquivo no sistema de arquivos e fornece informações detalhadas sobre ele.
// Ela complementa a classe File, que oferece métodos estáticos para manipular arquivos.

// Funcionalidades da classe FileInfo:

// Obtenção de informações do arquivo:
// O FileInfo fornece propriedades para obter informações detalhadas sobre o arquivo, como:
// - Nome do arquivo
// - Diretório base
// - Tamanho do arquivo
// - Data de criação
// - Data de modificação
// - Atributos do arquivo (somente leitura, oculto, etc.)

// Operações básicas de arquivos:
// O FileInfo permite realizar algumas operações básicas em arquivos, como:
// - Criar um novo arquivo (complementar ao File.Create)
// - Abrir um arquivo para leitura ou escrita (utilizado com StreamWriter ou StreamReader)
// - Excluir o arquivo
// - Copiar o arquivo para outro local
// - Mover o arquivo para outro local

// Verificação de existência:
// Similar ao File.Exists, permite verificar se o arquivo existe.

// Exemplo de uso da classe FileInfo:

// Caminho do arquivo
string filePath = @"C:\ meuArquivo.txt";

// Instância do FileInfo
FileInfo fileInfo = new FileInfo(filePath);

// Verificar se o arquivo existe
if (fileInfo.Exists)
{
    Console.WriteLine("Nome do arquivo: {0}", fileInfo.Name);
    Console.WriteLine("Tamanho do arquivo: {0} bytes", fileInfo.Length);
    Console.WriteLine("Data de criação: {0}", fileInfo.CreationTime);

    // Abrir o arquivo para leitura
    using (StreamReader reader = fileInfo.OpenText())
    {
        string content = reader.ReadToEnd();
        Console.WriteLine("Conteúdo do arquivo: \n{0}", content);
    }
}
else
{
    Console.WriteLine("Arquivo não existe.");
}

// Neste exemplo, o FileInfo é utilizado para obter informações sobre um arquivo, verificar sua existência, e abrir o arquivo para leitura.

// Relação com a classe File:

// A classe File fornece métodos estáticos para operações comuns de arquivos, enquanto o FileInfo oferece uma representação mais detalhada do arquivo e permite operações baseadas em suas propriedades.
// Você pode usar o caminho do arquivo para criar uma instância do FileInfo.

// Observações importantes:

// Similar ao File, os métodos do FileInfo podem lançar exceções. É importante tratar essas exceções no código.
// Use APIs de segurança do .NET para garantir acesso seguro aos arquivos.

// Para mais informações:

// Documentação da Microsoft sobre a classe FileInfo: https://learn.microsoft.com/en-us/dotnet/api/system.io.fileinfo?view=net-8.0
// Tutoriais sobre a classe FileInfo: https://codewithmosh.com/p/the-ultimate-csharp-mastery-series
// Exemplos de uso da classe FileInfo: https://learn.microsoft.com/en-us/dotnet/api/system.io.filestream?view=net-8.0
