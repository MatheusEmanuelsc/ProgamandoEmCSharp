// Resumo sobre Delegates e Funções Anônimas em C#

/*
   Delegates:

   O que são Delegates?
   - Em C#, delegates são tipos de referência que encapsulam um método ou um conjunto de métodos.
   - Permitem armazenar a referência a um método como se fosse um objeto.
   - Podem ser usados para implementar callbacks, criar eventos e implementar programação assíncrona.

   Como usar Delegates?
   - Declarar o delegate.
   - Criar uma instância do delegate e especificar o método que deseja referenciar.
   - Passar o delegate como argumento para outro método.
   - Chamar o método através do delegate.

   Exemplo de uso de Delegates:
*/

// Callback
public delegate void MyDelegate(string message);

public void MyMethod(string message)
{
    Console.WriteLine(message);
}

static void Main(string[] args)
{
    MyDelegate myDelegate = new MyDelegate(MyMethod);

    // Passar o delegate como argumento
    MyOtherMethod(myDelegate);

    // Chamar o método através do delegate
    myDelegate("Hello, world!");
}

public void MyOtherMethod(MyDelegate myDelegate)
{
    myDelegate("This is a message from MyOtherMethod");
}

// Evento
public delegate void MyEventHandler(object sender, EventArgs e);

public class MyButton : Button
{
    public event MyEventHandler Click;

    public MyButton()
    {
        this.Click += new MyEventHandler(OnButtonClick);
    }

    private void OnButtonClick(object sender, EventArgs e)
    {
        Console.WriteLine("Button clicked!");
    }
}

static void Main(string[] args)
{
    MyButton button = new MyButton();

    // Inscrever-se no evento
    button.Click += (sender, e) => Console.WriteLine("Button clicked!");

    // Clicar no botão
    button.Click();
}

/*
   Multicast Delegates:

   Delegates em C# podem ser multicast, o que significa que eles podem referenciar vários métodos simultaneamente. 
   Quando um delegate multicast é invocado, todos os métodos referenciados por ele são chamados sequencialmente.

   Exemplo de uso de Multicast Delegates:
*/

public delegate void MyDelegate(string message);

public void Method1(string message)
{
    Console.WriteLine("Method1: " + message);
}

public void Method2(string message)
{
    Console.WriteLine("Method2: " + message);
}

static void Main(string[] args)
{
    MyDelegate myDelegate = null;

    myDelegate += Method1;  // Adiciona Method1 ao delegate
    myDelegate += Method2;  // Adiciona Method2 ao delegate

    myDelegate("Hello, world!");  // Invoca o delegate
}

/*
   Funções Anônimas:

   Funções anônimas, também conhecidas como expressões lambda, são blocos de código que podem ser declarados e executados inline.

   Exemplo de funções anônimas:
*/

// Delegate
MyDelegate myDelegate = (message) => Console.WriteLine(message);
myDelegate("Hello, world!");

// Filtragem de lista
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
List<int> evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
foreach (int num in evenNumbers)
{
    Console.WriteLine(num);
}
