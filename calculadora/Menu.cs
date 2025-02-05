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
                if(float.TryParse(Console.ReadLine(), out float valor_x)){
                    Console.WriteLine("Informe o valor: ");
                    return valor_x;
                }
                else
                {
                    Console.WriteLine("Valor inválido!");
                }
            }
        }
    }
}