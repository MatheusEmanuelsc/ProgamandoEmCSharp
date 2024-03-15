
Seilar seilar = new Seilar();

seilar.digitaAlgo();
seilar.digitaAlgo("seilar tanto faz");


class Seilar
{
    
    // vc pode ter metodos com mesmo nome desde que os parametros seja diferente como no exemplo abaixo

    public void digitaAlgo(){
        Console.WriteLine("Algo");
    }

    public void digitaAlgo(string algo){
        Console.WriteLine(algo);
    }
}