// See https://aka.ms/new-console-template for more information
using Principal.Services;

Calculadora op = new Calculadora();
Console.WriteLine(op.Multiplicar(2,2));
Console.WriteLine(op.Multiplicar(2,2));
Console.WriteLine(op.Multiplicar(2,2));
Console.WriteLine(op.Multiplicar(2,2));
Console.WriteLine(op.Historico());
foreach (var item in op.HistoricoComIndice())
{
    Console.WriteLine(item);
}
