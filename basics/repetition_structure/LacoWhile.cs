using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgamandoEmCSharp.basics.repetition_structure
{
    public class LacoWhile
    {
        // definido pela palavra while
        // exige apenas uma condição
        // checa a condição antes de executar

        int cont = 0;

        while (cont<5)
        {
            Console.WriteLine("Repertiu");
            cont++;
        }
    }
}