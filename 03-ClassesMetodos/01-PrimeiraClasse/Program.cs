



// Com a chegada do net 6 agora e possviel criar classes no program basicamente a execução em cima e as classes embaixo


// Criando o objeto
Pessoa p1 = new Pessoa();
p1.nome="jao";
p1.idade=26;
p1.sexo="masc";

Console.WriteLine(p1);



// Criando a classe
class Pessoa
{   
    // propriedades
    public string? nome { get; set; }
    public int idade { get; set; }
    public string? sexo { get; set; }
}