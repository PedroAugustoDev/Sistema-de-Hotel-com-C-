
using Hotel;


namespace HotelApp
{
    public class Program
    {
        private static int NUMERO_PADRAO_QUARTOS = 10;
        public static void Main(string[] args)
        {
            Quarto[] quartos = new Quarto[NUMERO_PADRAO_QUARTOS];

            Console.Write("Digite a quantidade de proprietários a ser registrada: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)  AlugarQuarto(quartos);
            RelatorioDosQuartos(quartos);

        }

        private static void AlugarQuarto(Quarto[] quartos)
        {
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.Write($"{nome}, digite o seu email: ");
            string email = Console.ReadLine();
            Console.Write($"{nome}, digite o quarto desejado: ");
            int quartoId = int.Parse(Console.ReadLine()) - 1;
            quartos[quartoId] = new Quarto(quartoId, nome, email);
            Console.Clear();
        }

        private static void RelatorioDosQuartos(Quarto[] quartos)
        {
            for (int i = 0; i < 10; i++) 
            {
                if (quartos[i] != null) Console.WriteLine(quartos[i]);
            }
        }
    }
}
