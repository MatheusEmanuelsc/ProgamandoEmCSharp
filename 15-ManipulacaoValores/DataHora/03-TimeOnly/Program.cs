

using System;
using System.Globalization;


// Criando um objeto TimeOnly
// csharp
// Criando um TimeOnly para a hora atual
TimeOnly agora = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine($"Hora atual: {agora}");

// Criando um TimeOnly para uma hora específica
TimeOnly horaEspecifica = new TimeOnly(15, 30, 0);
Console.WriteLine($"Hora específica: {horaEspecifica}");

// Definindo a cultura para inglês (Estados Unidos)
CultureInfo culturaEn = new CultureInfo("en-US");
Console.WriteLine($"Hora (Inglês dos EUA): {agora.ToString(culturaEn)}");

// Definindo a cultura para português (Brasil)
CultureInfo culturaPt = new CultureInfo("pt-BR");
Console.WriteLine($"Hora (Português do Brasil): {agora.ToString(culturaPt)}");

// Manipulando objetos TimeOnly
// csharp



TimeOnly agora = TimeOnly.FromDateTime(DateTime.Now);

// Adicionando horas
TimeOnly daquiUmaHora = agora.AddHours(1);
Console.WriteLine($"Daqui a uma hora: {daquiUmaHora}");

// Subtraindo minutos
TimeOnly cincoMinutosAtras = agora.AddMinutes(-5);
Console.WriteLine($"Cinco minutos atrás: {cincoMinutosAtras}");

// Formatação de TimeOnly
// csharp


TimeOnly agora = TimeOnly.FromDateTime(DateTime.Now);

// Formatação padrão
Console.WriteLine($"Padrão: {agora}");

// Formatação personalizada
Console.WriteLine($"Formato 24 horas: {agora.ToString("HH:mm:ss")}");
Console.WriteLine($"Formato 12 horas: {agora.ToString("hh:mm:ss tt")}");

// Definindo a cultura para inglês (Estados Unidos)
CultureInfo culturaEn = new CultureInfo("en-US");
Console.WriteLine($"Hora (Inglês dos EUA): {agora.ToString("HH:mm:ss", culturaEn)}");

// Definindo a cultura para português (Brasil)
CultureInfo culturaPt = new CultureInfo("pt-BR");
Console.WriteLine($"Hora (Português do Brasil): {agora.ToString("HH:mm:ss", culturaPt)}");
