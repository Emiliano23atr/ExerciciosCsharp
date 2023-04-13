using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio012
    {
        public static void Executar()
        {
            Console.Write("Qual é o preço do produto? R$");
            decimal.TryParse(Console.ReadLine(), out decimal preco);

            decimal desconto = preco - preco * 5 / 100;
            Console.WriteLine($"O produto que custava R${preco}, na promoção com desconto de 5% vai custar R${desconto.ToString("F2")}");
        }
    }
}