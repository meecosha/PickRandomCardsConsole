using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the number of cards");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int numberOfCards))
            {
                CardPicker.PickSomeCards(numberOfCards);
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("Fuck you, wrong stuff");
            }
        }
    }
}
