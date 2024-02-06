using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgamandoEmCSharp.average.Datas
{
    public class DataHora
    {
        //criando uma data
        var data = new  DateTime();
        Console.WriteLine(data);

        //criando pegando a data de hj
        var data2= DateTime.Now;
        Console.WriteLine(data2);

        //criando uma data
        var data3= new DateTime(2024,05,22);
        Console.WriteLine(data3);


        //Obtendo as informações de formar separada

        Console.WriteLine(data3.Year);
        Console.WriteLine(data3.Month);
        Console.WriteLine(data3.Day);
        //Tempo e a mesma coisa

        //Formatando datas
        var formatada=String.Format("{0:dd/MM/yyyy}",data2);
        Console.WriteLine(formatada);
        //hh mm ss ff z  outras opc tbm

        //formatação padrão ou predefinidos

        var formatoPadrao=String.Format("{0:d}",data2);
        Console.WriteLine(data2);
        //:t para exibir apenas o tempo
        //:T exibe o tempo longo e a data grande
        //:d vai exibir a menor data
        //:f vai combinar os 2
        //:g combina data e hora

        //Padrão mais utilizados são:
        /*
            :r
            :R
            :s
            :u
        */


        //Metodos Adicionais 

        var data4= new DateTime(2024,05,23);
        Console.WriteLine(data3);

        data4.AddDays(2);//para ad ou diminuir algo na data

        //Comparando datas
        //E possivel comparar utilizando o If
        //e os tipos de comparação

        if (data3.Date == DateTime.Now.Date){
            Console.WriteLine("Igual");
        }//tenha cuidado na hora de comparar pq ele compara a estrutura como um todo então e bom vc especificar na hora de comparar como no exemplo



    }
}