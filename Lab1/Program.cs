using Lab1;

internal class Program
{
    private static void Main(string[] args)
    {
        int a, b;
        a = 4;
        b = a;
        b = 1;

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        float d = 0.1234567891234567891234567891234F;
        double e  = 0.1234567891234567891234567891234;
        decimal f  = 0.1234567891234567891234567891234M;


        Console.WriteLine("d = " + d);
        Console.WriteLine("e = " + e);
        Console.WriteLine("f = " + f);

        var bookStruct1 = new Book();
        bookStruct1.Name = "Book1";
        bookStruct1.Price = 10;

        var bookStruct2 = new Book();
        bookStruct2 = bookStruct1;

        bookStruct2.Price = 20;

        Console.WriteLine("book1 - " + bookStruct1.Name + " " + bookStruct1.Price);
        Console.WriteLine("book2 - " + bookStruct2.Name + " " + bookStruct2.Price);

        var bookClass1 = new BookClass();
        bookClass1.Name = "Book1";
        bookClass1.Price = 10;

        var bookClass2 = new BookClass();
        bookClass2 = bookClass1;

        bookClass2.Price = 20;

        Console.WriteLine("book class 1 - " + bookClass1.Name + " " + bookClass1.Price);
        Console.WriteLine("book class 2 - " + bookClass2.Name + " " + bookClass2.Price);
    }
}