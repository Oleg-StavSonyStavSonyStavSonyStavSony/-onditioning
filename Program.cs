using System;

namespace core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human human = new Human("Ivan", 22);
            human.RoomTemperature = 30;
            Console.WriteLine(human.Hot);
            Console.WriteLine(human.Cold);
            Console.WriteLine(human.Fine);

        }
    }
}
