// Operador Elvis (??) em C#:

// O operador Elvis (??) é usado para fornecer um valor padrão caso uma expressão seja nula.
// Ele retorna o operando esquerdo se não for nulo; caso contrário, retorna o operando direito.

// Sintaxe do operador Elvis:
// resultado = expressao ?? valorPadrao;

// 'resultado' receberá 'expressao' se 'expressao' não for nula, caso contrário, receberá 'valorPadrao'.

// Exemplo de uso do operador Elvis:
string texto = null;
string textoNaoNulo = texto ?? "Valor Padrão";

// Neste exemplo, se a variável 'texto' for nula, 'textoNaoNulo' receberá o valor "Valor Padrão".
// Caso contrário, 'textoNaoNulo' receberá o valor contido em 'texto'.

// O operador Elvis é especialmente útil em situações onde você deseja fornecer um valor padrão para uma variável que pode ser nula, evitando assim exceções NullReferenceException.

