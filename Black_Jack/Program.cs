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
            string namn = "Ingen har vunnit än";
            while (svar != 4)
            {
                switch (svar)
                {
                    case 1:
                        {
                            Console.WriteLine("Du och datoren kommer och får 2 kort pars");

                            //random och räkna ut (user)
                            Random user = new Random();
                            int userCard = user.Next(1, 11);
                            int userCardTwo = user.Next(1, 11);
                            int userSumma = userCard + userCardTwo;

                            //visa user resultatet
                            Console.WriteLine("Du fick: " + userCard + ", " + userCardTwo + ".");
                            Console.WriteLine("Summa till denna kort är: " + userSumma + ".");

                            //random och räkna ut (dator)
                            Random dator = new Random();
                            int datorCard = dator.Next(1, 11);
                            int datorCardTwo = dator.Next(1, 11);
                            int datorSumma = datorCard + datorCardTwo;


                            //visa dator resultatet till user och fråga
                            Console.WriteLine("Dator fick: " + datorCard + ", " + datorCardTwo + ".");
                            Console.WriteLine("Summa till datoren kort är: " + datorSumma + ".");
                            Console.WriteLine();
                            Console.WriteLine("Vill du dra ett kort? (j/n)");
                            string jaNej = Console.ReadLine();

                            //loop
                            while (userSumma <= 21 && datorSumma <= 21)
                            {
                                //om ja dra kort och checka vinna, förlora villkor.
                                if (jaNej == "j")
                                {
                                    userCard = user.Next(1, 11);
                                    userSumma = userCard + userSumma;
                                    Console.WriteLine("Du fick: " + userCard + ".");
                                    Console.WriteLine("Summa till denna kort är: " + userSumma + ".");
                                    Console.WriteLine();

                                    if (userSumma > 21)
                                    {
                                        Console.WriteLine("Du förlårade");
                                        break;
                                    }
                                    else if (userSumma == 21)
                                    {
                                        Console.WriteLine("Du vann!");
                                        Console.WriteLine();
                                        Console.WriteLine("skriv det namn ner");
                                        namn = Console.ReadLine();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Vill dra ett mer kort? (j/n)");
                                        jaNej = Console.ReadLine();
                                    }
                                }
                                //Dra inte kort, dra kort for dator om < user och checka vinna, förlora villkor.
                                else if (jaNej == "n")
                                {
                                    Console.WriteLine("Summa till denna kort är: " + userSumma + ".");
                                    Console.WriteLine();
                                    if (datorSumma < userSumma)
                                    {
                                        Console.WriteLine("Datoren kommer och dra kort tills den är lika eller store än den summa");
                                        Console.WriteLine();

                                        while (datorSumma < userSumma)
                                        {
                                            datorCard = dator.Next(1, 11);
                                            Console.WriteLine("Datoren fick: " + datorCard + ".");
                                            datorSumma = datorSumma + datorCard;
                                            Console.WriteLine("Dator summa är: " + datorSumma + ".");
                                            Console.WriteLine();
                                        }

                                        if (datorSumma > 21)
                                        {
                                            Console.WriteLine("Du vann!");
                                            Console.WriteLine();
                                            Console.WriteLine("skriv det namn ner");
                                            namn = Console.ReadLine();
                                            break;
                                        }
                                        else if (datorSumma == 21)
                                        {
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
