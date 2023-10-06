﻿
using Hotel;


namespace HotelApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // há dez quartos no hotel
            Quarto[] quartos = new Quarto[10];

            //Lendo a quantidade de novos proprietáritos
            Console.Write("Digite a quantidade de proprietários a ser registrada: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++) {
                Console.Write("Digite o seu nome: ");
                string nome = Console.ReadLine();
                Console.Write($"{nome}, digite o seu email ");
                string email = Console.ReadLine();  
                Console.Write($"{nome}, digite o quarto desejado: ");
                int quartoId = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine($"Parabéns {nome}, você está no quarto {quartoId + 1}");
                quartos[quartoId] = new Quarto(quartoId, nome, email);
            }


            //relatório de quarto utilizados
            for (int i = 0; i < 10; i++) { if (quartos[i] != null) Console.WriteLine(quartos[i]); }
        }
    }
}