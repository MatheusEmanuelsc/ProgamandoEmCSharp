using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgamandoEmCSharp.basics.tipos
{
    public class TiposPrimitivos
    {
        
        byte meuByte =1;
        // valores de 0 ate 255
        sbyte meuSbyte=-1;
        // -128 ate 127


        //----------------------------------- Numeros Inteiros---------------------------------------------

        // se vc não for utilziar numero negativo vc usa o tipo com U na frente
        short meuShort= -1;//aceita positivos e ngativos
        ushort meuShort= 1;//aceita apenas positivos

        int meuInt=-1;//aceita positivos e negativos
        uint meuUint=1//aceita apenas positivos

        long meuLong=-1//aceita positivos e ngativos
        ulong meuUlong=1//aceita apenas positivos


        //------------------------------------ Numeros Reais-------------------------------------------


        float meuFloat = 10.5f;
        double meuDouble = 10.5;
        decimal meuDecimal = 20.5m;


        //-----------------------------------Tipos booliano--------------------------------------------
        // so aceita 2 valores true ou false

        bool meuBool = true;

        //-----------------------------------Tipo caracter---------------------------------------------

        char meuChar= 'a';//aceita qualquer caracter porem apenas 1 e deve está entre aspas simples

        string meuString ="caracteres";//aceita qualquer caracter e varios deles e sempre com aspasDuplas

        //----------------------------------Tipo Var---------------------------------------------------

        // subistitui o nome do tipo
        // sera do tipo do primeiro valor atribuido

        var idade = 25;
        var nome= "jao";


        //-----------------------------------Tipo Object---------------------------------------------
        //tipo generico que recebe qualquer valor ou objeto
        // caso não saiba o tipo da informação ou ela seja de varios tipos diferentes
        // não possui intelisense(ajuda dos editores) por ser um tipo desconhecido
        // evite usar

        object seilar =25;
        object podeSer="25";
        
    }
}