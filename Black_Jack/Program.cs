using System;
namespace Black_Jack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Spela 21:n");
            Console.WriteLine("2. vissa namn på sista vinnaren");
            Console.WriteLine("3. regler");
            Console.WriteLine("4. avsluta");
            int svar = int.Parse(Console.ReadLine());
            string namn = "N/A";
            while (svar != 4)
            {
                switch (svar)
                {
                    case 1:
                        {
                            Console.WriteLine("Du och datoren kommer och får 2 kort pars");

                            //random och räkna ut (user)
                            Random user = new Random();
                            Random dator = new Random();
                            int userCard = user.Next(1, 11);
                            int userCardTwo = user.Next(1, 11);
                            int userSumma = userCard + userCardTwo;

                            //visa user resultatet
                            Console.WriteLine("Du fick: " + userCard + ", " + userCardTwo + ".");
                            Console.WriteLine("Summa till denna kort är: " + userSumma + ".");

                            //random och räkna ut (dator)
                            int datorCard = dator.Next(1, 11);
                            int datorCardTwo = dator.Next(1, 11);
                            int datorSumma = datorCard + datorCardTwo;


                            //visa dator resultatet till user
                            Console.WriteLine("Dator fick: " + datorCard + ", " + datorCardTwo + ".");
                            Console.WriteLine("Summa till datoren kort är: " + datorSumma + ".");
                            Console.WriteLine();
                            Console.WriteLine("Vill du dra ett kort? (j/n)");
                            string jaNej = Console.ReadLine();
                            while (userSumma <= 21 && datorSumma <= 21)
                            {
                                if (jaNej == "j")
                                {
                                    userCard = user.Next(1, 11);
                                    userSumma = userCard + userSumma;
                                    Console.WriteLine("Du fick: " + userCard + ".");
                                    Console.WriteLine("Summa till denna kort är: " + userSumma + ".");
                                    Console.WriteLine();
                                    if (datorSumma < userSumma)
                                    {
                                        datorCard = dator.Next(1, 11);
                                        datorSumma = datorSumma + datorCard;

                                        if (userSumma > 21)
                                        {
                                            Console.WriteLine("Du förlårade");
                                            break;
                                        }
                                        else if (datorSumma > 21)
                                        {
                                            Console.WriteLine("Dator fick: " + datorCard + ".");
                                            Console.WriteLine("Summa till datoren kort är: " + datorSumma + ".");
                                            Console.WriteLine();
                                            Console.WriteLine("Du vann!");
                                            Console.WriteLine();
                                            Console.WriteLine("skriv det namn ner");
                                            namn = Console.ReadLine();
                                            break;
                                        }
                                        else if (userSumma == 21 && datorSumma < 21)
                                        {
                                            Console.WriteLine("Du vann!");
                                            Console.WriteLine();
                                            Console.WriteLine("skriv det namn ner");
                                            namn = Console.ReadLine();
                                            break;
                                        }
                                        else if (datorSumma == 21)
                                        {
                                            Console.WriteLine("Dator fick: " + datorCard + ".");
                                            Console.WriteLine("Summa till datoren kort är: " + datorSumma + ".");
                                            Console.WriteLine();
                                            Console.WriteLine("Du förlårade");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Dator fick: " + datorCard + ".");
                                            Console.WriteLine("Summa till datoren kort är: " + datorSumma + ".");
                                            Console.WriteLine();
                                            Console.WriteLine("Vill dra ett mer kort? (j/n)");
                                            jaNej = Console.ReadLine();
                                        }
                                    }
                                    else if (datorSumma >= userSumma)
                                    {
                                        Console.WriteLine("Summa till datoren kort är: " + datorSumma + ".");
                                        Console.WriteLine();
                                        if (datorSumma > 21)
                                        {
                                            Console.WriteLine("Dator fick: " + datorCard + ".");
                                            Console.WriteLine("Summa till datoren kort är: " + datorSumma + ".");
                                            Console.WriteLine();
                                            Console.WriteLine("Du vann!");
                                            Console.WriteLine();
                                            Console.WriteLine("skriv det namn ner");
                                            namn = Console.ReadLine();
                                            break;
                                        }
                                        else if (userSumma > 21)
                                        {
                                            Console.WriteLine("Du förlårade");
                                            break;
                                        }
                                        else if (userSumma == 21 && datorSumma < 21)
                                        {
                                            Console.WriteLine("Du vann!");
                                            Console.WriteLine();
                                            Console.WriteLine("skriv det namn ner");
                                            namn = Console.ReadLine();
                                            break;
                                        }
                                        else if (datorSumma == 21)
                                        {
                                            Console.WriteLine("Dator fick: " + datorCard + ".");
                                            Console.WriteLine("Summa till datoren kort är: " + datorSumma + ".");
                                            Console.WriteLine();
                                            Console.WriteLine("Du förlårade");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Vill dra ett mer kort? (j/n)");
                                            jaNej = Console.ReadLine();
                                        }
                                    }
                                }
                                else if (jaNej == "n")
                                {
                                    Console.WriteLine("Summa till denna kort är: " + userSumma + ".");
                                    Console.WriteLine();
                                    if (datorSumma < userSumma)
                                    {
                                        datorCard = dator.Next(1, 11);
                                        datorSumma = datorSumma + datorCard;
                                        if (datorSumma > 21)
                                        {
                                            Console.WriteLine("Dator fick: " + datorCard + ".");
                                            Console.WriteLine("Summa till datoren kort är: " + datorSumma + ".");
                                            Console.WriteLine();
                                            Console.WriteLine("Du vann!");
                                            Console.WriteLine();
                                            Console.WriteLine("skriv det namn ner");
                                            namn = Console.ReadLine();
                                            break;
                                        }
                                        else if (userSumma > 21)
                                        {
                                            Console.WriteLine("Du förlårade");
                                            break;
                                        }
                                        else if (datorSumma == 21)
                                        {
                                            Console.WriteLine("Dator fick: " + datorCard + ".");
                                            Console.WriteLine("Summa till datoren kort är: " + datorSumma + ".");
                                            Console.WriteLine();
                                            Console.WriteLine("Du förlårade");
                                            break;
                                        }
                                        else if (userSumma == 21 && datorSumma < 21)
                                        {
                                            Console.WriteLine("Du vann!");
                                            Console.WriteLine();
                                            Console.WriteLine("skriv det namn ner");
                                            namn = Console.ReadLine();
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Dator fick: " + datorCard + ".");
                                            Console.WriteLine("Summa till datoren kort är: " + datorSumma + ".");
                                            Console.WriteLine();
                                            Console.WriteLine("Vill dra ett mer kort? (j/n)");
                                            jaNej = Console.ReadLine();
                                        }
                                    }
                                    else if (datorSumma >= userSumma)
                                    {
                                        Console.WriteLine("Summa till datoren kort är: " + datorSumma + ".");
                                        Console.WriteLine();
                                        if (datorSumma > 21)
                                        {
                                            Console.WriteLine("Dator fick: " + datorCard + ".");
                                            Console.WriteLine("Summa till datoren kort är: " + datorSumma + ".");
                                            Console.WriteLine();
                                            Console.WriteLine("Du vann!");
                                            Console.WriteLine();
                                            Console.WriteLine("skriv det namn ner");
                                            namn = Console.ReadLine();
                                            break;
                                        }
                                        else if (userSumma > 21)
                                        {
                                            Console.WriteLine("Du förlårade");
                                            break;
                                        }
                                        else if (userSumma == 21 && datorSumma < 21)
                                        {
                                            Console.WriteLine("Du vann!");
                                            Console.WriteLine();
                                            Console.WriteLine("skriv det namn ner");
                                            namn = Console.ReadLine();
                                            break;
                                        }
                                        else if (datorSumma == 21)
                                        {
                                            Console.WriteLine("Dator fick: " + datorCard + ".");
                                            Console.WriteLine("Summa till datoren kort är: " + datorSumma + ".");
                                            Console.WriteLine();
                                            Console.WriteLine("Du förlårade");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Vill dra ett mer kort? (j/n)");
                                            jaNej = Console.ReadLine();
                                        }
                                    }
                                }
                            }
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Sista vinnaren är: " + namn + ".");
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("1. Du och datoren kommer och får först 2 kort pars och sen 1 kort om man vill.");
                            Console.WriteLine("2. Du måste försoka och nå 21 för att vinna men om du går över 21 du förlårar. Gillar till datoren också.");
                            Console.WriteLine("3. Om datoren har mindre kort an dig den kommer och dra automatiskt.");
                            Console.WriteLine("4. När den har mer eller lika mycket som dig den kommer inte och dra");
                            break;
                        }
                }
                Console.WriteLine();
                Console.WriteLine("1. Spela 21:n");
                Console.WriteLine("2. vissa namn på sista vinnaren");
                Console.WriteLine("3. regler");
                Console.WriteLine("4. avsluta");
                Console.WriteLine();
                svar = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine("Programmet avslutas");
        }
    }
}
