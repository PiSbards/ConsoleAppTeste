using static System.Console;
namespace ConsoleAppTeste
{
    public class Program
    {
        public static void Main()
        {
            int n1, n2;
            WriteLine("=== Soma de 2 valores ===");
            WriteLine("Digite o 1° valor");
            n1 = Convert.ToInt32(ReadLine());
            WriteLine("Digite o 2° valor");
            n2 = Convert.ToInt32(ReadLine());
            WriteLine("=== O resultado é: ===");
            WriteLine(Soma(n1, n2));
        }
        public static int Soma (int n1, int n2)
        {
            if (n1<0 || n2<0)
            {
                return -1;
            }
            return n1 + n2;
        }
    }
}