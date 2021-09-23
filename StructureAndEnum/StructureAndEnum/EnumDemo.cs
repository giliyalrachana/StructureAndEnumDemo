using System;


namespace StructureAndEnum
{
    class EnumDemo
    {
        static void Main()
        {
            Console.WriteLine($"{GSTStateCode.GJ}={GSTStateCode.GJ.GetHashCode()}");
            Console.WriteLine($"{GSTStateCode.GJ}={Convert.ToInt32(GSTStateCode.GJ)}");
            // var names = Enum.GetNames(typeof(GSTStateCode));
            var names = Enum.GetValues(typeof(GSTStateCode));
            foreach(var name in names)
            {
                Console.WriteLine($"{name}={name.GetHashCode()}");
            }
            Console.ReadLine();


        }
    }
}
