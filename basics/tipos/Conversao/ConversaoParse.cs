using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgamandoEmCSharp.basics.tipos.Conversao
{
    public class ConversaoParse
    {
        // metodo presente em todo tipo primitivo
        // usado para converter um caractere ou string para um tipo qualquer
        // caso haja alguma incompatibilidade,gera um erro

        // o parse sempre espera uma string  (cadea de caracteres) para convertelo em um numero
        int inteiro = int.parse("100");
    }
}