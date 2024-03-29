// Resumo Completo sobre Event Handlers em C# com Exemplos Detalhados

/*
O que são Event Handlers?

Em C#, Event Handlers (Manipuladores de Eventos) são métodos que respondem a eventos específicos. Eles definem as ações que serão executadas quando um evento for acionado por um objeto.

Como funcionam os Event Handlers?

Declaração de um Evento: Um evento é declarado usando a palavra-chave event seguida do tipo de delegate que representa o evento.
Criação de um Manipulador de Eventos: O manipulador de eventos é um método que define a ação a ser realizada quando o evento for acionado.
Assinatura do Evento: Um objeto se inscreve em um evento chamando o método Subscribe() do evento e passando o manipulador de eventos como argumento.
Publicação do Evento: Quando o evento ocorre, o método Invoke() do evento é chamado, o que por sua vez chama todos os manipuladores de eventos que foram assinados ao evento.

Exemplo Detalhado:
*/
public class Button
{
    // Declaração do evento Click
    public event EventHandler Click;

    public void OnClick()
    {
        // Chamar o evento
        Click?.Invoke(this, EventArgs.Empty);
    }
}

public class Form
{
    public Form()
    {
        var button = new Button();

        // Assinatura do evento Click com um método específico
        button.Click += Button_Click;

        // Assinatura do evento Click com uma expressão lambda
        button.Click += (sender, e) => Console.WriteLine("Button clicked!");
    }

    private void Button_Click(object sender, EventArgs e)
    {
        // Manipulador de eventos
        Console.WriteLine("Button clicked! (método específico)");
    }
}

/*
Benefícios dos Event Handlers:

   - Comunicação desacoplada: Permitem que os objetos se comuniquem sem precisar saber uns dos outros.
   - Reutilização de código: Permitem a reutilização de código em diferentes contextos.
   - Extensibilidade: Permitem que você adicione novos comportamentos a objetos existentes.
   
Considerações:

   - Complexidade: O uso excessivo de event handlers pode tornar o código mais difícil de entender e manter.
   - Desempenho: Em alguns casos, o uso de event handlers pode ter um impacto no desempenho do código.
*/

// Conclusão:

// Event Handlers são um mecanismo fundamental para o desenvolvimento de interfaces de usuário interativas e para comunicação entre objetos em C#. Eles permitem que você escreva código mais desacoplado, 
// reutilizável e extensível. É importante usá-los com moderação e estar ciente dos seus benefícios e considerações.

// Recursos Adicionais:

// Documentação da Microsoft sobre Eventos: https://docs.microsoft.com/pt-br/dotnet/standard/events/
// Artigo sobre Event Handlers em C#: [URL inválido removido]

// 1. Event Handlers Simples:
// 2. Event Handlers com Argumentos Adicionais:



// 1. Event Handlers Simples:

// Recebem apenas dois parâmetros: sender e e.
// O parâmetro sender é uma referência ao objeto que gerou o evento.
// O parâmetro e é um objeto que contém informações adicionais sobre o evento.

// Exemplo:

public class Button
{
    public event EventHandler Click;

    public void OnClick()
    {
        Click?.Invoke(this, EventArgs.Empty);
    }
}

public class Form
{
    public Form()
    {
        var button = new Button();
        button.Click += Button_Click;
    }

    private void Button_Click(object sender, EventArgs e)
    {
        Console.WriteLine("Button clicked!");
    }
}

// 2. Event Handlers com Argumentos Adicionais:

// O evento pode ser declarado com parâmetros adicionais para fornecer mais informações ao manipulador de eventos.
// Esses parâmetros podem ser usados para personalizar o comportamento do manipulador de eventos.

// Exemplo:

public class Button
{
    public event EventHandler<EventArgs<string>> Click;

    public void OnClick(string message)
    {
        Click?.Invoke(this, new EventArgs<string>(message));
    }
}

public class Form
{
    public Form()
    {
        var button = new Button();
        button.Click += Button_Click;
    }

    private void Button_Click(object sender, EventArgs<string> e)
    {
        Console.WriteLine(e.Value); // Exibe a mensagem passada como argumento
    }
}

// Conclusão:

// O resumo cobre os dois tipos de Event Handlers, fornecendo exemplos detalhados para cada um deles. É importante entender os diferentes tipos de Event Handlers para escolher o tipo mais adequado para cada caso.

// Recursos Adicionais:

// Documentação da Microsoft sobre Eventos: https://docs.microsoft.com/pt-br/dotnet/standard/events/
// Artigo sobre Event Handlers em C#: [URL inválido removido]
