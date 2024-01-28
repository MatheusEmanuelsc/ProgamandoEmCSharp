using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgamandoEmCSharp.basics.control_structure
{
    public class EstruturaCondicionalSwitch
    {
        // E Utilizado quando temos muitas decisões
        // executado em cascata
        // devemos parar a manualmente a execução o comando break
        // possui uma execução padrão chamada default


        int num = 3;

        switch (num)
        {
            case 1: Console.WriteLine("E 1");break;
            case 2: Console.WriteLine("E 2");break;
            case 3: Console.WriteLine("E 3");break;
            default:Console.WriteLine("E Invalido");
        }
    }
}