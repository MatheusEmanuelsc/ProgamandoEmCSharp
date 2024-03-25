// A classe Random é fornecida no namespace System e é usada para gerar números aleatórios em C#.

// Sintaxe para criação de uma instância de Random:
Random random = new Random();

// Principais métodos da classe Random:

// 1. Next():
//    Retorna um número inteiro não negativo aleatório.
int numeroAleatorio = random.Next();

// 2. Next(int maxValue):
//    Retorna um número inteiro aleatório no intervalo de 0 (inclusive) a maxValue (exclusive).
int numeroAleatorioLimite = random.Next(100); // Retorna um número entre 0 e 99.

// 3. Next(int minValue, int maxValue):
//    Retorna um número inteiro aleatório no intervalo de minValue (inclusive) a maxValue (exclusive).
int numeroAleatorioIntervalo = random.Next(50, 100); // Retorna um número entre 50 e 99.

// 4. NextDouble():
//    Retorna um número decimal aleatório entre 0,0 (inclusive) e 1,0 (exclusive).
double numeroAleatorioDecimal = random.NextDouble();

// 5. NextBytes(byte[] buffer):
//    Preenche o array de bytes especificado com valores aleatórios.
byte[] bytesAleatorios = new byte[10];
random.NextBytes(bytesAleatorios);

// 6. NextBytes(Span<byte> buffer):
//    Preenche o intervalo de bytes especificado com valores aleatórios.
Span<byte> bytesAleatoriosSpan = new byte[10];
random.NextBytes(bytesAleatoriosSpan);

// 7. NextBytes(Span<byte> buffer):
//    Preenche o intervalo de bytes especificado com valores aleatórios.
byte[] byteArray = new byte[10];
random.NextBytes(byteArray);

// 8. Next(int minValue, int maxValue):
//    Retorna um número inteiro aleatório no intervalo de minValue (inclusive) a maxValue (exclusive).
int numeroAleatorioIntervalo = random.Next(50, 100); // Retorna um número entre 50 e 99.

// 9. Next(int minValue, int maxValue):
//    Retorna um número inteiro aleatório no intervalo de minValue (inclusive) a maxValue (exclusive).
int numeroAleatorioIntervalo = random.Next(50, 100); // Retorna um número entre 50 e 99.

// A classe Random oferece uma variedade de métodos para gerar números aleatórios de diferentes tipos e em diferentes intervalos.
// Eles podem ser úteis em uma ampla gama de cenários, como jogos, simulações, criptografia e muito mais.
