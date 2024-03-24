// acessando valores
Console.WriteLine(Nota.Perfeito)



enum Dia
{
    Segunda,Terça,Quarta,Quinta,Sexta
}



/*
    Uma enumreção e definida usando a palavra chave enum

    diretamente dentro de um namespace,calsse ou struct, e todos os nomes das constantes podems er declarados e separados por uam virgula

    por padrão o valor e int e começa a conta  por 0

    vc tbm pode definir o tipo do enum botando

    Ex: enum NomeEnum: byte ou qualquer tipo numero que desaja

    vc tbm pode definir o valor com
*/


enum Nota
{
    Regular = 5,
    Bom = 6,
    Otimo = 8,
    Perfeito = 10

}