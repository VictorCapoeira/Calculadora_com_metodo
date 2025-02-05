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
    valor_a = Escolha.Obter_valor();
    valor_b = Escolha.Obter_valor();
    switch(operacao){
        case "+":
        Escolha.Exibir_valores(valor_a,valor_b,operacao,Contas.Soma(valor_a,valor_b));
        break;
        case "-":
        Escolha.Exibir_valores(valor_a,valor_b,operacao,Contas.Subtracao(valor_a,valor_b));
        break;
        case "*":
        Escolha.Exibir_valores(valor_a,valor_b,operacao,Contas.Multiplicacaoo(valor_a,valor_b));
        break;
        case "/":
        Escolha.Exibir_valores(valor_a,valor_b,operacao,Contas.Divisao(valor_a,valor_b));
        break;
}
    }
    

