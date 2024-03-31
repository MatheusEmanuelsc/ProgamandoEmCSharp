// O que é um Record?

// Um Record é um tipo de classe especial introduzido no C# 9.0 para representar dados imutáveis e comparáveis. Eles são projetados para serem concisos, eficientes e fáceis de usar, tornando-os ideais para modelar entidades com um conjunto bem definido de propriedades.

// Características dos Records:

// Imutabilidade: Uma vez criado, um Record não pode ser modificado. Isso garante a consistência do estado do objeto e facilita o raciocínio sobre o código.
// Comparação de valor: Dois Records são considerados iguais se seus valores de propriedade forem iguais. Isso simplifica a comparação de objetos e a implementação de coleções.
// Desconstrução: Records podem ser facilmente desconstruídos em seus componentes individuais, facilitando o acesso aos valores das propriedades.
// Construtores com nome: Records podem ter construtores com nome para inicializar suas propriedades de forma flexível.
// ToString() implícito: Records possuem uma implementação implícita do método ToString() que gera uma string de representação textual clara e concisa.
// Suporte a interfaces: Records podem implementar interfaces para fornecer funcionalidades adicionais.
// Herança: Records podem herdar de outras classes e Records, permitindo reuso de código e implementação de polimorfismo.

// Exemplos de Records:

public record Pessoa(string Nome, int Idade); // Record simples com duas propriedades

public record Ponto3D(double X, double Y, double Z) : IComparable<Ponto3D> // Record com herança e implementação de interface
{
    public int CompareTo(Ponto3D other) => ...; // Implementação da comparação de valor
}

// Benefícios do uso de Records:

// Código mais conciso: Reduz a quantidade de código necessária para definir classes imutáveis.
// Maior segurança: Garante a imutabilidade dos dados, evitando erros de modificação acidental.
// Melhor legibilidade: O código fica mais claro e fácil de entender.
// Desempenho eficiente: Records são otimizados para uso eficiente de memória e CPU.

// Quando usar Records:

// Modelagem de entidades imutáveis como pontos, datas, coordenadas, etc.
// Criação de objetos de valor para encapsular dados e lógica.
// Implementação de coleções de objetos imutáveis.
// Desenvolvimento de APIs concisas e fáceis de usar.

// Conclusão:

// Records são uma ferramenta poderosa e versátil para modelar dados imutáveis em C#. Eles oferecem diversos benefícios em termos de concisão, segurança, legibilidade e desempenho. Se você precisa trabalhar com dados imutáveis, considere usar Records para simplificar seu código e melhorar a qualidade geral do seu software.

// Recursos adicionais:

// Documentação oficial da Microsoft sobre Records: https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/records
// Tutoriais e exemplos de uso de Records: https://m.youtube.com/watch?v=M_TQgNKAie8

// Observações:

// Records não são adequados para todos os cenários. Se você precisa de um objeto mutável, use uma classe tradicional.
// Records são uma feature relativamente nova do C#. Certifique-se de que seu ambiente de desenvolvimento e bibliotecas estejam atualizados para suportá-los.
