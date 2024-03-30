```csharp
// Resumo Completo sobre a Classe DirectoryInfo em C#
/*
A classe DirectoryInfo em C# representa um diretório no sistema de arquivos e fornece funcionalidades para manipulá-lo e obter informações detalhadas sobre ele.
Ela complementa a classe Directory, que oferece métodos estáticos para operações básicas de diretórios.
*/

// Funcionalidades da classe DirectoryInfo:
/*
Obtenção de informações do diretório: O DirectoryInfo permite obter informações detalhadas sobre o diretório, como nome, diretório pai, data de criação, data de modificação e atributos do diretório.
Operações de diretório: O DirectoryInfo possibilita realizar operações em diretórios, como criar um novo subdiretório, excluir o diretório (incluindo subdiretórios e arquivos), mover o diretório para outro local, copiar o diretório para outro local com opção de copiar recursivamente subdiretórios e arquivos, e enumerar arquivos e subdiretórios.
Verificação de existência: Similar ao Directory.Exists, permite verificar se o diretório existe.
*/

// Exemplo de uso da classe DirectoryInfo:
string directoryPath = @"C:\meuDiretorio";

DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

// Verificar se o diretório existe
if (directoryInfo.Exists)
{
    Console.WriteLine("Nome do diretório: {0}", directoryInfo.Name);
    Console.WriteLine("Data de criação: {0}", directoryInfo.CreationTime);

    // Criar um novo subdiretório
    directoryInfo.CreateSubdirectory("novo_subdiretorio");

    // Enumerar arquivos no diretório
    FileInfo[] files = directoryInfo.GetFiles();
    foreach (FileInfo file in files)
    {
        Console.WriteLine("Nome do arquivo: {0}", file.Name);
    }
}
else
{
    Console.WriteLine("Diretório não existe.");
}

// Observações importantes:
/*
Similar ao Directory, os métodos do DirectoryInfo podem lançar exceções. É importante tratar essas exceções no código.
Use APIs de segurança do .NET para garantir acesso seguro aos diretórios.
*/

// Para mais informações:
/*
Documentação da Microsoft sobre a classe DirectoryInfo: https://learn.microsoft.com/en-us/dotnet/api/system.io.directoryinfo?view=net-8.0
Tutoriais sobre a classe DirectoryInfo: https://github.com/petercoker/coding-with-mosh
Exemplos de uso da classe DirectoryInfo: https://learn.microsoft.com/en-us/dotnet/api/system.io.filestream?view=net-8.0
*/
```