```csharp
using System;

public class Pessoa
{
    private string _nome;
    private int _idade;

    public string Nome
    {
        get { return _nome; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                _nome = value;
            else
                throw new ArgumentException("O nome não pode ser nulo ou vazio.");
        }
    }

    public int Idade
    {
        get { return _idade; }
        set
        {
            if (value >= 0 && value <= 120)
                _idade = value;
            else
                throw new ArgumentOutOfRangeException("A idade deve estar entre 0 e 120 anos.");
        }
    }
}
