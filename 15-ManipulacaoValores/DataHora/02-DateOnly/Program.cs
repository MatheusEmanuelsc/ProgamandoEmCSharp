

using System;
using System.Globalization;

// Criando um objeto DateOnly
// Criando um DateOnly para a data atual
DateOnly hoje = DateOnly.FromDateTime(DateTime.Today);
Console.WriteLine($"Data atual: {hoje}");

// Criando um DateOnly para uma data específica
DateOnly dataEspecifica = new DateOnly(2024, 5, 10);
Console.WriteLine($"Data específica: {dataEspecifica}");

// Definindo a cultura para inglês (Estados Unidos)
CultureInfo culturaEn = new CultureInfo("en-US");
Console.WriteLine($"Data (Inglês dos EUA): {hoje.ToString(culturaEn)}");

// Definindo a cultura para português (Brasil)
CultureInfo culturaPt = new CultureInfo("pt-BR");
Console.WriteLine($"Data (Português do Brasil): {hoje.ToString(culturaPt)}");



// Manipulando objetos DateOnly
// csharp
DateOnly hoje = DateOnly.FromDateTime(DateTime.Today);

// Adicionando dias
DateOnly daquiADoisDias = hoje.AddDays(2);
Console.WriteLine($"Daqui a dois dias: {daquiADoisDias}");

// Subtraindo dias
DateOnly umaSemanaAtras = hoje.AddDays(-7);
Console.WriteLine($"Uma semana atrás: {umaSemanaAtras}");





//      Formatação de DateOnly
//       csharp
DateOnly hoje = DateOnly.FromDateTime(DateTime.Today);

// Formatação padrão
Console.WriteLine($"Padrão: {hoje}");

// Formatação personalizada
Console.WriteLine($"Formato longo: {hoje.ToString("D")}");
Console.WriteLine($"Formato curto: {hoje.ToString("d")}");
Console.WriteLine($"Dia da semana: {hoje.DayOfWeek}");

// Definindo a cultura para inglês (Estados Unidos)
CultureInfo culturaEn = new CultureInfo("en-US");
Console.WriteLine($"Data (Inglês dos EUA): {hoje.ToString("D", culturaEn)}");

// Definindo a cultura para português (Brasil)
CultureInfo culturaPt = new CultureInfo("pt-BR");
Console.WriteLine($"Data (Português do Brasil): {hoje.ToString("D", culturaPt)}");
