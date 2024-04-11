Console.WriteLine("---------------");
Console.WriteLine("Questão 1: ");

Console.WriteLine("Digite o primeiro numero:");
var num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero:");
var num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro numero:");
var num3 = int.Parse(Console.ReadLine());

var maior = 0;
var numMaior = "";
if (num1 >= num2)
{
    maior = num1;
    numMaior = "primeiro numero";
}else{
    maior = num2;
    numMaior = "segundo numero";
}

if (num3 > maior){
    maior = num3;
    numMaior = "terceiro numero";
}

Console.WriteLine($"O {numMaior}: {maior} é o maior  ");
Console.WriteLine("---------------");