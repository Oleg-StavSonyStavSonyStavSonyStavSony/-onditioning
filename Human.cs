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

        private bool hot = true;
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

        public void MakeCold() {
            RemoteControlle.ButtonOfOn.Pressed = true;
        }







    }

}