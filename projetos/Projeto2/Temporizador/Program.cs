


Menu();


static void Menu(){

    Console.Clear();
    Console.WriteLine("S - Segundos");
    Console.WriteLine("M - Minuto");
    Console.WriteLine("Quanto tempo Deseja Contar?");
    Console.WriteLine("0 - Para sair");

    string data= Console.ReadLine().ToLower();

    char type = char.Parse(data.Substring(data.Length-1,1));
    int time = int.Parse(data.Substring(0,data.Length-1));

    int multplier = 1;
    if (type == 'm')
    {
        multplier =60;
    }
    if (time == 0)
    {
        Environment.Exit(0);
    }

    Start(time*multplier);
}
static void Start(int time){

    
    int cont = 0;
    while (cont != time)
    {   
        Console.Clear();
        cont++;
        Console.WriteLine(cont);
        Thread.Sleep(1000);
    }
    Console.Clear();
    Console.WriteLine("Temporizador Finalizado");
    Thread.Sleep(5000);
    Menu();
}