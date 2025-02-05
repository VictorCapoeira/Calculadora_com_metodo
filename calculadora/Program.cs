using Menu;
using Calculadora;

float valor_a;
float valor_b;
string operacao;

Console.WriteLine("Calculadora");
Console.WriteLine("Selecione a operaçã: ");
operacao = Menu.Escolha.Imprimir();

Console.WriteLine("Informe o primeiro valor");
valor_a = float.Parse(Console.ReadLine());
Console.WriteLine("Informe o segundo valor");
valor_b = float.Parse(Console.ReadLine());

switch (operacao)
{
    case "1":
        Calculadora.Contas.Soma(valor_a, valor_b);
        break;
    case "2":
        Calculadora.Contas.Soma(valor_a, valor_b);
        break;
    case "3":
        Calculadora.Contas.Soma(valor_a, valor_b);
        break;
    case "4":
        Calculadora.Contas.Soma(valor_a, valor_b);
        break;
    default:
        Console.WriteLine("Error!");
        break;
}