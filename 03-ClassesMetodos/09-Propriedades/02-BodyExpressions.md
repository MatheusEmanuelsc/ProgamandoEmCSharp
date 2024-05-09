using System;

public class Pessoa
{
    private string _nome;
    private int _idade;

    public string Nome
    {
        get => _nome;
        set => _nome = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("O nome não pode ser nulo ou vazio.");
    }

    public int Idade
    {
        get => _idade;
        set => _idade = (value >= 0 && value <= 120) ? value : throw new ArgumentOutOfRangeException("A idade deve estar entre 0 e 120 anos.");
    }
}
