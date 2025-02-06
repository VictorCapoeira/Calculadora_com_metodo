using Layout;

namespace Menu{
    public class Escolha{
        public static string Imprimir(){
            string option = "";
            do{
                Cores.Amarelo("[Adição] -> +");
                Cores.Amarelo("[Subtração] -> -");
                Cores.Amarelo("[Multiplicação] -> *");
                Cores.Amarelo("[Divisão] -> /");
                Cores.Amarelo("[Sair] -> s");
                return option = Console.ReadLine();
            }while(option != "s");
        }
        public static float Obter_valor(){
            while(true){
                Cores.Amarelo("Informe o valor: ");
                if(float.TryParse(Console.ReadLine(), out float valor_x)){
                    
                    return valor_x;
                }
                else
                {
                    Cores.Vermelho("Valor inválido!");
                }
            }
        }
        public static void Exibir_valores(float valor_a, float valor_b, string valor_op, float resultado){
            Cores.Verde(valor_a + " " + valor_op + " " + valor_b + "  = " + resultado);
        }
    }
}