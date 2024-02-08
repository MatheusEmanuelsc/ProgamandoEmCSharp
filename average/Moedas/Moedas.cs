using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgamandoEmCSharp.average.Moedas
{
    public class Moedas
    {
        //Quando vc precisa de muita precisão e recomendo para quando vc trabalhar com moeda use SEMPRE O decimal
        using System.Globalization;

        decimal moedas=1500.00m;
        Console.WriteLine(moedas);
        //Formatando

        Console.WriteLine(moedas.ToString("C",CultureInfo.CreateSpecificCulture("us-UK")));
        //ele ponhe ate a moeda   C(current moeda) G(Generico) F(Precisão maior) P(Porcetagem) N(Numero mais sem a formatação)
        //Existem outros formatadores pesquise
    }
}