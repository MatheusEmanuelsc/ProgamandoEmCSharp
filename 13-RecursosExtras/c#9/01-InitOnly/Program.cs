// Propriedades "Init Only" em C# 9.0

// As propriedades "init only", introduzidas no C# 9.0, fornecem uma maneira de criar propriedades imutáveis em classes e structs. Elas permitem que você defina uma propriedade que só pode ser inicializada durante a criação da instância (no construtor) ou na inicialização do objeto.

// Benefícios:

// Imutabilidade: Garante que o valor da propriedade não possa ser alterado após a inicialização, tornando o código mais seguro e previsível.
// Código mais conciso: Evita a necessidade de inicializar explicitamente os campos correspondentes dentro do construtor.
// Melhor legibilidade: A intenção de imutabilidade fica clara pela sintaxe da propriedade.

// Como funciona:

// Sintaxe: Você declara uma propriedade "init only" usando a palavra-chave init após o modificador de acesso (por exemplo, public init).
// Inicialização: A propriedade "init only" só pode ser atribuída:
// No construtor da classe ou struct.
// Durante a inicialização do objeto usando inicializadores de objeto.
// Acesso: Após a inicialização, a propriedade se comporta como uma propriedade get normal (somente leitura).

// Exemplo:

public class Pessoa
{
    public string Nome { get; init; } // Propriedade init-only
    public int Idade { get; set; } // Propriedade normal (mutável)

    public Pessoa(string nome, int idade)
    {
        Nome = nome; // Inicialização da propriedade init-only
        Idade = idade;
    }
}

Pessoa pessoa1 = new Pessoa("João", 30); // Inicialização durante a criação da instância

// pessoa1.Nome = "Maria"; // Erro: tentativa de modificar propriedade imutável
Console.WriteLine(pessoa1.Nome); // Saída: João

// Use code with caution.

// Observações importantes:

// Propriedades "init only" não requerem um campo correspondente na classe.
// Você não pode usar o inicializador de propriedade (por exemplo, auto ou = valor) com propriedades "init only".

// Quando usar propriedades "init only":

// Classes ou structs que representam dados imutáveis.
// Cenários onde você deseja garantir que o estado de um objeto não seja alterado após a criação.
// Simplificando a inicialização de objetos complexos.

// Conclusão:

// Propriedades "init only" são uma adição valiosa ao C# 9.0 que permite a criação de classes e structs imutáveis de forma simples e eficiente. Utilize-as para melhorar a segurança do seu código, a legibilidade e para representar dados que não devem ser modificados após a inicialização.
