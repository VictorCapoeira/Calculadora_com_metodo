using Menu;
using Calculadora;

float valor_a;
float valor_b;
string operacao;

Console.WriteLine("Calculadora");
Console.WriteLine("Selecione a operaçã: ");
operacao = Escolha.Imprimir();
Console.Clear();


if (operacao == "5")
{
    Console.WriteLine("Programa encerrado!");
}
else
{
    switch(operacao){
        case "+":
            Contas.Soma();
        break;
        case "-":
            Contas.Subtracao();
        break;
        case "*":
            Contas.Multiplicacaoo();
        break;
        case "/":
            Contas.Divisao();
        break;
}
    }
    

