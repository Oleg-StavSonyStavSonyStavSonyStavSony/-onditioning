using System;

namespace core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human human = new Human("Ivan", 20);
            human.StatusCheckTemp();
            human.MakeComfortable();
            //Console.WriteLine(human.Hot);
            //Console.WriteLine(human.Cold);
            //Console.WriteLine(human.Fine);

        }
    }
}
