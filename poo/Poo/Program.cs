// See https://aka.ms/new-console-template for more information
using Poo.Classes;

Console.WriteLine("Hello, World!");



using (PagamentoCartaoCredito pag = new(DateTime.Now))
{
    //aqui vc botaria todas operações com o metodo
}



//Comparando objetos

Pessoa pessoa1 = new("seilar",3);
Pessoa pessoa2 = new("seilar",3);

Console.WriteLine($"E igual? {pessoa1.Equals(pessoa2)}");//fazendo a comparação

//Criando Lista
IEnumerable<Pessoa> pessoas = new List<Pessoa>();


public class Pessoa : IEquatable<Pessoa>{//Para comparar onjetos e necessario que implemente interface
    public string Nome { get; set; }
    public int Numero { get; set; }

    public  Pessoa(string nome,int numero)
    {
        Nome =nome;
        Numero =numero;
    }

    public bool Equals(Pessoa other)//Interface implementada
    {
        return  (Nome == other.Nome) && (Numero== other.Numero);//comparação desejada
    }
}




