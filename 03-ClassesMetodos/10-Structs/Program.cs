
/*
    Uma struct e um tipo de dado definido pelo usuario que e composta por outros tipos de dados e funcionalidades relacionadas (semelhantes a uma classe)


    Uma struct pode conter campos,metodos,constantes ,construtores , propriedades,indexadores, operadores e mesmo outro tipos de estruturas

    A principal diferença entre casse e structs e que structs são tipos de valor e não de referencia(membros e instancias de uma structs são criadas na memoria stack e contém seus dados)

    Ou seja seria uma alternativa mais leve as classes
*/

// implementando


Pessoa p1 = new Pessoa("jao",26);

Console.WriteLine(p1);



// definido um struct
struct Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}