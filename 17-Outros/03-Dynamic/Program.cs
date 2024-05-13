// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Claro! Aqui está um exemplo de um bloco de código em C# que utiliza o tipo `dynamic`:

// ```csharp
// using System;

class Program
{
    static void Main(string[] args)
    {
        // Exemplo 1: Dynamic permite chamar métodos e acessar propriedades que não são conhecidos em tempo de compilação.
        dynamic dynamicObj = new ExpandoObject();
        dynamicObj.Name = "John"; // Adicionando uma propriedade dinamicamente
        dynamicObj.Age = 30;
        Console.WriteLine($"Name: {dynamicObj.Name}, Age: {dynamicObj.Age}");

        // Exemplo 2: Dynamic com métodos
        dynamic result = Calculate(10, 5, "Add");
        Console.WriteLine($"Result: {result}");

        result = Calculate(10, 5, "Subtract");
        Console.WriteLine($"Result: {result}");

        result = Calculate(10, 5, "Multiply");
        Console.WriteLine($"Result: {result}");

        // Exemplo 3: Iterando sobre uma lista dinâmica
        dynamic dynamicList = new List<dynamic> { "apple", "banana", "cherry" };
        foreach (var item in dynamicList)
        {
            Console.WriteLine(item.ToUpper());
        }
    }

    static dynamic Calculate(int x, int y, string operation)
    {
        switch (operation)
        {
            case "Add":
                return x + y;
            case "Subtract":
                return x - y;
            case "Multiply":
                return x * y;
            default:
                throw new ArgumentException("Invalid operation");
        }
    }
}
// ```

// Este código demonstra várias formas de usar o tipo `dynamic` em C#. No exemplo, `dynamic` é usado para criar um objeto dinâmico onde suas propriedades podem ser definidas em tempo de execução, e para realizar operações aritméticas com base em uma operação fornecida como uma string. Além disso, é mostrado como iterar sobre uma lista dinâmica.