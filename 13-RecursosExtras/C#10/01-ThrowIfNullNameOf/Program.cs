// ThrowIfNull:

// Introduzido no C# 9.0 para auxiliar na verificação de nulidade de objetos de forma concisa e legível.
// Permite lançar uma exceção ArgumentNullException se o valor for nulo, evitando código redundante para verificação e lançamento de exceção.
// Sintaxe: ThrowIfNull(obj, nameof(obj)).
// Argumentos:
// obj: O objeto a ser verificado.
// nameof(obj): Uma expressão que gera o nome da variável do objeto.

// Exemplo:

string? nome = null;

nome.ThrowIfNull(); // Lança uma exceção ArgumentNullException se nome for nulo

// Código equivalente usando verificação explícita
// if (nome == null)
// {
//     throw new ArgumentNullException(nameof(nome));
// }
// Use code with caution.

// nameof:

// Operador do C# 6.0 que gera uma string literal com o nome da variável ou membro especificado.
// Útil para evitar erros de digitação e melhorar a legibilidade do código ao usar propriedades, métodos e variáveis em mensagens de exceção e outras situações.
// Argumentos:
// Nome da variável, propriedade ou método.

// Exemplo:

public void Save(string nome)
{
    if (string.IsNullOrEmpty(nome))
    {
        throw new ArgumentException("O nome não pode ser nulo ou vazio.", nameof(nome));
    }

    // ...
}
// Use code with caution.

// Vantagens de usar ThrowIfNull e nameof:

// Concisão: Reduz a quantidade de código necessária para verificar nulidade e lançar exceções.
// Legibilidade: Torna o código mais fácil de entender e depurar.
// Segurança: Evita erros de digitação nos nomes das variáveis e membros.

// Observações:

// ThrowIfNull é um método de extensão definido no namespace System.Runtime.CompilerServices.
// nameof é um operador e não uma função.
// Use ThrowIfNull com cuidado, pois pode lançar exceções inesperadas se o valor for nulo.
// Use nameof com moderação para evitar poluir o código com strings literais.

// Recursos adicionais:

// Documentação oficial da Microsoft sobre ThrowIfNull: [URL inválido removido]
// Documentação oficial da Microsoft sobre nameof: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/nameof

// Espero que este resumo completo tenha sido útil! Se você tiver qualquer dúvida sobre ThrowIfNull e nameof, não hesite em perguntar.

// Exemplos Adicionais:

// Usando ThrowIfNull com métodos:
// public string GetNomeCompleto(Pessoa pessoa)
// {
//     pessoa.ThrowIfNull(); // Lança uma exceção se pessoa for nulo
// 
//     return $"{pessoa.Nome} {pessoa.Sobrenome}";
// }
// Use code with caution.

// Usando nameof com propriedades:
// public class Pessoa
// {
//     public string Nome { get; set; }
//     public int Idade { get; set; }
// }
// 
// public void ValidarPessoa(Pessoa pessoa)
// {
//     if (string.IsNullOrEmpty(pessoa.Nome))
//     {
//         throw new ArgumentException("O nome da pessoa não pode ser nulo ou vazio.", nameof(pessoa.Nome));
//     }
// 
//     if (pessoa.Idade < 0)
//     {
//         throw new ArgumentException("A idade da pessoa não pode ser negativa.", nameof(pessoa.Idade));
//     }
// 
// }
// Use code with caution.

// Conclusão:

// ThrowIfNull e nameof são ferramentas valiosas em C# 9.0 que podem ajudar a escrever código mais conciso, legível e seguro. Utilize-os em suas aplicações para melhorar a qualidade do seu código e evitar erros de nulidade.
