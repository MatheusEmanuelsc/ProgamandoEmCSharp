using System;
using System.Globalization;

// Criando um objeto DateTime
// Criando um DateTime para a data e hora atual
DateTime agora = DateTime.Now;
Console.WriteLine($"Data e hora atual: {agora}");

// Criando um DateTime para uma data específica
DateTime dataEspecifica = new DateTime(2024, 5, 10, 15, 30, 0);
Console.WriteLine($"Data específica: {dataEspecifica}");

// Criando um DateTime apenas com a data
DateTime apenasData = DateTime.Today;
Console.WriteLine($"Apenas data: {apenasData}");

// Criando um DateTime apenas com a hora
DateTime apenasHora = DateTime.Now.TimeOfDay;
Console.WriteLine($"Apenas hora: {apenasHora}");

// Definindo a cultura para inglês (Estados Unidos)
CultureInfo culturaEn = new CultureInfo("en-US");
Console.WriteLine($"Data e hora (Inglês dos EUA): {agora.ToString(culturaEn)}");

// Definindo a cultura para português (Brasil)
CultureInfo culturaPt = new CultureInfo("pt-BR");
Console.WriteLine($"Data e hora (Português do Brasil): {agora.ToString(culturaPt)}");



//         Manipulando objetos DateTime
// csharp
DateTime agora = DateTime.Now;

// Adicionando dias
DateTime daquiADoisDias = agora.AddDays(2);
Console.WriteLine($"Daqui a dois dias: {daquiADoisDias}");

// Subtraindo horas
DateTime umaHoraAtras = agora.AddHours(-1);
Console.WriteLine($"Uma hora atrás: {umaHoraAtras}");

// Obtendo partes específicas
int dia = agora.Day;
int mes = agora.Month;
int ano = agora.Year;
Console.WriteLine($"Dia: {dia}, Mês: {mes}, Ano: {ano}");



// Formatação de DateTime
// csharp
DateTime agora = DateTime.Now;

// Formatação padrão
Console.WriteLine($"Padrão: {agora}");

// Formatação personalizada
Console.WriteLine($"Formato longo: {agora.ToLongDateString()}");
Console.WriteLine($"Formato curto: {agora.ToShortDateString()}");
Console.WriteLine($"Hora longa: {agora.ToLongTimeString()}");
Console.WriteLine($"Hora curta: {agora.ToShortTimeString()}");

// Definindo a cultura para português (Brasil)
CultureInfo culturaPt = new CultureInfo("pt-BR");
Console.WriteLine($"Data e hora (Português do Brasil): {agora.ToString(culturaPt)}");
