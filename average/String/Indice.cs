using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgamandoEmCSharp.average.String
{
    public class Indice
    {
        // Indice segue aquele padrão do array

        var texto ="Este texto é um teste";

        Console.WriteLine(texto.IndexOf("é"));//ele sempre vai pedir um dado do mesmo tipo  e retorna a posição do caracter
        // sempre retorna a primeira posição que encontrar

        Console.WriteLine(texto.LastIndexOf("e"));//ele vai buscar a ultima letra que encontrou e devolver o indice
    }
}