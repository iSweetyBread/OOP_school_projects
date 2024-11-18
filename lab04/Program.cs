using lab04;
using System.Drawing;

public static class Programm
{
    public static void Main(string[] args)
    {
        //Zadanie 1
        //List<Shape> shapes = new List<Shape>();
        //lab04.Rectangle rectangle = new lab04.Rectangle(1, 2, 3);
        //lab04.Triangle triangle = new lab04.Triangle(1, 2, 3);
        //lab04.Circle circle = new lab04.Circle(1, 2, 3);
        //shapes.Add(rectangle);
        //shapes.Add(triangle);
        //shapes.Add(circle);

        //foreach (Shape shape in shapes)
        //{
        //    shape.Draw();
        //}



        //Zadanie 2
        //Uczen uczen1 = new Uczen();
        //Uczen uczen2 = new Uczen();
        //Uczen uczen3 = new Uczen();
        //Uczen uczen4 = new Uczen();

        //uczen1.SetFirstName("Jan");
        //uczen1.SetLastName("Kowalski");
        //uczen1.SetPesel("05210112345"); // PESEL example
        //uczen1.SetSchool("Szkoła Podstawowa nr 1");
        //uczen1.SetCanGoHomeAlone(DateTime.Now);

        //uczen2.SetFirstName("Anna");
        //uczen2.SetLastName("Nowak");
        //uczen2.SetPesel("09250698765"); // PESEL example
        //uczen2.SetSchool("Szkoła Podstawowa nr 2");
        //uczen2.SetCanGoHomeAlone(DateTime.Now);

        //uczen3.SetFirstName("Marek");
        //uczen3.SetLastName("Wisniewski");
        //uczen3.SetPesel("11232234567"); // PESEL example
        //uczen3.SetSchool("Technikum Informatyczne");
        //uczen3.SetCanGoHomeAlone(DateTime.Now);

        //uczen4.SetFirstName("Zofia");
        //uczen4.SetLastName("Jankowska");
        //uczen4.SetPesel("17222587654"); // PESEL example
        //uczen4.SetSchool("Szkoła Ogólnokształcąca");
        //uczen4.SetCanGoHomeAlone(DateTime.Now);

        //List<Uczen> students = new List<Uczen>();
        //students.Add(uczen1);
        //students.Add(uczen2);
        //students.Add(uczen3);
        //students.Add(uczen4);

        //Nauczyciel nauczyciel = new Nauczyciel();
        //nauczyciel.SetFirstName("Adam");
        //nauczyciel.SetLastName("Janowski");

        //foreach (Uczen stud in students)
        //{ 
        //    nauczyciel.AddStud(stud);
        //}

        //nauczyciel.WhichStudentCanGoHomeAlone(DateTime.Today);



        //Zadanie 3
        Osoba1 osoba1 = new Osoba1("Jan", "Kowalski");
        Osoba1 osoba2 = new Osoba1("Adam", "Mickewicz");
        Osoba1 osoba3 = new Osoba1("Zofia", "Jankowska");
        Osoba1 osoba4 = new Osoba1("Marek", "Wisniewski");
        Osoba1 osoba5 = new Osoba1("Andrzej", "Kowalski");

        List<IOsoba> osoby = new List<IOsoba>();

        osoby.Add(osoba1);
        osoby.Add(osoba2);
        osoby.Add(osoba3);
        osoby.Add(osoba4);
        osoby.Add(osoba5);

        osoby.WypiszOsobu();
        osoby.PosortujOsobyPoNazwisku();
        Console.WriteLine();
        osoby.WypiszOsobu();

        Student student = new Student("Jan", "Kowalski", "PR", "IID-P", 2018, 4);
        Console.WriteLine(student.WypiszPelnaNazweIUczelnie());
        StudentWSIiZ studentWSIiZ = new StudentWSIiZ("Adam", "Polanski", "IID-P", 2018, 4);
        Console.WriteLine(studentWSIiZ.WypiszPelnaNazweIUczelnie());
    }
}