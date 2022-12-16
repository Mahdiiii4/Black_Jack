using System;
namespace Black_Jack
{
    class Program
    {
        static void Main(string[] args)
        {   //färg
            Console.BackgroundColor = ConsoleColor.Black;
            var yellow = Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            //Program start
            Console.WriteLine("Välj nummer mellan 1 och 4.");
            Thread.Sleep(1000);
            Console.WriteLine("1. Spela 21:n");
            Thread.Sleep(500);
            Console.WriteLine("2. vissa namn på sista vinnaren");
            Thread.Sleep(500);
            Console.WriteLine("3. regler");
            Thread.Sleep(500);
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
                            Thread.Sleep(1000);
                            //random och räkna ut (user)
                            Random user = new Random();
                            int userCard = user.Next(minCard, maxCard);
                            int userCardTwo = user.Next(minCard, maxCard);
                            int userSumma = userCard + userCardTwo;

                            //visa user resultatet
                            //ändra färg
                            Console.Write("Du fick: ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(+userCard + "");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(",");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(+userCardTwo + "");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(".");
                            Thread.Sleep(1000);
                            Console.Write("Summa till denna kort är: ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(+userSumma + "");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(".");
                            Thread.Sleep(2000);

                            //random och räkna ut (dator)
                            Random dator = new Random();
                            int datorCard = dator.Next(minCard, maxCard);
                            int datorCardTwo = dator.Next(minCard, maxCard);
                            int datorSumma = datorCard + datorCardTwo;

                            //visa dator resultatet till user och fråga
                            //ändra färg
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Dator fick: ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(+datorCard + "");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(", ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(+datorCardTwo + "");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(".");
                            Thread.Sleep(1000);
                            Console.Write("Summa till datoren kort är: ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(+datorSumma + "");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(".");
                            Thread.Sleep(1000);
                            Console.WriteLine();

                            //variabl för fråga
                            string jaNej;

                            //check condation för user
                            if (userSumma > loseCard)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Du");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("förlårade");
                                break;
                            }
                            else if (userSumma == loseCard)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Du");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("vann!");
                                Console.WriteLine();
                                Thread.Sleep(2000);
                                Console.WriteLine("skriv det namn ner");
                                namn = Console.ReadLine();
                                break;
                            }

                            //check condation för dator
                            if (datorSumma > loseCard)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Du");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("vann!");
                                Console.WriteLine();
                                Thread.Sleep(2000);
                                Console.WriteLine("skriv det namn ner");
                                namn = Console.ReadLine();
                                break;
                            }
                            else if (datorSumma == loseCard)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Du");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("förlårade");
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
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("Du fick: ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(+userCard + "");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(".");
                                    Thread.Sleep(1000);
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("Summa till denna kort är: ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(+ userSumma + "");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(".");
                                    Thread.Sleep(1000);
                                    Console.WriteLine();

                                    if (userSumma > loseCard)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("Du");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("förlårade");
                                        break;
                                    }
                                    else if (userSumma == loseCard)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("Du");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("vann!");
                                        Console.WriteLine();
                                        Thread.Sleep(2000);
                                        Console.WriteLine("skriv det namn ner");
                                        namn = Console.ReadLine();
                                        break;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("Datorens summa är: ");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.Write(+ datorSumma + "");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine(".");
                                        Console.WriteLine("Vill dra ett mer kort? (j/n)");
                                        jaNej = Console.ReadLine();
                                        Console.WriteLine();
                                    }
                                }
                                //Dra inte kort, dra kort for dator om < user och checka vinna, förlora villkor.
                                else if (jaNej == "n")
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("Summa till denna kort är: ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(+ userSumma + "");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(".");
                                    Console.WriteLine();
                                    Thread.Sleep(2000);
                                    while (datorSumma < userSumma)
                                    {
                                        Console.WriteLine("Datoren kommer och dra kort tills den är lika eller store än den summa");
                                        Thread.Sleep(1000);
                                        Console.WriteLine();
                                        datorCard = dator.Next(minCard, maxCard);
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("Datoren fick: ");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.Write(+ datorCard + "");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine(".");
                                        Thread.Sleep(1000);
                                        datorSumma = datorSumma + datorCard;
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("Dator summa är: ");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.Write(+ datorSumma + "");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine(".");
                                        Thread.Sleep(1000);
                                        Console.WriteLine();
                                        Thread.Sleep(2000);
                                    }

                                    if (datorSumma > loseCard)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("Du");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("vann!");
                                        Console.WriteLine();
                                        Thread.Sleep(2000);
                                        Console.WriteLine("skriv det namn ner");
                                        namn = Console.ReadLine();
                                        break;
                                    }
                                    else if (datorSumma == loseCard)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("Du");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("förlårade");
                                        break;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("Datorens summa är: ");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.Write(+ datorSumma + "");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine(".");
                                        Thread.Sleep(1000);
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
                            Thread.Sleep(1000);
                            Console.WriteLine("1. mål är att tvinga datorn att få mer än 21 poäng.");
                            Thread.Sleep(500);
                            Console.WriteLine("2. Du får poäng genom att dra kort, varje kort har 1 - 10 poäng.");
                            Thread.Sleep(500);
                            Console.WriteLine("3. Om du får mer än 21 poäng har du förlorat.");
                            Thread.Sleep(500);
                            Console.WriteLine("4. Både du och datorn får två kort i början.");
                            Thread.Sleep(500);
                            Console.WriteLine("5. Därefter får du fler kort tills du är nöjd eller får över 21.");
                            Thread.Sleep(500);
                            Console.WriteLine("6. När du är färdig drar datorn kort till den har mer poäng än dig eller över 21 poäng.");
                            break;
                        }
                }
                //när loop är av --> för att välja igen.
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("Välj nummer mellan 1 och 4.");
                Thread.Sleep(1000);
                Console.WriteLine("1. Spela 21:n");
                Thread.Sleep(500);
                Console.WriteLine("2. vissa namn på sista vinnaren");
                Thread.Sleep(500);
                Console.WriteLine("3. regler");
                Thread.Sleep(500);
                Console.WriteLine("4. avsluta");
                Console.WriteLine();
                svar = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine("Programmet avslutades");
        }
    }
}
