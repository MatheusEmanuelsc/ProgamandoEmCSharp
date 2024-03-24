class Pessoa
{
    public string Nome { get; set; }
    // nessa propriedade e feita por de baixo dos panos  o metodo está privado e vc acessar ele pelo get e set assim não quebrando um dos paradigmas

    public int idade;
    // nessa não e feito isso por isso quebrar e não e recomendando utiliza-la


    public int num1 { get; set; }//permite leitura e escrita
    public int num2 { get; }//apenas leitura
    public int num3 {  set; }//apenas escrita
}
