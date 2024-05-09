// Concatenação Simples:
string nome = "Fulano";
int idade = 30;

string frase = nome + " tem " + idade + " anos.";

Console.WriteLine(frase); // Resultado: Fulano tem 30 anos.

// Concatenação com String.Format:

string nome2 = "Fulano";
int idade2 = 30;

string frase2 = String.Format("{0} 2 tem {1} 2 anos.", nome2, idade2);

Console.WriteLine(frase2); // Resultado: Fulano tem 30 anos.

// Interpolação de Strings:


string nome3 = "Fulano";
int idade3 = 30;

string frase3 = $"**{nome3} 3** tem **{idade3} 3** anos.";

Console.WriteLine(frase3); // Resultado: **Fulano** tem **30** anos.