using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    public class Kolory
    {
        public enum kolor
        { 
            Czerwony = 1,
            Niebieski = 2,
            Zielony = 3,
            Zolty = 4,
            Fioletowy = 5,
        }
        private static List<string> kolory1 = new List<string> { "czerwony", "niebieski", "zielony", "zolty", "fioletowy", };

        public Kolory() { }

        public void start()
        {
            Random rnd = new Random();
            int random = rnd.Next(0, kolory1.Count - 1);
            string target = kolory1[random];

            Console.WriteLine("Odgadnij losowy kolor; żeby wyjść, wpisz \"exit\"");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    return;
                }
                try
                {
                    if (!kolory1.Contains(input.ToLower()))
                    {
                        throw new ArgumentException("Nieprawidłowy kolor");
                    }
                    if (input.ToLower() == target)
                    {
                        Console.WriteLine($"Zgadłeś kolor {target}! Czy chcesz zagrać znów?");
                        while (true)
                        {
                            Console.WriteLine("Tak      Nie");
                            string ans = Console.ReadLine();
                            if (ans.ToLower() == "tak")
                            {
                                this.start();
                            }
                            else if (ans.ToLower() == "nie")
                            {
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Niewłaściwa odpowiedź");
                                continue;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nie zgadłeś");
                        continue;
                    }
                }
                catch (Exception ex)
                { 
                    Console.WriteLine(ex.ToString());
                    continue;
                }
            }
        }
    }
}
