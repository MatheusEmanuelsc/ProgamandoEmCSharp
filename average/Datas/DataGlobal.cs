using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgamandoEmCSharp.average.Datas
{
    public class DataGlobal
    {
        
        using System.Globalization;

        var br = new CultureInfo("pt-BR");
        var en = new CultureInfo("en-UK");
        var pt = new CultureInfo("pt-PT");


        Console.WriteLine(string.Format("{0:d}",DateTime.Now));
        Console.WriteLine(DateTime.Now.ToString("d",en));//forma mais comum de utilizar
        //so por a cultura , depois do tipo de formatação


        var dateTime= DateTime.UtcNow;//horario global

        Console.WriteLine(dateTime);
        Console.WriteLine(dateTime.ToLocalTime());//converte a data  global para data da maquina

        var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
        Console.WriteLine(timezoneAustralia);// caso vc queria especifica o local

        var horaAustralia= TimeZoneInfo.ConvertTimeFromUtc(dateTime,timezoneAustralia);
        Console.WriteLine(horaAustralia);//Convertendo UTC para Alguma zona


        //unidade medida para data e hora universal
        //se não passa nada vem zerado
        var timeSpan = new TimeSpan();
        Console.WriteLine(timeSpan);

        //aqui vc passando o valor
        var timeSpanNanoSegundos= new TimeSpan(1);
        Console.WriteLine(timeSpanNanoSegundos);

        //criando uam hora
        var timeSpanHoraMinutoSegundo = new TimeSpan(5,12,8);
        Console.WriteLine(timeSpanHoraMinutoSegundo);
        //ele pode ter dia hora minuto segundo e fração de segundo




    }
}