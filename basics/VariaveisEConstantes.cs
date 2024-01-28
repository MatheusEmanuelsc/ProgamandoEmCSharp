using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgamandoEmCSharp.basics
{
    public class VariaveisEConstantes
    {
        /*
            boas praticas

            Utilize nomes coesos
            Não utilize caracteres especiais ou espaços
            Não comece com números
            A primeira letra de cada palavra e SEMPRE minúscula
            Se tiver mais de uma plavra a variavel siga o padrão camelCase
        
        */

        // --------------------------------------Variaveis--------------------------------------------------
        // Para criar uma variavel no C#

        // vc ponhe o Tipo antes depois o nome e pode ou não usar ela no mesmo momento

        int numero;
        int numero2= 1;


        // tbm e possivel utilizar a palavra reservada Var para criar uma variavel
        // porem vc e obrigado a inicializar 

        var numero3=2;



        // -------------------------------------Constantes--------------------------------------------------
        
        /*
            Também utilizamos uma constante para armazenar uma informação
            As constantes não podem ser alteradas
            Não funcionar com a utilização do var
            São mais otimizadas que as variaveis
            Recomendadas para usos frequentes

        */

        const  int PI;

        /*
            Modo de utilização

            Constantes devem ser maiusculas caso tenha mais de uma palavra utilizar _ para separa a palavra
            Ex: NOME_CONSTANTE
            Vc pode ou não inicializala na mesma hora
        
        */
    }
}