// ## Cancelamento de Tarefas em C#: Exemplo Completo

// ```csharp
// Define um CancellationToken
var cancellationToken = new CancellationTokenSource();

async Task DownloadArquivoAsync(string url, CancellationToken token)
{
    try
    {
        using (var httpClient = new HttpClient())
        {
            while (!token.IsCancellationRequested)
            {
                // Simula um download demorado
                var response = await httpClient.GetAsync(url, cancellationToken);
                var content = await response.Content.ReadAsStringAsync();

                // Processa o conteúdo baixado

                // Verifica se o token foi cancelado
                if (token.IsCancellationRequested)
                {
                    break;
                }
            }
        }
    }
    catch (OperationCanceledException)
    {
        Console.WriteLine("Download cancelado!");
    }
}

async Task Main()
{
    // Inicia o download em uma tarefa separada
    var downloadTask = DownloadArquivoAsync("https://exemplo.com/arquivo.txt", cancellationToken.Token);

    // Após 5 segundos, cancela o download
    await Task.Delay(5000);
    cancellationToken.Cancel();

    // Aguarda a conclusão da tarefa
    await downloadTask;
}
// ```

// **Explicações:**

// * O código acima demonstra como cancelar uma operação assíncrona de download de um arquivo usando um `CancellationToken`.
// * A função `DownloadArquivoAsync` recebe um `CancellationToken` como parâmetro e verifica se ele foi cancelado antes de continuar a operação.
// * Se o token for cancelado, a função lança uma exceção `OperationCanceledException`.
// * A função principal inicia o download em uma tarefa separada e cancela o download após 5 segundos.

// **Observações:**

// * Este é um exemplo simples.
// * O cancelamento de tarefas pode ser mais complexo em cenários reais.
// * É importante considerar os efeitos do cancelamento no código e utilizar técnicas de cancelamento com cuidado para evitar erros e inconsistências.

// **Recursos Adicionais:**

// * Documentação da Microsoft sobre cancelamento de tarefas: [URL inválido removido]
// * Tutoriais sobre cancelamento de tarefas: [URL inválido removido]
