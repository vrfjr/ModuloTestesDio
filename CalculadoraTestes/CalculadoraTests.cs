using System.Security.Cryptography;
using Calculadora.Services;


namespace CalculadoraTestes;

public class CalculadoraTests
{
        private CalculadoraImp _calc;
        public CalculadoraTests()
        {
             _calc = new CalculadoraImp();
        }


    [Fact]
    public void DebeSomar5Com15ERetornar20()
    {
        // Arrange
        int num1 = 5;
        int num2 = 15;

        // Act
        
        int resultado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(20, resultado);


    }

 [Fact]
    public void DebeSomar10Com15ERetornar25()
    {
        // Arrange
        int num1 = 10;
        int num2 = 15;

        // Act
        int resultado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(25, resultado);
 
    }


    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        // Arrange
        int nummero = 4;
        // Act
        bool resultado = _calc.EhPar(nummero);
        // Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    [InlineData(12)]
    [InlineData(14)]
    [InlineData(16)]

    public void DeveVerificarSeOsNumerosSaoParesERetornarComoVerdadeiro(int numero)
    {
        // Given
    
        // When
        bool resultado = _calc.EhPar(numero);
        // Then
        Assert.True(resultado);
    }



    [Theory]
    [InlineData(new int[] { 0, 2, 4, 6, 8})]
 
    public void DeveVerificarSeVariosNumerosemListaSeSaoParesERetornarComoVerdadeiro(int[] numeros)
    {
       
       // act / assert
       Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));

    }
}