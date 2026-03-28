namespace task2;

public class BoxingTester
{
    public static void Test()
    {
        int a = 10;
        object b = a;
        int c = (int)b;
        
        Console.WriteLine($"int value is {a}; boxing value into object is {b}; unboxing back into int is {c}");
        // спочатку ми перетворили числове значення в об'єкт (значення потрапляє в купу), тобто зробили boxing, після чого об'єкт знову повернули в числове значення - unboxing (створюється нове значення в стеку)
    }
}