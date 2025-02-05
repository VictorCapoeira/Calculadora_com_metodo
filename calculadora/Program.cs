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
