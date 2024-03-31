// Novas Linhas em Interpolação de String (C# 11 e superior):

// O C# 11 introduz uma maneira mais simples de incluir novas linhas em strings usando strings interpoladas literais com o símbolo @:

string mensagem = $@"Esta é uma string com
várias linhas";

// Use code with caution.

// O símbolo @ antes da aspa de abertura instrui o compilador a tratar toda a string literal como literal, incluindo qualquer caractere de espaço em branco embutido como novas linhas (\n), tabulações (\t) ou retornos de carro (\r). Isso permite que você escreva strings multilinha diretamente na expressão de interpolação, melhorando a legibilidade e a manutenabilidade.

// Pontos-chave:

// Use Environment.NewLine para quebras de linha condicionais com base no ambiente do sistema.
// Use strings interpoladas literais com @ para strings multilinha fixas dentro da interpolação.
// As novas linhas dentro de strings interpoladas literais são preservadas como parte da string resultante.

// Exemplo:

string poema = $@"
Rosas são vermelhas,
Violetas são azuis,
Eu gosto de escrever código,
E você também!
";

Console.WriteLine(poema);

// Use code with caution.

// Este código irá imprimir o poema exatamente como está escrito dentro da string interpolada literal, preservando as novas linhas e a indentação.

// Observações importantes:

// Atributos genéricos não podem ser usados ​​diretamente com o tipo dynamic.
// Você pode acessar o tipo genérico T dentro do atributo usando o nome T.
// Quando usar atributos genéricos:

// Cenários em que você precisa associar metadados a elementos do código com base em diferentes tipos de dados.
// Criando validações ou decorações que precisam funcionar com vários tipos.

// Conclusão:

// Atributos genéricos são uma adição valiosa ao C# 11 que melhora a tipagem, a reutilização de código e a segurança geral do código. Utilize-os para criar metadados flexíveis e adaptáveis ​​para seus elementos de código.
