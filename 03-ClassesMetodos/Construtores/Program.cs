

class Pessoa
{
    public string? nome { get; set; }
    public int idade { get; set; }
    public string? sexo { get; set; }

    // construtor padrão
    public Pessoa()
    {
        
    }

    // construtor com parametros
    public Pessoa(string nome,int idade)
    {
        this.nome =nome;
        this.idade =nome;
        
    } 


    //classes  podem ter mais de um construtor  com parametros diferentes
    


    public Pessoa(string sexo):this(nome,idade)
    {
        this.sexo =sexo;
    }//construtor chamando outro construtor
}
