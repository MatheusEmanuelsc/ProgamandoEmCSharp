using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgamandoEmCSharp.basics.tipos.conversao
{
    public class CoversaoTipos
    {
        //------------------------------------------Conversão implicita------------------------------------------------

        // Conversão implicita são conversões  que podem ser executdas apenas com passagem de dados
        // possuem tipos compativeis


        float valor=25.8f;
        int outro =25;
        valor=outro;
        // resumindo sempre que for para um tipo maior acontece a conversão implicita, pois não a perda de informação

        //----------------------------------------Conversão Explicita--------------------------------------------------


        // ocorre quando os tipos não são compativeis
        // E dada pelo uso do tipo entre parênteses antes da atribuição
        // segue as mesma regras anteriores

        int inteiro = 100;
        uint inteiroSemSinal =(uint)inteiro;
    }
}