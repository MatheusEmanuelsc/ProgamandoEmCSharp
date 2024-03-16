
Pessoa p1 = new Pessoa();


p1.falaOi();
p1.faleAlgo("Algo");

int result =p1.soma(2,2);
Console.WriteLine(result);

class Pessoa
{
    public string? nome { get; set; }
    public int idade { get; set; }
    public string? sexo { get; set; }


    // Criando metodos

    public void falaOi(){
        Console.WriteLine("OI");
    }//void para quando não retornar nenhum valor

    public void faleAlgo(string falou){
        Console.WriteLine(falou);
    }//Metodo recebendo parametros para adc mais de um dado recebido , e ponhe os valores dnv

    public int soma(int num,int num2){
        return num+num2;

    }//quando vc ponhe  o tipo ele vai esperar um retorno do mesmo tipo
    // return retorna o valor



}
