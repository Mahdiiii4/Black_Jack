using System;
namespace Black_Jack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj en av alterantiv nedan via nummer");
            Console.WriteLine("1. Spela 21:an!");
            Console.WriteLine("2. Visa senaste vinnaren");
            Console.WriteLine("3. Spel regler");
            Console.WriteLine("4. Avsluta programmet");
            int val = int.Parse(Console.ReadLine());

            int user = 0;
            int dator = 0;
            Random RandomNumber = new Random();
            switch(val)
            {
                case 1:
                    while(user != 21 && dator != 21)
                    {
                        int userPoint = RandomNumber.Next(1, 11);
                        int datorPoint = RandomNumber.Next(1, 11);
                        Console.WriteLine("Nu kommer två kort dras per spelare");
                        Console.WriteLine("Din poäng: "+userPoint+".");
                        Console.WriteLine("Datornes poäng: "+datorPoint+".");
                        Console.WriteLine("Vill du ha ett till kort? (j/n)");
                        string more = Console.ReadLine();
                        if(more == "j")
                        {
                            Console.WriteLine("Ditt nya kort är värt " +more+ " poäng");
                            Console.WriteLine("Ditt nya kort är värt " + more + " poäng");

                        }
                    }
                    break;
                case 2:

                    break;

                case 3:
                    Console.WriteLine("Regler");
                    break;
                case 4:

                    break;
            }
        }
    }
}