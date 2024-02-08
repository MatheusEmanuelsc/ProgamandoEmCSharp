
Menu();
static void Menu(){

    Console.Clear();
    Console.WriteLine("O que você deseja fazer? ");
    Console.WriteLine("1 - Abrir arquivo ");
    Console.WriteLine("2 - Criar novo arquivo ");
    Console.WriteLine("0 - Sair ");
    short Option = short.Parse(Console.ReadLine());

    switch (Option)
    {
        case 0:Environment.Exit(0); break;
        case 1:Abrir(); break;
        case 2:Editar(); break;
        default: Menu();break;
    }

}

static void Abrir(){
    Console.Clear();
    Console.WriteLine("Digite o caminho do arquivo: ");
    var path =Console.ReadLine();

    using (var file = new StreamReader(path))
    {   //ler um arquivo
        string text =file.ReadToEnd();
        Console.WriteLine(text);
    }

    Console.WriteLine("");
    Console.ReadLine();
    Menu();
}

static void Editar(){
    Console.Clear();

    Console.WriteLine("Digite seu Texto abaixo (ESC para sair) ");
    Console.WriteLine("---------------------------");
    string text="";
    do
    {   
        text+=Console.ReadLine();
        text+=Environment.NewLine;

    }while (Console.ReadKey().Key != ConsoleKey.Escape);
    Salvar(text);

}

static void Salvar(string text){
    Console.Clear();
    Console.WriteLine("Digite o caminho para salvar o arquivo: ");
    var path =Console.ReadLine();

    using (var file = new StreamWriter(path))
    {   //escrevendo um arquivo
        file.Write(text);
    }

    Console.WriteLine($"Salvo com sucesso: {path}");
    Console.ReadKey();
    Menu();
}


