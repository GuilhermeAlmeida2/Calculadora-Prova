namespace CalculatorService.Tests;

public class DivisaoTest
{
    private readonly CalculadoraService calc = new CalculadoraService();


    [Fact]
    public void TestarDivisaoComNaN()
    {
        // Arrange
        double a = 2.0;
        double b = double.NaN;

        // Act
        double resultado = calc.Divisao(a, b);

        // Assert
        Assert.True(double.IsNaN(resultado));
    }
}

public class SomaTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void TestarSomaComMaiorNumero()
    {
        int a = int.MaxValue;
        int b = 1;

        Assert.Throws<OverflowException>(() => calc.Soma(a, b));
    }

    [Fact]
    public void SomaDoisPositivo()
    {
        int a = 5;
        int b = 2;

        var result = calc.Soma(a, b);
        Assert.Equal(7, result);
    }

    [Fact]
    public void SomarNegativoPositivo()
    {
        int a = 2;
        int b = -4;

        var result = calc.Soma(a, b);
        Assert.Equal(-2, result);
    }
    [Fact]
    public void SomaNumeroNegativo()
    {
        int a = -2;
        int b = -2;
        var result = calc.Soma(a, b);
        Assert.Equal(-4, result);
    }

}

public class SubtracaoTests
{
    private readonly CalculadoraService calc = new CalculadoraService();
    
    [Fact]
    public void SubtrairDoisPositivo()
    {
        int a = 5;
        int b = 2;

        var result = calc.Subtracao(a, b);
        Assert.Equal(3, result);
    }

    [Fact]
    public void SubtrairUmNegativo()
    {
        int a = 2;
        int b = -1;

        var result = calc.Subtracao(a, b);
        Assert.Equal(3, result);
    }

    [Fact]
    public void SubtrairNumeroNegativo()
    {
        int a = -5;
        int b = -3;

        var result = calc.Subtracao(a, b);
        Assert.Equal(-2, result);
    }


}

public class MultiplicacaoTests
{ 
private readonly CalculadoraService calc = new CalculadoraService();

[Fact]
public void MultiplicacaoDoisPositivo()
{
    int a = 5;
    int b = 2;

    var result = calc.Multiplicacao(a, b);
    Assert.Equal(10, result);
}

[Fact]
public void MultiplicacaoUmNegativo()
{
    int a = 2;
    int b = -1;

    var result = calc.Multiplicacao(a, b);
    Assert.Equal(-2, result);
}

[Fact]
public void MultiplicacaoNumeroNegativo()
{
    int a = -5;
    int b = -3;

    var result = calc.Multiplicacao(a, b);
    Assert.Equal(15, result);
}


}

public class DivisaoTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void DivisaoDoisPositivo()
    {
        int a = 4;
        int b = 2;

        var result = calc.Divisao(a, b);
        Assert.Equal(2, result);
    }

    [Fact]
    public void DivisaoUmNegativo()
    {
        int a = 4;
        int b = -2;

        var result = calc.Divisao(a, b);
        Assert.Equal(-2, result);
    }

    [Fact]
    public void DivisaoNumeroNegativo()
    {
        int a = -15;
        int b = -3;

        var result = calc.Divisao(a, b);
        Assert.Equal(5, result);
    }
    [Fact]
    public void DivisaoPorZero()
    {
        int a = 15;
        int b = 0;

        var result = calc.Divisao(a, b);
        Assert.Equal(5, result);
    }
}

public class MediaTeste
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void MediaDoisPositivo()
    {
        int a = 4;
        int b = 2;

        var result = calc.Media(a, b);
        Assert.Equal(3, result);
    }

    [Fact]
    public void MediaUmNegativo()
    {
        int a = 4;
        int b = -2;
        int c = 2;

        var result = calc.Media(a, b,c);
        Assert.Equal(1.33, result);
    }

    [Fact]
    public void MediaNumeroReais()
    {
        int a = 3;
        int b = 3;
        int c = 3;

        var result = calc.Media(a, b,c);
        Assert.Equal(3, result);
    }
}
