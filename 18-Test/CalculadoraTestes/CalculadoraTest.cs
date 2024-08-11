using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTest
{
    private CalculadoraImp _calc;
    public CalculadoraTest()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomaRetornaNumeroSomado()
    {
        //Arrange

        int num1 = 2;
        int num2 = 3;

        //Act
        int resultado = _calc.Somar(num1,num2);


        //Assert

        Assert.Equal(5, resultado);
    }
}