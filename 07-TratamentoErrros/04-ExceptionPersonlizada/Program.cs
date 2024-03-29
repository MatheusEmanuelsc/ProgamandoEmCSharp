// Resumo - Exceções Personalizadas em C#:

// Exceções personalizadas em C# são usadas para representar condições excepcionais específicas dentro de um programa que não são adequadamente abordadas pelas exceções pré-definidas do .NET.

// Características Principais:
// - Você pode criar suas próprias exceções personalizadas derivando da classe base Exception ou de suas subclasses.
// - As exceções personalizadas devem fornecer informações relevantes sobre o problema ocorrido, como mensagens de erro descritivas e detalhes específicos do contexto.
// - É comum adicionar propriedades adicionais às exceções personalizadas para incluir informações específicas sobre o estado do sistema no momento da exceção.
// - As exceções personalizadas devem ser devidamente documentadas para que os desenvolvedores que as utilizam compreendam como lidar com elas corretamente.

// Exemplo de Exceção Personalizada:
public class MinhaExcecaoPersonalizada : Exception
{
    public MinhaExcecaoPersonalizada() { }
    public MinhaExcecaoPersonalizada(string mensagem) : base(mensagem) { }
    public MinhaExcecaoPersonalizada(string mensagem, Exception inner) : base(mensagem, inner) { }
    
    // Propriedades adicionais
    public string Detalhes { get; set; }
}

// Exemplo de Uso:
public void MetodoQuePodeLancarExcecao()
{
    if (condicao)
    {
        throw new MinhaExcecaoPersonalizada("Ocorreu um problema específico.");
    }
}

// Explicação:
// - Na sintaxe acima, criamos uma classe MinhaExcecaoPersonalizada que herda de Exception e fornece construtores para lidar com diferentes cenários de lançamento.
// - Adicionamos uma propriedade adicional 'Detalhes' para incluir informações específicas sobre o problema que causou a exceção.
// - Dentro do método que pode lançar a exceção, usamos a palavra-chave throw para lançar uma instância da nossa exceção personalizada quando uma condição específica é atendida.
