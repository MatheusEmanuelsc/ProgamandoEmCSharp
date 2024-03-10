int? num=null;


Console.WriteLine(num);

// Ao adicionar em um tipo ? ele ganhar suporte para um valor nulo ou indefinido

// porem vc um tipo nullable type não consegue ser convertidode maneira implicita par um tipo primitivo
// para converter vc precisa

int num2= num ?? 0;
// assim vc consegue converte ou seja se for nulo ele atribui 0

// para fazer operações com nullabol types vc pode transformar todos em nullabol types  adc ? em cada 1

// Os tipos nullabos tem acesso a 2 propriedades

//HasValue : true se tiver um valor, 
    // false se não tiver um valor(null)

// value exibe o valor atribuido

// Caso vc precise utilizar um metodo anulavel em um metodo que pode ou não causar um erro adcione ? na variavel
// Ex: nome?.ToUpper()