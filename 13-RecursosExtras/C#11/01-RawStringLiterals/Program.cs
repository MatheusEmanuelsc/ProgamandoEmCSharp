```csharp
// O que são raw string literals?

// Raw string literals, também conhecidas como literais de cadeia de caracteres brutas, são uma forma especial de definir 
// strings em C# introduzida na versão 11. Elas permitem que você inclua caracteres especiais e sequências de escape 
// dentro da string sem a necessidade de escape adicional.

// Benefícios de usar raw string literals:

// Definição de strings com caracteres especiais: Simplifica a inclusão de caracteres como backslashes (\), aspas duplas ("), 
// aspas simples (') e outros caracteres especiais dentro da string sem a necessidade de escape.
// Melhora a legibilidade: Torna o código mais fácil de ler e entender, pois os caracteres aparecem exatamente como você 
// deseja que sejam interpretados.
// Evita confusão com sequências de escape: Reduz a chance de erros causados pelo uso incorreto de sequências de escape 
// em strings literais tradicionais.

// Como definir um raw string literal:

// Você pode definir um raw string literal usando três aspas duplas (""") no início e no final da string.

// Exemplo:

string filePath = @"C:\Users\usuario\Documents\meu_arquivo.txt"; // String literal tradicional com escape

string filePathRaw = @"""C:\Users\usuario\Documents\meu_arquivo.txt"""; // Raw string literal

Console.WriteLine(filePath);  // Saída: C:\Users\usuario\Documents\meu_arquivo.txt (com escape)
Console.WriteLine(filePathRaw); // Saída: C:\Users\usuario\Documents\meu_arquivo.txt (sem escape)
// Use code with caution.

// Observações importantes:

// Dentro de um raw string literal, sequências como \n (nova linha), \t (tabulação) e outros mantêm seu significado literal.
// Você pode interpolar variáveis dentro de um raw string literal usando a sintaxe $"{variavel}".

// Quando usar raw string literals:

// Definição de caminhos de arquivo com barras invertidas (\).
// Inclusão de strings com aspas duplas (") ou aspas simples (') sem necessidade de escape.
// Definição de strings com sequências de caracteres especiais que você deseja que sejam interpretadas literalmente.

// Conclusão:

// Raw string literals são uma adição útil ao C# que facilita a definição de strings com caracteres especiais e melhora 
// a legibilidade do código. Use-as sempre que precisar incluir caracteres que normalmente requerem escape em strings literais tradicionais.
```