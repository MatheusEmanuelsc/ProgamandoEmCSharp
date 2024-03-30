// Resumo Completo sobre a Classe Directory em C#
/*
A classe Directory em C# fornece métodos estáticos para manipular diretórios no sistema operacional.
Ela permite realizar operações como criação, exclusão, listagem de arquivos e subdiretórios, e navegação na estrutura de diretórios.
*/

// Funcionalidades da classe Directory:
/*
Criação e exclusão de diretórios: A classe Directory fornece métodos para criar e excluir diretórios, como CreateDirectory e DeleteDirectory.
Listagem de arquivos e subdiretórios: A classe Directory fornece métodos para listar os arquivos e subdiretórios de um diretório, como GetFiles e GetDirectories.
Navegação na estrutura de diretórios: A classe Directory fornece métodos para navegar na estrutura de diretórios, como GetCurrentDirectory e SetCurrentDirectory.
Verificação de existência de diretórios: A classe Directory fornece métodos para verificar se um diretório existe, como Exists.
Obtenção de informações de diretórios: A classe Directory fornece métodos para obter informações sobre um diretório, como data de criação, data de modificação e atributos.
*/

// Exemplo de uso da classe Directory:
// Criar um novo diretório
Directory.CreateDirectory("meu_diretorio");

// Excluir um diretório
Directory.DeleteDirectory("diretorio_a_ser_excluido");

// Listar os arquivos de um diretório
string[] arquivos = Directory.GetFiles("meu_diretorio");

// Listar os subdiretórios de um diretório
string[] subdiretorios = Directory.GetDirectories("meu_diretorio");

// Obter o diretório atual
string diretorioAtual = Directory.GetCurrentDirectory();

// Navegar para outro diretório
Directory.SetCurrentDirectory("outro_diretorio");

// Verificar se um diretório existe
if (Directory.Exists("meu_diretorio"))
{
    // ...
}

// Obter a data de criação de um diretório
DateTime dataCriacao = Directory.GetCreationTime("meu_diretorio");

// Obter a data de modificação de um diretório
DateTime dataModificacao = Directory.GetLastWriteTime("meu_diretorio");

// Observações importantes:
/*
A classe Directory fornece métodos estáticos, o que significa que não é necessário criar uma instância da classe para usá-los.
Os métodos da classe Directory podem lançar exceções caso ocorram erros durante a operação. É importante tratar essas exceções no código.
É importante usar as APIs de segurança do .NET para garantir o acesso seguro aos diretórios.
*/

// Para mais informações:
/*
Documentação da Microsoft sobre a classe Directory: https://es.wiktionary.org/wiki/removido
Tutoriais sobre a classe Directory: https://es.wiktionary.org/wiki/removido
Exemplos de uso da classe Directory: https://es.wiktionary.org/wiki/removido
*/
