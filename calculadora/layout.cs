namespace Layout
{
    public class Cores{
        public static void Vermelho(string texto){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
        public static void Verde(string texto){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
        public static void Amarelo(string texto){
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
    }
}