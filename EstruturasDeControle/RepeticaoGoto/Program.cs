int cont =1 ;

// label
repete:
Console.WriteLine($"Fala Oi: {cont}");
cont++;

if (cont<=10)
{
    // aqui chama o label para fazer a repeticao
    goto repete;
    
}

// Essa modelo de repetição não recomenda ser utilizada  são melhores as outras