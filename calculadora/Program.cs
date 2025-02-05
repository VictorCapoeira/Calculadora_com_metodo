using Menu;
using Calculadora;

float valor_a;
float valor_b;
string operacao;

Console.WriteLine("Calculadora");
Console.WriteLine("Selecione a operaçã: ");
operacao = Escolha.Imprimir();
Console.Clear();
Console.WriteLine("------------------------------------------------------------------------");
Console.WriteLine("a " + operacao + " b = a" + operacao + "b");
Console.WriteLine("Informe o primeiro valor");
valor_a = float.Parse(Console.ReadLine());
Console.WriteLine("------------------------------------------------------------------------");
Console.WriteLine(valor_a + " " + operacao + " b = " + valor_a + operacao + "b");
Console.WriteLine("Informe o segundo valor");
valor_b = float.Parse(Console.ReadLine());
Console.WriteLine(valor_a + " " + operacao + " " + valor_b + "  = " + valor_a + operacao + valor_b);
Console.WriteLine("------------------------------------------------------------------------");

if (operacao == "5")
{
    Console.WriteLine("Programa encerrado!");
}
else
{
    switch (operacao)
    {
        case "+":
            Console.WriteLine(valor_a + " " + operacao + " " + valor_b + "  = " + Contas.Soma(valor_a, valor_b));
            break;
        case "-":
            Console.WriteLine(valor_a + " " + operacao + " " + valor_b + "  = " + Contas.Subtracao(valor_a, valor_b));
            break;
        case "*":
            Console.WriteLine(valor_a + " " + operacao + " " + valor_b + "  = " + Contas.Multiplicacaoo(valor_a, valor_b));
            break;
        case "/":
            Console.WriteLine(valor_a + " " + operacao + " " + valor_b + "  = " + Contas.Divisao(valor_a, valor_b));
            break;
        default:
            Console.WriteLine("Error!");
            break;
    }
}

