using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgamandoEmCSharp.average.String
{
    public class StartEnd
    {
        var texto ="Este texto é um teste";

        Console.WriteLine(texto.StartsWith("Este"));//ele começa com a palavra este?
        Console.WriteLine(texto.EndsWith("teste"));//ele termina com teste?

        // Resumindo eles são case sensitive um verificar o inicio e outro final e retorna um booleano
    }
}