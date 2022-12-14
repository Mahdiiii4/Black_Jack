using System;
namespace Black_Jack
{
    class Program
    {
        static void Main(string[] args)
        {   //färg
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Program start
            Console.WriteLine("Välj nummer mellan 1 och 4.");
            Console.WriteLine("1. Spela 21:n");
            Console.WriteLine("2. vissa namn på sista vinnaren");
            Console.WriteLine("3. regler");
            Console.WriteLine("4. avsluta");
            int svar = int.Parse(Console.ReadLine());
            string namn = "Ingen har vunnit än";
            while (svar != 4)
            {
                switch (svar)
                {
                    case 1:
                        {
                            //Styr max kort dras till dig och datoren
                            Console.WriteLine("Välj max kort som drar till dig och datoren.");
                            int maxCard = int.Parse(Console.ReadLine());
                            //Styr minst kort dras till dig och datoren
                            Console.WriteLine("Välj minst kort som drar till dig och datoren.");
                            int minCard = int.Parse(Console.ReadLine());
                            //Styr 21
                            Console.WriteLine("Välj ett nummer som man går över man förlårar (istält för 21 som är standard)");
                            int loseCard = int.Parse(Console.ReadLine());

                            Console.WriteLine("Du och datoren kommer och får 2 kort pars");

                            //random och räkna ut (user)
                            Random user = new Random();
                            int userCard = user.Next(minCard, maxCard);
                            int userCardTwo = user.Next(minCard, maxCard);
                            int userSumma = userCard + userCardTwo;

                            //visa user resultatet
                            Console.WriteLine("Du fick: " + userCard + ", " + userCardTwo + ".");
                            Console.WriteLine("Summa till denna kort är: " + userSumma + ".");

                            //random och räkna ut (dator)
                            Random dator = new Random();
                            int datorCard = dator.Next(minCard, maxCard);
                            int datorCardTwo = dator.Next(minCard, maxCard);
                            int datorSumma = datorCard + datorCardTwo;


                            //visa dator resultatet till user och fråga
                            Console.WriteLine("Dator fick: " + datorCard + ", " + datorCardTwo + ".");
                            Console.WriteLine("Summa till datoren kort är: " + datorSumma + ".");
                            Console.WriteLine();

                            //variabl för fråga
                            string jaNej;

                            //check condation för user
                            if (userSumma > loseCard)
                            {
                                Console.WriteLine("Du förlårade");
                                break;
                            }
                            else if (userSumma == loseCard)
                            {
                                Console.WriteLine("Du vann!");
                                Console.WriteLine();
                                Console.WriteLine("skriv det namn ner");
                                namn = Console.ReadLine();
                                break;
                            }

                            //check condation för dator
                            if (datorSumma > loseCard)
                            {
                                Console.WriteLine("Du vann!");
                                Console.WriteLine();
                                Console.WriteLine("skriv det namn ner");
                                namn = Console.ReadLine();
                                break;
                            }
                            else if (datorSumma == loseCard)
                            {
                                Console.WriteLine("Du förlårade");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Vill du dra ett kort? (j/n)");
                                jaNej = Console.ReadLine();
                                Console.WriteLine();
                            }

                            //loop
                            while (userSumma <= loseCard && datorSumma <= loseCard)
                            {
                                //om ja dra kort och checka vinna, förlora villkor.
                                if (jaNej == "j")
                                {
                                    userCard = user.Next(minCard, maxCard);
                                    userSumma = userCard + userSumma;
                                    Console.WriteLine("Du fick: " + userCard + ".");
                                    Console.WriteLine("Summa till denna kort är: " + userSumma + ".");
                                    Console.WriteLine();

                                    if (userSumma > loseCard)
                                    {
                                        Console.WriteLine("Du förlårade");
                                        break;
                                    }
                                    else if (userSumma == loseCard)
                                    {
                                        Console.WriteLine("Du vann!");
                                        Console.WriteLine();
                                        Console.WriteLine("skriv det namn ner");
                                        namn = Console.ReadLine();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Datorens summa är: " + datorSumma + ".");
                                        Console.WriteLine("Vill dra ett mer kort? (j/n)");
                                        jaNej = Console.ReadLine();
                                        Console.WriteLine();
                                    }
                                }
                                //Dra inte kort, dra kort for dator om < user och checka vinna, förlora villkor.
                                else if (jaNej == "n")
                                {
                                    Console.WriteLine("Summa till denna kort är: " + userSumma + ".");
                                    Console.WriteLine();

                                    while (datorSumma < userSumma)
                                    {
                                        Console.WriteLine("Datoren kommer och dra kort tills den är lika eller store än den summa");
                                        Console.WriteLine();
                                        datorCard = dator.Next(minCard, maxCard);
                                        Console.WriteLine("Datoren fick: " + datorCard + ".");
                                        datorSumma = datorSumma + datorCard;
                                        Console.WriteLine("Dator summa är: " + datorSumma + ".");
                                        Console.WriteLine();
                                    }

                                    if (datorSumma > loseCard)
                                    {
                                        Console.WriteLine("Du vann!");
                                        Console.WriteLine();
                                        Console.WriteLine("skriv det namn ner");
                                        namn = Console.ReadLine();
                                        break;
                                    }
                                    else if (datorSumma == loseCard)
                                    {
                                        Console.WriteLine("Du förlårade");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Datorens summa är: " + datorSumma + ".");
                                        Console.WriteLine("Vill dra ett mer kort? (j/n)");
                                        jaNej = Console.ReadLine();
                                        Console.WriteLine();
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
                            Console.WriteLine("Regler:");
                            Console.WriteLine("1. mål är att tvinga datorn att få mer än 21 poäng.");
                            Console.WriteLine("2. Du får poäng genom att dra kort, varje kort har 1 - 10 poäng.");
                            Console.WriteLine("3. Om du får mer än 21 poäng har du förlorat.");
                            Console.WriteLine("4. Både du och datorn får två kort i början.");
                            Console.WriteLine("5. Därefter får du fler kort tills du är nöjd eller får över 21.");
                            Console.WriteLine("6. När du är färdig drar datorn kort till den har mer poäng än dig eller över 21 poäng.");
                            break;
                        }
                }
                //när loop är av --> för att välja igen.
                Console.WriteLine();
                Console.WriteLine("Välj nummer mellan 1 och 4.");
                Console.WriteLine("1. Spela 21:n");
                Console.WriteLine("2. vissa namn på sista vinnaren");
                Console.WriteLine("3. regler");
                Console.WriteLine("4. avsluta");
                Console.WriteLine();
                svar = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine("Programmet avslutades");
        }
    }
}
