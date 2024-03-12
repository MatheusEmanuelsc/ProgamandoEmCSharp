/*
    Strunct DateTime
    Representa um momento no tempo expresso como uma data e hora

    uma variaveç do tipo DateTime e um tipo e possui valor Padrão

    o valor padrão e:  01/01/0001 00:00:00

    ao utilizar a data hora sera seguindo o padrão do seu sistema Operacional

*/


// Obtendo  data e hora atual
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

//Criando uma Data e hora especifica
DateTime dataCriada = new DateTime(2024,03,09);
// Como não especificamos a hora o valor sera o valores sera 0 por padrão
// A data devera seguir esse padrão quando for criada 
// (aaaa,mm,dd)
// para definir Data e hora
// (aaaa,mm,dd,hh,mm,dd,ss)
Console.WriteLine(dataCriada);


// Extraindo Infomações dia, mes,ano e etc

Console.WriteLine(dataAtual.Day);
Console.WriteLine(dataAtual.Month);
Console.WriteLine(dataAtual.Year);
Console.WriteLine(dataAtual.Hour);
Console.WriteLine(dataAtual.Second);
Console.WriteLine(dataAtual.Millisecond);

Console.WriteLine(dataAtual.DayOfWeek);
Console.WriteLine(dataAtual.DayOfYear);

// Adicioonar dias,mes,anos e etc

Console.WriteLine(dataCriada.AddDays(1));
Console.WriteLine(dataCriada.AddMonths(1));
Console.WriteLine(dataCriada.AddYears(1));
Console.WriteLine(dataCriada.AddHours(1));
Console.WriteLine(dataCriada.AddSeconds(1));
Console.WriteLine(dataCriada.AddMilliseconds(1));

// Para expressar a Data e hora no formato longo e Abreviado

Console.WriteLine(dataAtual.ToLongDateString());
Console.WriteLine(dataAtual.ToShortDateString());


Console.WriteLine(dataAtual.ToLongTimeString());
Console.WriteLine(dataAtual.ToShortTimeString());




