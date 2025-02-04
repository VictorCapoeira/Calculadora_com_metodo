namespace Menu{
    public class Escolha{
        public static string Imprimir(){
            string option = "";
            do{
                Console.WriteLine("[Adição] -> 1");
                Console.WriteLine("[Subtração] -> 2");
                Console.WriteLine("[Multiplicação] -> 3");
                Console.WriteLine("[Divisão] -> 4");
                Console.WriteLine("[Sair] -> 5");
                return option = Console.ReadLine();
            }while(option != "5");
        }
    }
}