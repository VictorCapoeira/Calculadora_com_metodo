namespace Layout
{
    public class Cores{
        public static void Vermelho(string texto){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
    }
}