// Introdução:
// - DateOnly e TimeOnly são novos tipos de estrutura introduzidos no C# 10.0 para representar datas e horas sem incluir informações de fuso horário.
// - Eles complementam o tipo DateTime, oferecendo uma abordagem mais específica para lidar com datas e horas em cenários onde não é necessário considerar fusos horários.

// Características Principais:
// - DateOnly: Representa uma data sem incluir informações de hora ou fuso horário.
// - TimeOnly: Representa um horário específico dentro de um dia, sem incluir informações de data ou fuso horário.
// - Ambos os tipos são imutáveis, o que significa que uma vez criados, seus valores não podem ser alterados.
// - Eles fornecem métodos específicos para realizar operações comuns relacionadas a datas e horas, como cálculos de diferença, comparações e formatação de saída.

// Benefícios:
// 1. Precisão e Clareza: Os tipos DateOnly e TimeOnly oferecem uma maneira mais precisa e clara de lidar com datas e horas quando a informação de fuso horário não é necessária.
// 2. Segurança: Por serem tipos imutáveis, eles ajudam a evitar problemas relacionados à mutabilidade, contribuindo para a segurança e consistência do código.
// 3. Sintaxe Simplificada: Ao usar DateOnly e TimeOnly, é possível escrever código mais legível e expressivo, especialmente em cenários onde apenas a data ou hora é relevante.

// Exemplo de Uso:
DateOnly data = new DateOnly(2024, 03, 26); // Representa a data 26 de março de 2024
TimeOnly hora = new TimeOnly(14, 30, 0); // Representa o horário 14:30:00

Console.WriteLine($"Data: {data}"); // Saída: Data: 26/03/2024
Console.WriteLine($"Hora: {hora}"); // Saída: Hora: 14:30:00

// Considerações Finais:
// - DateOnly e TimeOnly são úteis em situações onde é necessário lidar com datas e horas de forma mais específica, sem a complexidade dos fusos horários.
// - Ao usar esses tipos, é importante considerar as necessidades do aplicativo e garantir que eles sejam aplicáveis aos requisitos de negócios específicos.
// - Com o uso adequado de DateOnly e TimeOnly, é possível escrever código mais seguro, claro e preciso ao lidar com manipulações de datas e horas em suas aplicações.
