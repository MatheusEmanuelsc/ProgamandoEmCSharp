
var arr = new int[3];

//try tenta executar um codigo
try
{
    Console.Clear();
    for (int i = 0; i < 2; i++)
{
    Console.WriteLine(arr[i]);
}
VerificarIdade(17);
}
catch (IndexOutOfRangeException ex)
{//cath pega se de um erro
//sempre ponhas os tipos de erros mais especificos primeiro 
    Console.WriteLine(ex.Message);//informa uma mensagem 
    Console.WriteLine(ex.InnerException);//informa oque aconteceu
    
}catch(Exception ex)
{//E possivel ter varios catch
 //tipo mais generico
    Console.WriteLine(ex.Message);
}finally{
    //Sempre que precisa que algo sempre sera executando utilize o finnaly
    Console.WriteLine("Programa finalizado");
}


static void VerificarIdade(int idade){
    if (idade<18)
    {//lançando um exption
        throw new Exception("idade invalida");
    }else
    {
        Console.WriteLine("Aprovado");
    }
}

//Criando Sua propria Exception

//herdar de Exception
public class MinhaException : Exception{

    //Pode criar metodos
    public DateTime QuandoOcorreu { get; set; }
    
}