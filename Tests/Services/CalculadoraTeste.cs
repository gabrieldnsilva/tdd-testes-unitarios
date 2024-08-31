using System.Globalization;
using tdd_testes_unitarios.Services;

namespace Tests.Services;

public class CalculadoraTeste
{

    [Theory]
    [InlineData (1, 2 , 3)]
    [InlineData (4, 5 , 9)]
    [InlineData (-5, 5 , 0)]
    public void TesteSomar(int num1, int num2, int resultado)
    {
        //Arrange
        Calculadora calc = new Calculadora();

        //Act
        int resultadoCalculadora = calc.Somar(num1, num2); 

        //Assert
        Assert.Equal(resultado, resultadoCalculadora);

    }
    [Theory]
    [InlineData (1, 2 , -1)]
    [InlineData (10, 5 , 5)]
    [InlineData (-5, 5 , -10)]
    public void TesteSubtrair(int num1, int num2, int resultado)
    {
        //Arrange
        Calculadora calc = new Calculadora();

        //Act
        int resultadoCalculadora = calc.Subtrair(num1, num2); 

        //Assert
        Assert.Equal(resultado, resultadoCalculadora);

    }
    [Theory]
    [InlineData (1, 2 , 2)]
    [InlineData (4, 5 , 20)]
    [InlineData (-5, 5 , -25)]
    public void TesteMultiplicar(int num1, int num2, int resultado)
    {
        //Arrange
        Calculadora calc = new Calculadora();

        //Act
        int resultadoCalculadora = calc.Multiplicar(num1, num2); 

        //Assert
        Assert.Equal(resultado, resultadoCalculadora);

    }
    [Theory]
    [InlineData (6, 2 , 3)]
    [InlineData (4, 2 , 2)]
    [InlineData (50, 5 , 10)]
    public void TesteDividir(int num1, int num2, int resultado)
    {
        //Arrange
        Calculadora calc = new Calculadora();

        //Act
        int resultadoCalculadora = calc.Dividir(num1, num2); 

        //Assert
        Assert.Equal(resultado, resultadoCalculadora);

    }

    [Fact]
    public void TesteDivisaoPorZero()
    {
        //Arrange
        Calculadora calc = new Calculadora();

        //Act 

        //Assert
        Assert.Throws<DivideByZeroException>(
            () => calc.Dividir(3 , 0));

    }

    [Fact]
    public void TestarHistorico()
    {
        // Given
        Calculadora calc = new Calculadora();   

        calc.Somar(1, 2);
        calc.Subtrair(8, 4);
        calc.Multiplicar(3, 3);
        calc.Dividir(10, 2);
    
        // When

        var lista =  calc.historico();
    
        // Then
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}