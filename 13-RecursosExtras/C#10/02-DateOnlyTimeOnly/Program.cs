// **Resumo Completo sobre Date Only e Time Only em C# 10.0**

// **Propriedades:**

// **DateOnly:**
public int Year { get; } // Ano da data (por exemplo, 2023).
public int Month { get; } // Mês da data (por exemplo, 3 para março).
public int Day { get; } // Dia do mês (por exemplo, 8).
public DayOfWeek DayOfWeek { get; } // Dia da semana (por exemplo, DayOfWeek.Monday).
public int DayOfYear { get; } // Dia do ano (por exemplo, 67).
public long Ticks { get; } // Número de ticks desde 1 de janeiro de 0001.

// **TimeOnly:**
public int Hour { get; } // Hora do dia (por exemplo, 13).
public int Minute { get; } // Minuto da hora (por exemplo, 30).
public int Second { get; } // Segundo do minuto (por exemplo, 0).
public int Millisecond { get; } // Milissegundo do segundo (por exemplo, 500).
public long Ticks { get; } // Número de ticks desde a meia-noite.

// **Métodos:**

// **DateOnly:**
public DateOnly AddDays(int days) { ... } // Adiciona um número especificado de dias à data.
public DateOnly AddMonths(int months) { ... } // Adiciona um número especificado de meses à data.
public DateOnly AddYears(int years) { ... } // Adiciona um número especificado de anos à data.
public DateOnly SubtractDays(int days) { ... } // Subtrai um número especificado de dias da data.
public DateOnly SubtractMonths(int months) { ... } // Subtrai um número especificado de meses da data.
public DateOnly SubtractYears(int years) { ... } // Subtrai um número especificado de anos da data.
public string ToString() { ... } // Formata a data como uma string.
public string ToShortDateString() { ... } // Formata a data como uma string curta (por exemplo, "03/08/2023").
public string ToLongDateString() { ... } // Formata a data como uma string longa (por exemplo, "quinta-feira, 8 de março de 2023").

// **TimeOnly:**
public TimeOnly AddHours(int hours) { ... } // Adiciona um número especificado de horas à hora.
public TimeOnly AddMinutes(int minutes) { ... } // Adiciona um número especificado de minutos à hora.
public TimeOnly AddSeconds(int seconds) { ... } // Adiciona um número especificado de segundos à hora.
public TimeOnly SubtractHours(int hours) { ... } // Subtrai um número especificado de horas da hora.
public TimeOnly SubtractMinutes(int minutes) { ... } // Subtrai um número especificado de minutos da hora.
public TimeOnly SubtractSeconds(int seconds) { ... } // Subtrai um número especificado de segundos da hora.
public string ToString() { ... } // Formata a hora como uma string.
public string ToShortTimeString() { ... } // Formata a hora como uma string curta (por exemplo, "13:30").
public string ToLongTimeString() { ... } // Formata a hora como uma string longa (por exemplo, "13:30:00").

// **Comparação:**

// DateOnly e TimeOnly implementam a interface IComparable<T>, permitindo a comparação de datas e horas.
// Você pode comparar duas datas ou horas usando os operadores ==, !=, <, >, <= e >=.

// **Construtores:**

// **DateOnly:**
public DateOnly(int year, int month, int day) { ... } // Construtor que cria uma nova data com os valores especificados.
public DateOnly(DateTime dateTime) { ... } // Construtor que cria uma nova data a partir de um objeto DateTime.

// **TimeOnly:**
public TimeOnly(int hour, int minute, int second) { ... } // Construtor que cria uma nova hora com os valores especificados.
public TimeOnly(DateTime dateTime) { ... } // Construtor que cria uma nova hora a partir de um objeto DateTime.

// **Conversões:**

// Você pode converter um objeto DateOnly para um objeto DateTime usando o método ToDateTime().
// Você pode converter um objeto TimeOnly para um objeto DateTime usando o
