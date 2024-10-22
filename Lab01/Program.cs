public class Program
{
    public static void Main(string[] args)
    {
        //zad01();
        //zad02();
        //zad03();
        //zad04();
        //zad05();
        //zad06();
        //zad07();
    }

    //Zadanie 1
    public static void zad01()
    {
        double a = DoubleInput();
        double b = DoubleInput();
        double c = DoubleInput();
        double x1, x2, d;

        if(a == 0)
        {
            Console.WriteLine("Równania nie jest kwadratowym");
        }
        else
        {
            d = Math.Pow(b, 2) - (4 * a * c);
            if (d < 0)
            {
                Console.WriteLine("Rozwiązanie nie jest liczbą rzeczywistą");
            }
            else if (d == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine($"Rozwiązanie wynosi: {x1}, delta wynosi: {d}");
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine($"Rozwiązanie wynosi: {x1} {x2}, delta wynosi: {d}");
            }
        }
    }
    static double DoubleInput()
    {
        Console.WriteLine("Podaj liczbę: ");
        double val = Convert.ToDouble(Console.ReadLine());
        return val;
    }

    //Zadanie 2
    public static void zad02()
    {
        while (true)
        {
            Console.WriteLine("\n1. Suma\n2. Różnica\n3. Iloczyn\n4. Iloraz\n5. Potęga\n6. Pierwiastek\n7. Trygonometria\n8. Koniec");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1: Sum(); break;
                case 2: Dif(); break;
                case 3: Mult(); break;
                case 4: Div(); break;
                case 5: Pow(); break;
                case 6: Sqrt(); break;
                case 7: Tryg(); break;
                case 8: Close(); break;
                default: Console.WriteLine("Niepoprawne Dane"); break;
            }
        }
    }
    public static void Close()
    {
        Console.WriteLine("Bye!");
        System.Environment.Exit(1);
    }
    public static void Sum()
    {
        double a = DoubleInput();
        double b = DoubleInput();
        Console.WriteLine($"Wynik: {a + b}");
    }
    public static void Dif()
    {
        double a = DoubleInput();
        double b = DoubleInput();
        Console.WriteLine($"Wynik: {a - b}");
    }
    public static void Mult()
    {
        double a = DoubleInput();
        double b = DoubleInput();
        Console.WriteLine($"Wynik: {a * b}");
    }
    public static void Div()
    {
        double a = DoubleInput();
        double b = DoubleInput();
        if (b == 0)
        {
            Console.WriteLine("Dzielenie przez 0 jest niemożliwe");
        }
        else
        {
            Console.WriteLine($"Wynik: {a / b}");
        }
    }
    public static void Pow()
    {
        double a = DoubleInput();
        double b = DoubleInput();
        Console.WriteLine($"Wynik: {Math.Pow(a, b)}");
    }
    public static void Sqrt()
    {
        double a = DoubleInput();
        Console.WriteLine($"Wynik: {Math.Sqrt(a)}");
    }
    public static void Tryg()
    {
        while (true)
        {
            Console.WriteLine("\n1. Sinus\n2. Cosinus\n3. Tangens\n4. Cotangens\n5. Powrót");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1: Console.WriteLine($"Wynik: {Math.Sin(DoubleInput())}"); break;
                case 2: Console.WriteLine($"Wynik: {Math.Cos(DoubleInput())}"); break;
                case 3: Console.WriteLine($"Wynik: {Math.Sin(DoubleInput()) / Math.Cos(DoubleInput())}"); break;
                case 4: Console.WriteLine($"Wynik: {Math.Cos(DoubleInput()) / Math.Sin(DoubleInput())}"); break;
                case 5: return;
                default: Console.WriteLine("Niepoprawne Dane"); break;
            }
        }
    }

    //Zadanie 3
    public static void zad03()
    {
        double[] nums = new double[10];
        for (int i = 0; i < 10; i++)
        {
            nums[i] = DoubleInput();
        }
        do 
        {
            Console.WriteLine("\n1. Od pierwszego do ostatniego\n2. Od ostatniego do pierwszego\n3. Elementy nieparzyste\n4. Elementy parzyste\n5. Exit\n");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine(nums[i]);
                }
            }
            else if (input == 2)
            {
                for (int i = 9; i >= 0; i--)
                {
                    Console.WriteLine(nums[i]);
                }
            }
            else if (input == 3)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i % 2 == 0) { Console.WriteLine(nums[i]); }
                }
            }
            else if (input == 4)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i % 2 == 1) { Console.WriteLine(nums[i]); }
                }
            }
            else if (input == 5)
            {
                Console.WriteLine("Bye!");
                return;
            }
            else 
            {
                Console.WriteLine("Niepoprawne Dane");
            }
        } while (true);
    }

    //Zadanie 4
    public static void zad04()
    {
        double[] nums = new double[10];
        for (int i = 0; i < 10; i++)
        {
            nums[i] = DoubleInput();
        }

        Console.WriteLine($"Suma liczb: {Sum(nums)}");
        Console.WriteLine($"Iloczyn liczb: {Product(nums)}");
        Console.WriteLine($"Wartość średnia: {Average(nums)}");
        Console.WriteLine($"Wartość minimalna: {Minimum(nums)}");
        Console.WriteLine($"Wartość maksymalna: {Maximum(nums)}");

    }
    public static double Sum(double[] numbers) 
    {
        double result = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            result += numbers[i];
        }
        return result;
    }
    public static double Product(double[] numbers)
    {
        double result = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            result *= numbers[i];
        }
        return result;
    }
    public static double Average(double[] numbers)
    { 
        return Sum(numbers)/numbers.Length;
    }
    public static double Minimum(double[] numbers)
    { 
        double min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            { 
                min = numbers[i];
            }
        }
        return min;
    }
    public static double Maximum(double[] numbers)
    {
        double max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }

    //Zadanie 5
    public static void zad05()
    {
        int[] exceptions = { 2, 6, 9, 15, 19 };
        for (int i = 20; i >= 0; i--)
        {
            if (exceptions.Contains(i)) 
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }

    //Zadanie 6
    public static void zad06()
    { 
        while (true)
        {
            Console.WriteLine("Podaj liczbę całkowitą: ");
            string? input = Console.ReadLine();
            if (input != null && Int32.TryParse(input, out int num))
            {
                if (num < 0) { break; }
            }
        }
    }

    //Zadanie 7
    public static void zad07()
    { 
        Console.WriteLine("Podaj ilość liczb: ");
        string? input = Console.ReadLine();
        int n;

        while (!Int32.TryParse(input, out n))
        {
            Console.WriteLine("Nieprawidłowa wartość, sprobuj ponownie: ");
            input = Console.ReadLine();
        }

        double[] numbers = new double[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = DoubleInput();
        }

        Console.WriteLine("Nieposortowana lista: ");
        foreach (int i in numbers) { Console.Write($"{i}, "); }
        double[] numbers2 = BubbleSort(numbers);
        Console.WriteLine();
        Console.WriteLine("Posortowana lista: ");
        foreach (int i in numbers2) { Console.Write($"{i}, "); }
    }

    public static double[] BubbleSort(double[] nums)
    {
        int i, j;
        double temp;
        for (i = 0; i < nums.Length - 1; i++)
        {
            for (j = 0; j < nums.Length - i - 1; j++) 
            {
                if (nums[j] > nums[j + 1])
                {
                    temp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = temp;
                }
            }
        }
        return nums;
    }
}
