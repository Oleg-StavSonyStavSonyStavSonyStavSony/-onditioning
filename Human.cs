using System;

namespace core
{
    public class Human {
        public string Name { get; set; }
        public RemoteControlle RemoteControlle { get; set; }
        public int RoomTemperature { get; set; }
        private bool cold;
        public bool Cold
        {
            get { return cold; }
            set {
                if (RoomTemperature < 18)
                { value = true; }
                else { value = false; }
            }
        }

        private bool fine;
        public bool Fine
        {
            get { return fine; }
            set
            {
                if (RoomTemperature == 22)
                { value = true; }
                else { value = false; }
            }
        }

        private bool hot;
        public bool Hot
        {
            get { return hot; }
            set
            {
                if (RoomTemperature > 25)
                { value = true; }
                else { value = false; }
            }
        }
        private Human() { }
        public Human(string name, int roomTemperature)
        {
            this.Name = name;
            this.RoomTemperature = roomTemperature;
            RemoteControlle = new RemoteControlle();
        }
        public void StatusCheckTemp()
        {
            if (RoomTemperature < 18)
            { cold = true; }
            else if ( RoomTemperature > 25 )
            { hot = true; }
            else { fine = true; }
        }

        public void MakeComfortable() {
            if (cold == true)
            { 

            }
            else if (hot == true)
            {
                RemoteControlle.ButtonOfOn.Pressed = true;
                RemoteControlle.OnConditioning();

            }
            else { Console.WriteLine($" person {Name} is comfortableright temperature is not needed"); }

        }







    }

}