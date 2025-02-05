namespace Menu{
    public class Escolha{
        public static string Imprimir(){
            string option = "";
            do{
                Console.WriteLine("[Adição] -> +");
                Console.WriteLine("[Subtração] -> -");
                Console.WriteLine("[Multiplicação] -> *");
                Console.WriteLine("[Divisão] -> /");
                Console.WriteLine("[Sair] -> s");
                return option = Console.ReadLine();
            }while(option != "s");
        }
        public static float Obter_valor(){
            while(true){
                Console.WriteLine("Informe o valor: ");
                if(float.TryParse(Console.ReadLine(), out float valor_x)){
                    
                    return valor_x;
                }
                else
                {
                    Console.WriteLine("Valor inválido!");
                }
            }
        }
        public static void Exibir_valores(float valor_a, float valor_b, string valor_op, float resultado){
            Console.WriteLine(valor_a + " " + valor_op + " " + valor_b + "  = " + resultado);
        }
    }
}