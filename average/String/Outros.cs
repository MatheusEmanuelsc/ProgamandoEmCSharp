using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgamandoEmCSharp.average.String
{
    public class Outros
    {
        Console.WriteLine(texto.Insert(5," Aqui "));//Inserir dados em um texto
        Console.WriteLine(texto.Remove(5,5));//vc da o inidice de inicio e o final pois tudo aquilo sera removido
        Console.WriteLine(texto.Length);// retorna a quantidade de caracteres
        Console.WriteLine(texto.Replace("e","E"));//troca algo na string

        var div = texto.split(" ");//ele divide um texto de acordo com parametro que vc passou e retorna uma lista de caracteres
        Console.WriteLine(div);

        var resultado = texto.Substring(5,5);// ele pegar um dado da string e parecido o primeiro parametro e o inicio e o segundo o final
        Console.WriteLine(resultado);

        var seilar = texto.Trim();//retirar os espaço do começo e final
        Console.WriteLine(seilar);

    }
}