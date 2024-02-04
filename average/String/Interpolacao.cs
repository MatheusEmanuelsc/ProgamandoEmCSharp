using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgamandoEmCSharp.average.String
{
    public class Interpolacao
    {
        var price = 10.2;
        
        var texto ="o valor e: "+ price;
        //primeira forma de concatenação
        Console.WriteLine(texto);

        var texto2= string.Format("O preço do produto é {0} apenas hj",price);
        //segunda forma e concatenação

        virtual texto3=$"O valor do produto e: {price}";
        //terceira forma e concatenação

        //Não vai pular linha o caracter especial ponha @ depois do $
    }
}