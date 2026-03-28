namespace task2;

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point { X = 1, Y = 2 };
        Point p2 = p1;
        p2.X = 15;
        p1.Print();
        p2.Print();
        Console.WriteLine();

        PointRef r1 = new PointRef { X = 1, Y = 2 };
        PointRef r2 = r1;
        r2.X = 11;
        r1.Print();
        r2.Print();
        Console.WriteLine();

        BoxingTester.Test();
        
        // коли ми створюємо стуктуру, то після змінення координат другої точки, координати першої залишаються незмінними, бо друга точка створюється як окреме значення; а коли ми використовуємо просто клас, то значення першої точки також перезаписується після змінення другої, бо дві точки вказують на один і той же об'єкт у купі.
    }
}