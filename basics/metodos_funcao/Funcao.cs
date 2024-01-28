using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgamandoEmCSharp.basics.metodos_funcao
{
    public class Funcao
    {
        // podemos segmentar nosso programa em funções
        // tambem conhecidos como metodos
        // o main e em exemplo de metodo
        // possui um retorno um nome e parametros
        // essa composicao e a camada de assinatura
        // comecam sempre com maiscula


        void FalaOi(){
            Console.WriteLine("oi");
        }

        // obs no C# não pode ter metodo dentro de metodo tipo no metodo main
        // pra funcionar vc tira ele e ponhe o static
    }
}