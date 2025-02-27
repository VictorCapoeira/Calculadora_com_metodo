using Menu;
using Calculadora;
using Layout;

float valor_a;
float valor_b;
string operacao = "";

Cores.Amarelo("Calculadora");
while (operacao != "s")
{
    Cores.Amarelo("Selecione a operaçã: ");
    operacao = Escolha.Imprimir();
    Console.Clear();


    if (operacao == "5")
    {
        Cores.Amarelo("Programa encerrado!");
    }
    else
    {
        switch (operacao)
        {
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
}
