using System;

namespace core
{
    public class IndoorUnit{
        public bool On { get; set; }
       // public string Displey { get; set; }
        public int Ventilator { get; set; }
        public int TemperatureSensor { get; set; }
        public bool ModeVentilation { get; set; }
        public bool ModeCold { get; set; }
        public bool ModeWarmly { get; set; }
        public IndoorUnit(bool on, int ventilator, int temperatuereSensor, bool modelVentelation, bool modeCold, bool modeWarmly) {
            On = on;
            Ventilator = ventilator;
            TemperatureSensor = temperatuereSensor;
            ModeVentilation = modelVentelation;
            ModeCold = modeCold;
            ModeWarmly = modeWarmly;
        }

        

    }
}