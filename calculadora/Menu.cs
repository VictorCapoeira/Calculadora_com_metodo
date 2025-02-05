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
    }
}