using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProgamandoEmCSharp.average.String
{
    public class Comparacao
    {
        var texto ="testando";
        Console.WriteLine(XText.CompareTo("Testando"));// retornar 1 pois não e igual
        Console.WriteLine(texto.CompareTo("testando"));//retornar 0  pois e igual

        Console.WriteLine(texto.Contains("testando"));//retonra um booleano ,ele verifica se a string contain no texto
        //conatis sempre pede uma string ou char
        
        // caso vc queria ingora o case sensitive  basta , StringComparison.OrdinalIgnoreCase


        
    }
}