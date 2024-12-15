using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    public class Calc
    {
        public enum Operations
        { 
            Add = 1,
            Subtract = 2,
            Multiply = 3,
            Divide = 4,
        }
        public List<double> results = new List<double>();

        public Calc() { }

        public void start()
        {
            Console.WriteLine("Możliwe operacje:\n\tDodawanie - 1\n\tOdejmowanie - 2\n\tMnożenie - 3\n\tDzielenie - 4\n\tWyświetl historię - 5\n\tExit - 6");
            string ans = Console.ReadLine();
            switch (ans)
            {
                case "1":
                    this.Calculate(Operations.Add);
                    break;
                case "2":
                    this.Calculate(Operations.Subtract);
                    break;
                case "3":
                    this.Calculate(Operations.Multiply);
                    break;
                case "4":
                    this.Calculate(Operations.Divide);
                    break;
                case "5":
                    Console.Write("Poprzednie wyniki: ");
                    foreach (double a in results)
                    { 
                        Console.Write($"{a}, ");
                    }
                    Console.WriteLine();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Nieoczekiwana odpowiedź. Spróbuj ponownie\n\n");
                    this.start();
                    break;
            }
            this.start();
        }
        public void Calculate(Operations op)
        {
            double x = this.NumInput();
            double y = this.NumInput();
            double res;

            switch(op)
            {
                case Operations.Add:
                    res = this.Add(x, y);
                    Console.WriteLine($"Wynik: {res}");
                    this.results.Add(res);
                    break;
                case Operations.Subtract:
                    res = this.Subtract(x, y);
                    Console.WriteLine($"Wynik: {res}");
                    this.results.Add(res);
                    break;
                case Operations.Multiply:
                    res = this.Multiply(x, y);
                    Console.WriteLine($"Wynik: {res}");
                    this.results.Add(res);
                    break;
                case Operations.Divide:
                    try
                    {
                        res = this.Divide(x, y);
                        Console.WriteLine($"Wynik: {res}");
                        this.results.Add(res);
                    } 
                    catch (DivideByZeroException ex) 
                    { 
                        Console.WriteLine("Błąd dzielenia przez zero. Spróbuj ponownie");
                        this.Calculate(op);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Nieoczekiwany błąd. Spróbuj ponownie");
                        this.Calculate(op);
                    }
                    break;
            }
        }

        public double Add(double x, double y)
        { 
            return x + y;
        }
        public double Subtract(double x, double y) 
        {
            return x - y; 
        }
        public double Multiply(double x, double y)
        { 
            return x * y;
        }
        public double Divide(double x, double y)
        { 
            return (double)((decimal)x / (decimal)y);
        }

        public double NumInput()
        {
            Console.WriteLine("Podaj liczbę: ");
            while (true)
            {
                try
                {
                    double input = Double.Parse(Console.ReadLine());
                    return input;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Podana niepoprawna wartość. Spróbuj ponownie: ");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Nieoczekiwany błąd. Spróbuj ponownie");
                    continue;
                }
            }
        }
    }
}
