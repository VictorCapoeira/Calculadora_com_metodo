using Menu;

namespace Calculadora
{
    public class Contas()
    {
        public static float Soma()
        {
            float a = Escolha.Obter_valor();
            float b = Escolha.Obter_valor();
            Escolha.Exibir_valores(a,b,"+",a + b);
            return a + b;
        }
        public static float Subtracao()
        {
            float a = Escolha.Obter_valor();
            float b = Escolha.Obter_valor();
            Escolha.Exibir_valores(a,b,"-",a - b);
            return a - b;
        }
        public static float Multiplicacaoo()
        {
            float a = Escolha.Obter_valor();
            float b = Escolha.Obter_valor();
            Escolha.Exibir_valores(a,b,"*",a * b);
            return a * b;
        }
        public static float Divisao()
        {
            float a = Escolha.Obter_valor();
            float b = Escolha.Obter_valor();
            Escolha.Exibir_valores(a,b,"/",a / b);
            return a / b;
        }
        
    }

}