Console.WriteLine("## Argumentos nomeados ##\n");

Email email = new();

email.Enviar("teste@email.com", "Reunião de Orçamento","Urgente" );

//argumentos nomeados
email.Enviar(titulo: "Urgente", destino: "teste@email.com", assunto: "Reunião Orçamento");
email.Enviar(destino: "teste@email.com", assunto: "Reunião Orçamento", titulo: "Urgente");
email.Enviar(assunto: "Reunião Orçamento", titulo: "Urgente", destino: "teste@email.com");

// basicamente no momento de passamos os dados utilizamos o nomes dos argumentos assim independe da ordem que for passada os dados serão lidos da forma correta

Console.ReadKey();

public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }
}