using System;
using System.Collections.Generic;

class UndoManager<T>
{
    private Stack<T> operacoes;

    public UndoManager()
    {
        operacoes = new Stack<T>();
    }

    public void FazerOperacao(T operacao)
    {
        operacoes.Push(operacao);
    }

    public T DesfazerOperacao()
    {
        if (operacoes.Count == 0)
        {
            throw new InvalidOperationException("Não há operações para desfazer.");
        }

        return operacoes.Pop();
    }

    public void LimparHistorico()
    {
        operacoes.Clear();
    }
}

class Program
{
    static void Main()
    {
        UndoManager<string> undoManager = new UndoManager<string>();

        // Fazendo algumas operações
        undoManager.FazerOperacao("Operação 1");
        undoManager.FazerOperacao("Operação 2");
        undoManager.FazerOperacao("Operação 3");

        // Desfazendo a última operação
        string ultimaOperacaoDesfeita = undoManager.DesfazerOperacao();
        Console.WriteLine($"Desfeita a operação: {ultimaOperacaoDesfeita}");

        // Adicionando mais operações
        undoManager.FazerOperacao("Operação 4");
        undoManager.FazerOperacao("Operação 5");

        // Desfazendo duas operações
        Console.WriteLine("Desfeitas duas operações:");
        for (int i = 0; i < 2; i++)
        {
            string operacaoDesfeita = undoManager.DesfazerOperacao();
            Console.WriteLine($"Desfeita a operação: {operacaoDesfeita}");
        }

        // Limpar histórico
        undoManager.LimparHistorico();
    }
}
