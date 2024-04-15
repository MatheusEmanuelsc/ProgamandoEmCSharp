
// Required Members em C#

// Required members (membros obrigatórios) é um recurso introduzido no C# 11 que permite garantir a inicialização correta de propriedades ou campos de uma classe ou struct no momento da criação da instância.

// Como funciona:

// Marcando membros como required: Você aplica a modificação required a propriedades ou campos que devem ser inicializados obrigatoriamente.
// Regras de uso:
// Membros marcados como required devem ser inicializados por um construtor ou inicializador de objeto.
// Todos os construtores da classe ou struct devem inicializar explicitamente os membros required.
// A inicialização pode ser feita por atribuição direta ou usando expressões.

// Benefícios:
// Evita inicialização nula: Garante que membros críticos sejam inicializados antes do uso, evitando erros de NullReferenceException.
// Melhora a segurança: Torna o código mais robusto e menos propenso a bugs relacionados a inicialização incorreta.
// Maior clareza: Sinaliza claramente quais membros devem ser inicializados na criação da instância.

// Exemplo:

public class Pessoa
{
    public required string Nome { get; set; } // Propriedade requerida
    public int Idade { get; set; } // Propriedade não requerida

    public Pessoa(string nome, int idade) // Construtor que inicializa o membro required
    {
        Nome = nome;
        Idade = idade;
    }
}
// Use code with caution.

// Observações importantes:

// Membros marcados como required devem ter pelo menos a mesma visibilidade da classe ou struct que os contém.
// O compilador verifica se todos os construtores inicializam explicitamente os membros required.
// Você pode usar o atributo SetsRequiredMembers para isentar um construtor específico da obrigação de inicializar membros required.

// Quando usar required members:

// Classes ou structs com propriedades ou campos críticos que precisam ser inicializados antes do uso.
// Cenários onde a inicialização incorreta pode levar a erros de execução.
// Melhorar a clareza do código e a intenção do desenvolvedor.

// Conclusão:

// Required members é uma adição valiosa ao C# que ajuda a garantir a inicialização correta de propriedades e campos importantes, 
// tornando o código mais robusto e menos propenso a erros. Utilize-o para classes ou structs que possuem propriedades ou campos essenciais para seu funcionamento.
