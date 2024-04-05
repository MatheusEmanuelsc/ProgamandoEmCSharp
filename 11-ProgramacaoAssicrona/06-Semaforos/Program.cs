// ## Controle de Threads com Semáforos em C#: Exemplo Completo

// **Exemplo de Código:**

// ```csharp
using System;
using System.Threading;

public class SemaphoreExample
{
    private static readonly Semaphore _semaphore = new Semaphore(2, 2);

    public static void Main()
    {
        for (int i = 0; i < 4; i++)
        {
            int threadNumber = i + 1;
            new Thread(() =>
            {
                _semaphore.WaitOne();
                Console.WriteLine($"Thread {threadNumber} entrou na área crítica");
                Thread.Sleep(2000);
                Console.WriteLine($"Thread {threadNumber} saiu da área crítica");
                _semaphore.Release();
            }).Start();
        }
    }
}
```

// **Explicações:**

// * O código acima demonstra como utilizar semáforos para controlar o acesso a uma área crítica por threads.
// * Um semáforo é um objeto de sincronização que permite que um número limitado de threads acesse um recurso simultaneamente.
// * No exemplo, o semáforo é inicializado com 2 permissões, permitindo que 2 threads acessem a área crítica ao mesmo tempo.
// * As threads que tentam acessar a área crítica quando o semáforo está cheio serão bloqueadas até que uma das threads que está na área crítica libere uma permissão.
// * O método `WaitOne` bloqueia a thread atual até que uma permissão esteja disponível.
// * O método `Release` libera uma permissão do semáforo.

// **Benefícios do Uso de Semáforos:**

// * Controle preciso do acesso a recursos compartilhados.
// * Prevenção de condições de corrida e outros problemas de sincronização.
// * Melhoria na escalabilidade e desempenho de aplicações multithread.

// **Observações:**

// * Este é um exemplo simples.
// * Semáforos podem ser usados em diversos cenários para controlar o acesso a recursos como bancos de dados, arquivos e dispositivos de hardware.
// * É importante escolher o tipo de objeto de sincronização mais adequado para cada caso de uso.

// **Recursos Adicionais:**

// * Documentação da Microsoft sobre semáforos: [https://es.wiktionary.org/wiki/removido](https://es.wiktionary.org/wiki/removido)
// * Tutoriais sobre controle de threads com semáforos em C#: [https://es.wiktionary.org/wiki/removido](https://es.wiktionary.org/wiki/removido)

// **Exemplo Completo com Implementação de Fila de Espera:**

// ```csharp
using System;
using System.Collections.Generic;
using System.Threading;

public class SemaphoreWithQueueExample
{
    private static readonly Semaphore _semaphore = new Semaphore(2, 2);
    private static readonly Queue<int> _waitingQueue = new Queue<int>();

    public static void Main()
    {
        for (int i = 0; i < 4; i++)
        {
            int threadNumber = i + 1;
            new Thread(() =>
            {
                int queuePosition;
                lock (_waitingQueue)
                {
                    _waitingQueue.Enqueue(threadNumber);
                    queuePosition = _waitingQueue.Count;
                }

                Console.WriteLine($"Thread {threadNumber} entrou na fila de espera (posição {queuePosition})");

                _semaphore.WaitOne();

                lock (_waitingQueue)
                {
                    _waitingQueue.Dequeue();
                }

                Console.WriteLine($"Thread {threadNumber} entrou na área crítica");
                Thread.Sleep(2000);
                Console.WriteLine($"Thread {threadNumber} saiu da área crítica");
                _semaphore.Release();
            }).Start();
        }
    }
}
// ```

// **Explicações:**

// * Este exemplo demonstra como implementar uma fila de espera usando um semáforo e uma fila.
// * A fila de espera armazena os IDs das threads que estão aguardando para acessar a área crítica.
// * Quando uma thread libera uma permissão do semáforo, a primeira thread na fila é liberada para entrar na área crítica.

// **Observações:**

// * Este é um exemplo mais complexo que demonstra como usar semáforos para implementar uma fila de espera.
// * Este tipo de implementação pode ser útil em cenários em que o acesso a um recurso é limitado e as threads precisam esperar sua vez para acessá-lo.
