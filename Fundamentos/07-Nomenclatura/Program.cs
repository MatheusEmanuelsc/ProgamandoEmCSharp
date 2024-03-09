// Em C#, as convenções de identificadores são um conjunto de regras que determinam como os nomes de variáveis, métodos, classes e outros elementos devem ser nomeados para garantir consistência e legibilidade no código. Aqui estão algumas das convenções mais comuns:

// PascalCase: Nomes de classes e métodos devem começar com uma letra maiúscula e usar maiúsculas para cada palavra subsequente, sem underscores. Exemplo: MinhaClasse, MeuMetodo.

// camelCase: Nomes de parâmetros de métodos, variáveis locais e campos privados devem começar com uma letra minúscula e usar maiúsculas para cada palavra subsequente, sem underscores. Exemplo: minhaVariavel, meuMetodo.

// PascalCase para acrônimos e iniciais: Quando um identificador incluir um acrônimo ou inicial, cada letra do acrônimo deve ser maiúscula. Exemplo: XMLHttpRequest.

// ALL_CAPS: Nomes de constantes devem ser escritos em letras maiúsculas, com palavras separadas por underscores. Exemplo: MAX_VALUE.

// _underscorePrefix: Em algumas vezes, é utilizado um prefixo de sublinhado para variáveis privadas. Exemplo: _minhaVariavelPrivada.


using System;

namespace ConvencoesIdentificadores
{
    public class MinhaClasse
    {
        // Variável privada usando _underscorePrefix
        private int _minhaVariavelPrivada;

        // Método usando PascalCase
        public void MeuMetodo(int meuParametro)
        {
            // Atribuição de variável local usando camelCase
            _minhaVariavelPrivada = meuParametro;
            // Exibição de mensagem
            Console.WriteLine($"Valor da variável privada: {_minhaVariavelPrivada}");
        }

        // Constante usando ALL_CAPS
        public const int MAX_VALOR = 100;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instância da classe
            MinhaClasse minhaInstancia = new MinhaClasse();
            // Chamada de método
            minhaInstancia.MeuMetodo(50);
            // Exibição de valor constante
            Console.WriteLine($"Valor máximo: {MinhaClasse.MAX_VALOR}");
        }
    }
}
