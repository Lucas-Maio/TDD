using Principal.Services;

namespace Testes;

public class UnitTest1
{
    public Calculadora ConstruirClasse()
    {
        DateTime data = DateTime.Now;
        Calculadora calc = new Calculadora(data);
        return calc;
    }


    [Theory]
    [InlineData(1,2,3)]
    public void TesteSomar(int num1, int num2 ,int resultado)
    {
        Calculadora calc = ConstruirClasse();

        int resultadoCalc = calc.Somar(num1,num2);

        Assert.Equal(resultado, resultadoCalc);
    }

    [Theory]
    [InlineData(1,2,2)]
    [InlineData(4,5,20)]
    public void TesteMultiplicar(int num1, int num2 ,int resultado)
    {
        Calculadora calc = ConstruirClasse();

        int resultadoCalc = calc.Multiplicar(num1,num2);

        Assert.Equal(resultado, resultadoCalc);
    }

    [Theory]
    [InlineData(4,3,1)]
    [InlineData(5,4,1)]
    public void TesteSubtrair(int num1, int num2 ,int resultado)
    {
        Calculadora calc = ConstruirClasse();

        int resultadoCalc = calc.Subtrair(num1,num2);

        Assert.Equal(resultado, resultadoCalc);
    }

    [Theory]
    [InlineData(10,5,2)]
    [InlineData(8,2,4)]
    public void TesteDividir(int num1, int num2 ,int resultado)
    {
        Calculadora calc = ConstruirClasse();

        int resultadoCalc = calc.Dividir(num1,num2);

        Assert.Equal(resultado, resultadoCalc);
    }

    [Fact]
    public void DivisãoPorZero()
    {
        Calculadora calc = ConstruirClasse();
        
        Assert.Throws<DivideByZeroException>(
            () => calc.Dividir(3,0));
    }

    [Fact]
    public void TestaHistorico()
    {
        Calculadora calc = ConstruirClasse();

        calc.Somar(1,2);
        calc.Somar(4,8);
        calc.Somar(10,5);
        calc.Somar(20,7);
        
        var list = calc.Historico();
        Assert.NotEmpty(list);
        Assert.Equal(3,list.Count());
    }
}