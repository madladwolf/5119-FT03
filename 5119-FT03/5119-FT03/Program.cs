using System;

namespace _5119_FT03
{
    class Program
    {
        static void Main(string[] args)
        {
            Hora h1 = new Hora(10, 20, 30);
            Hora h2 = new Hora(11, 21, 31);
            Data d1 = new Data(10,12,2000,"segunda", 5);
            Data d2 = new Data(20, 10, 2010, "terça", 3);
            Console.WriteLine(h1.ToString());
        }
    }
}
