using Calculadora.Services;
namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;
    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }
    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act
        int resultado = _calc.Somar(num1,num2);

        //Assert
        Assert.Equal(15,resultado);
    }

    [Fact]
     public void DeveSubtrair10Com5ERetornar5()
    {
        //Arrange
        int num1 = 10;
        int num2 = 5;

        //Act
        int resultado = _calc.Subtrair(num1,num2);

        //Assert
        Assert.Equal(5,resultado);
    }

    [Fact]
     public void DeveMultiplicar10Com2ERetornar20()
    {
        //Arrange
        int num1 = 10;
        int num2 = 2;

        //Act
        int resultado = _calc.Multiplicar(num1,num2);

        //Assert
        Assert.Equal(20,resultado);
    }
    [Fact]
     public void DeveDividir10Com2ERetornar5()
    {
        //Arrange
        int num1 = 10;
        int num2 = 2;

        //Act
        int resultado = _calc.Dividir(num1,num2);

        //Assert
        Assert.Equal(5,resultado);
    }

     [Fact]
     public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        //Arrange
        int num = 4;

        //Act
        bool resultado = _calc.EhPar(num);

        //Assert
        Assert.True(resultado);
    }
    [Theory]
    [InlineData(new int []{2,4})]
    [InlineData(new int []{6,8,10})]
  
     public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
        //Act/Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }

}