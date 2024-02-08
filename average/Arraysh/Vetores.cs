using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgamandoEmCSharp.average.Arraysh
{
    public class Vetores
    {
        
        //Vetores



        //Inicializando um array

        int[] meuArray = new int[10];
        //tem tamanho definido 
        //sempre deve informa o tipo

        //Outra forma de inicialização
        var meuArray2 = new int[10];


        //Buscando dados no array


        Console.WriteLine(meuArray[0]);
        //para buscar o valor necessario informa a posição dele por isso vc precisa do indice dele
        //Sempre as posições iniciam apatir do 0


        //Pondo dados

        var meuArray3 = new int[5]{1,2,3,4,5};//forma 1 de passar todos os dados

        meuArray[0]=1;//formar 2  passnado o dado por posições


        //Pecorrendo um array

        var clone = meuArray3.Clone;//serve para copiar os valores
        // var copiarValores = meuArray3.CopyTo() serve para copiar algum valor do array
        var tamanho=meuArray3.Length;//retorna o tamnho do array
        //existe outro metodos pesquise

        for (int i = 0; i < meuArray3.Length; i++)
        {
            Console.WriteLine(meuArray3[i]);
        }

        //outro metodo para pecorrer
        foreach (var item in meuArray3)
        {
            Console.WriteLine(item);
        }

            }
}