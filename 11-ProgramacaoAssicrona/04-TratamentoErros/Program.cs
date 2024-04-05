// ## Tratamento de Exceções em Tarefas Assíncronas em C#: Exemplo Completo

// ```csharp
async Task Main()
{
    try
    {
        // Inicia o download em uma tarefa separada
        var downloadTask = DownloadArquivoAsync("https://exemplo.com/arquivo.txt");

        // Define um manipulador para o evento Exception
        downloadTask.Exception += (sender, ex) =>
        {
            // Registra a exceção em um log
            Log.Error(ex.Message);

            if (ex is WebException)
            {
                Console.WriteLine($"Erro de rede: {ex.Message}");
            }
            else
            {
                Console.WriteLine($"Erro ao baixar o arquivo: {ex.Message}");
            }
        };

        // Aguarda a conclusão da tarefa
        await downloadTask;

        // Exibe o conteúdo do arquivo se o download for bem-sucedido
        if (downloadTask.IsCompletedSuccessfully)
        {
            var conteudoArquivo = await downloadTask;
            Console.WriteLine($"Conteúdo do arquivo: {conteudoArquivo}");
        }
    }
    catch (Exception ex)
    {
        // Exceção não tratada na tarefa
        Console.WriteLine($"Erro inesperado: {ex.Message}");
    }
}

async Task DownloadArquivoAsync(string url)
{
    try
    {
        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();

            // Processa o conteúdo baixado
        }
    }
    catch (Exception ex)
    {
        // Lança a exceção para o manipulador na função Main
        throw ex;
    }
// }
// ```

// **Explicações:**

// * Este código demonstra como tratar exceções em uma tarefa assíncrona de download de um arquivo usando uma combinação de `try-catch` e manipuladores de eventos.
// * O bloco `try-catch` na função `Main` captura exceções não tratadas na tarefa.
// * O manipulador de eventos `Exception` registra a exceção em um log e exibe uma mensagem de erro específica para o tipo de exceção.
// * A função `DownloadArquivoAsync` também usa um bloco `try-catch` para lançar a exceção para o manipulador na função `Main`.

// **Observações:**

// * Este é um exemplo simples.
// * O tratamento de exceções pode ser mais complexo em cenários reais.
// * É importante considerar o impacto das exceções no desempenho e na confiabilidade da aplicação.

// **Recursos Adicionais:**

// * Documentação da Microsoft sobre tratamento de exceções: [https://es.wiktionary.org/wiki/removido](https://es.wiktionary.org/wiki/removido)
// * Tutoriais sobre tratamento de exceções em tarefas assíncronas: [https://es.wiktionary.org/wiki/removido](https://es.wiktionary.org/wiki/removido)
