﻿Console.WriteLine("## Parâmetros opcionais ##\n");

Console.WriteLine("Informe o destino");
var destino = Console.ReadLine();

Console.WriteLine("Informe o titulo");
var titulo = Console.ReadLine();

Console.WriteLine("Informe o assunto");
var assunto = Console.ReadLine();

Email email = new();
email.Enviar();
email.Enviar(destino);
email.Enviar(destino, titulo);
email.Enviar(destino, titulo, assunto);

//não posso fazer
//email.Enviar(destino, , assunto);//causa um erro
email.Enviar(destino, assunto: assunto);

Console.ReadKey();

public class Email
{
	//parametros opicionais são definidos sempre no final como no exmeplo abaixo
	// para  fazelo opicionais basta adc um valor constante como no exemplo
    public void Enviar(string destino = "Destino padrão", string titulo = "Titulo Padrão", string assunto = "Assunto Padrão")
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }
}