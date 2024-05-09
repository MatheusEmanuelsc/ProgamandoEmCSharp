using System.Globalization;
// Para alterar Globalmente em uma cultura especifica
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

decimal valorMonetario = 82.40M;
Console.WriteLine($"Valor sem formatação: {valorMonetario}");

Console.WriteLine($"Valor Com formatação: {valorMonetario:C}");// :C  isso adc a formatação de acordo com as configurações do seu sistema

Console.WriteLine($"Valor sem formatação: {valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}"); //especificando no codigo para alguma cultura