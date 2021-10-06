using System;

namespace core
{
    class TemperatureSensor{
        public int DegreeCelsius { get; set; }

        public TemperatureSensor() { }

        public bool OfCompressor(int tempIndoor, int tempOutdoor) {
            if (tempOutdoor < 5 && tempIndoor < 15)
            {
                return true;
            }
            else {
                return false;
            }
        }


    }
    
}