using System;

namespace core
{
    class Application
    {


       public void Strart()
       {
            Human human = new Human("Ivan", 26);
            human.StatusCheckTemp();
            Console.WriteLine($"RoomTemperature - " + human.RoomTemperature +"\n" + human.Name  + "( hot " + human.Hot +")," + "( cold " + human.Cold + "),"+ "( fine " + human.Fine + ")");
            human.MakeComfortable();

            Console.WriteLine("change the temperature?");
            Console.WriteLine("press the (\"u\"- up) or (\"d\"- down) arrow");
            char x = Console.ReadLine()[0];
            do
            {
                x = Console.ReadLine()[0];
                Console.WriteLine(x);

                if (x == 'u')
                {
                    human.RoomTemperature++;
                    human.StatusCheckTemp();
                    Console.WriteLine($"RoomTemperature - " + human.RoomTemperature + "\n" + human.Name + "( hot " + human.Hot + ")," + "( cold " + human.Cold + ")," + "( fine " + human.Fine + ")");
                    human.MakeComfortable();
                }
                else if (x == 'd') {
                    human.RoomTemperature--;
                    human.StatusCheckTemp();
                    Console.WriteLine($"RoomTemperature - " + human.RoomTemperature + "\n" + human.Name + "( hot " + human.Hot + ")," + "( cold " + human.Cold + ")," + "( fine " + human.Fine + ")");
                    human.MakeComfortable();
                }
            }

            while (x == 'u' && x == 'd');





            

        }
    }
}
