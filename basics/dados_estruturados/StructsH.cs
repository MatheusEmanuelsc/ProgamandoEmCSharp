using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgamandoEmCSharp.basics.dados_estruturados
{
    public class StructsH
    {
        /*Tipos de dado estruturado

        Apenas a estrutura, o esqueleto tipo de valor
        Armazenam apenas outros tipos de dados
        Definido pela palavra struct
        Composto de propriedades e metodos
        Nome sempre com maisculo 
            o mesmo para propriedades e metodos
        Criado a partir da palavra new
            Neste momento sim temos os valores
        

        Eles Competem com uma classe são do tipo value type ele não deve nem estar dentro de uma classe ou do metodo main para utilizar ele  tire de dentro da classe
        */


        
    }
    struct Produto
        {
            // propriedades
            public int Id;
            public float Price;

            // metodos

            // tbm existe o metodo construtor segue aquele padrão lá
            public float PriceInDolar(float dolar){
                return Price*dolar;
            }
        }

        // var Produto = new Produto();  // Ex: de criação
}