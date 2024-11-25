using lab05;

public static class Programm 
{
    public static void Main(string[] args)
    {
        ////Zadanie 1
        //lab05.A a1 = new lab05.A();
        //lab05.A a2 = new lab05.A();
        //lab05.A a3 = new lab05.A();

        //lab05.B b1 = new lab05.B();
        //lab05.B b2 = new lab05.B();
        //lab05.B b3 = new lab05.B();

        //lab05.C c1 = new lab05.C();
        //lab05.C c2 = new lab05.C();
        //lab05.C c3 = new lab05.C();

        //List<lab05.A> Alist = new List<lab05.A>();
        //List<lab05.B> Blist = new List<lab05.B>();
        //List<lab05.C> Clist = new List<lab05.C>();

        //Alist.Add(a1);
        //Alist.Add(a2);
        //Alist.Add(a3);
        //Alist.Add(b1);
        //Alist.Add(b2);
        //Alist.Add(b3);
        //Alist.Add(c1);
        //Alist.Add(c2);
        //Alist.Add(c3);

        //foreach (lab05.A a in Alist)
        //{ 
        //    a.GenRand(1, 10);
        //    a.Calculate(1, 10);
        //}
        //Console.WriteLine();

        //Blist.Add(b1);
        //Blist.Add(b2);
        //Blist.Add(b3);
        //Blist.Add(c1);
        //Blist.Add(c2);
        //Blist.Add(c3);

        //foreach (lab05.B b in Blist)
        //{ 
        //    b.GenRand(1, 10);
        //    b.Calculate(1, 10);
        //}
        //Console.WriteLine();

        //Clist.Add(c1);
        //Clist.Add(c2);
        //Clist.Add(c3);

        //foreach (lab05.C c in Clist)
        //{ 
        //    c.GenRand(1, 10);
        //    c.Calculate(1, 10);
        //}
        //Console.WriteLine();



        //Zadanie 2
        Punkt aaa = new Punkt("aaa", 31, 84);
        Punkt bbb = new Punkt("bbb", 312, 84);
        Punkt ccc = new Punkt("ccc", 34, 56);
        Punkt ddd = new Punkt("ddd", 65, 234);
        Punkt punkt1 = new Punkt("punkt1", 45, 546);
        Punkt punkt2 = new Punkt("punkt2", 45, 5450);

        List<Punkt> list1 = new List<Punkt> { aaa, bbb, ccc, ddd, punkt1 };
        List<Punkt> list2 = new List<Punkt> { aaa, bbb, ccc, ddd, punkt2 };

        Wielobok wielobok1 = new Wielobok("Wielobok1", list1);
        Wielobok wielobok2 = new Wielobok("Wielobok1", list2);

        Console.WriteLine(wielobok1.Obwod());
        wielobok1.DodajPunkt(punkt2);
        Console.WriteLine(wielobok1.Obwod());
    }
}
