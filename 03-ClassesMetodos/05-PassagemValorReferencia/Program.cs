
// Passagem de argumento por valor(Padrão)

/*
    Uma copia do valor do argumento é feita e passada para o parâmetro do método chamado
    as alterações na cópia não afetam o valor da variável original no chamador

*/

// Console.WriteLine("## Passando argumentos por valor ##\n");

// int x = 20;

// Console.WriteLine("\nValor do argumento x antes de passar por valor " + x);

// Calculo calc = new();
// calc.Dobrar(x);

// Console.WriteLine("\nValor do argumento x depois de passar por valor " + x);

// Console.ReadKey();  

// public class Calculo
// {
//     public void Dobrar(int y)
//     {
//         y *= 2; 
//         Console.WriteLine("\nValor do parâmetro y no método Dobrar " + y);
//     }
// }



// Passagem de argumento por referência(ref e out)

/*
    Passa a referencia ao mesmo local de memoria dos argumentos para os parametros nenhuma copia e passada]

    o chamador dá ao metodo a capacidade de acessar e modificar a variavel original do chamador(passa o acesso a variavel para o metodo)

    para fazer isso podemos utilizar as palavras chave ref e out


    pesquise a informação complementar dele

*/


Console.WriteLine("## Passando argumentos por referencia ##\n");

int x = 20;

Console.WriteLine("\nValor do argumento x antes de passar por valor " + x);

Calculo calc = new();

// Com a palavra ref agora ao inves de enviar o valor ele manda a referencia dele
calc.Dobrar(ref x);

Console.WriteLine("\nValor do argumento x depois de passar por valor " + x);

Console.ReadKey();  

public class Calculo
{
    // Aqui passa a receber a referencia
    public void Dobrar( ref int y)
    {
        y *= 2; 
        Console.WriteLine("\nValor do parâmetro y no método Dobrar " + y);
    }
}