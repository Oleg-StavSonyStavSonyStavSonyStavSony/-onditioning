using System;

namespace core
{
    public class OutdoorUnit{
       // public bool On { get; set; }
        public bool Compressor { get; set; }
        public int VentilatorSpeed { get; set; }
        public int TemperatureSensor { get; set; }

        public OutdoorUnit(bool compressor, int ventelSpeed, int sensor) {
            Compressor = compressor;
            VentilatorSpeed = ventelSpeed;
            TemperatureSensor = sensor;
        }
    }
}