Console.WriteLine("Calculadora");
Menu();


static void Menu(){
    Console.Clear();
    Console.WriteLine("-------------------------Calculadora----------------------------");

    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Encerrando");

    int opcaoEscolhida = int.Parse(Console.ReadLine());


    switch (opcaoEscolhida)
    {
        case 1: {
            Console.WriteLine("------------------Soma----------------------");
            Soma();
            break;
        } 
        case 2: {
            Console.WriteLine("------------------Subtração----------------------");
            Sub();
            break;
        }case 3: {
            Console.WriteLine("------------------Multiplicação----------------------");
            Mult();
            break;
        }case 4: {
            Console.WriteLine("------------------Divisão----------------------");
            Div();
            break;
        }case 5: {
            Console.WriteLine("------------------Encerrando----------------------");
            Environment.Exit(0);break;
            break;
        } 
        default:Console.WriteLine("Valor inserido invalido........."); Console.ReadKey();Menu(); break;
    }

    
}
static void Soma(){

    Console.WriteLine("Primeiro valor: ");
    float valor1 = float.Parse( Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float valor2 = float.Parse( Console.ReadLine());

    float result = valor1+valor2;

    Console.WriteLine("O resultado e: "+result);

}

static void Sub(){
    

    Console.WriteLine("Primeiro valor: ");
    float valor1 = float.Parse( Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float valor2 = float.Parse( Console.ReadLine());

    float result = valor1-valor2;

    Console.WriteLine("O resultado e: "+result);

}

static void Div(){
    

    Console.WriteLine("Primeiro valor: ");
    float valor1 = float.Parse( Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float valor2 = float.Parse( Console.ReadLine());

    float result = valor1/valor2;

    Console.WriteLine("O resultado e: "+result);

}

static void Mult(){
    

    Console.WriteLine("Primeiro valor: ");
    float valor1 = float.Parse( Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float valor2 = float.Parse( Console.ReadLine());

    float result = valor1*valor2;

    Console.WriteLine("O resultado e: "+result);

}