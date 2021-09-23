using System;


namespace StructureAndEnum
{
    // This program demo. how to use struct
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book(100,"C#4.0","Donis");
            Console.WriteLine(myBook.Display());
            Console.ReadLine();

        }
    }
}
