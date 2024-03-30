// Resumo Completo da Classe Stream em C#
/*
O que é a classe Stream?

A classe Stream em C# representa um fluxo de dados abstraído, fornecendo uma interface para leitura e escrita em diferentes tipos de fontes de dados, como arquivos, dispositivos de rede e memória.
Ela oferece funcionalidades básicas para manipular dados de forma genérica, independente da origem ou destino específico.
*/

// Funcionalidades da classe Stream:
/*
Leitura e escrita de dados: A classe Stream fornece métodos para ler e escrever bytes, caracteres ou blocos de dados de forma eficiente.
Posicionamento no fluxo: Você pode navegar pelo fluxo de dados usando métodos para buscar, avançar e definir a posição atual de leitura/escrita.
Suporte a diferentes tipos de dados: A classe Stream é genérica e pode ser usada com diversos tipos de dados, como strings, imagens, arquivos de texto e binários.
Monitoramento de progresso: É possível monitorar o progresso da leitura ou escrita de dados através de eventos e propriedades específicas.
Implementação de interfaces: A classe Stream implementa interfaces como IDisposable para garantir a liberação adequada de recursos.
*/

// Exemplos de uso da classe Stream:
/*
Ler um arquivo:
*/
using (FileStream fileStream = new FileStream("meu_arquivo.txt", FileMode.Open))
{
    byte[] bytes = new byte[fileStream.Length];
    fileStream.Read(bytes, 0, bytes.Length);

    // Processar os bytes lidos
}
// Use code with caution.

/*
Escrever em um arquivo:
*/
using (StreamWriter streamWriter = new StreamWriter("meu_arquivo.txt"))
{
    streamWriter.WriteLine("Este é o conteúdo do meu arquivo");
}
// Use code with caution.

/*
Ler dados de um dispositivo de rede:
*/
using (TcpClient tcpClient = new TcpClient("localhost", 80))
{
    using (NetworkStream networkStream = tcpClient.GetStream())
    {
        byte[] bytes = new byte[1024];
        int bytesRead = networkStream.Read(bytes, 0, bytes.Length);

        // Processar os bytes lidos
    }
}
// Use code with caution.

// Observações importantes:
/*
Tipos específicos de streams: Existem classes derivadas de Stream que oferecem funcionalidades específicas para diferentes tipos de fontes de dados, como FileStream para arquivos e NetworkStream para redes.
Gerenciamento de recursos: É fundamental usar o bloco using para garantir que os recursos do stream sejam liberados corretamente após o uso.
Tratamento de exceções: É importante tratar exceções que podem ocorrer durante operações de leitura e escrita em um stream.
*/

// Para mais informações:
/*
Documentação da Microsoft sobre a classe Stream: https://learn.microsoft.com/en-us/dotnet/api/system.io.stream?view=net-8.0
Tutoriais sobre a classe Stream: https://members.codewithmosh.com/p/csharp-basics-for-beginners
Exemplos de código para usar a classe Stream: https://learn.microsoft.com/en-us/dotnet/api/system.io.filestream?view=net-8.0
*/
