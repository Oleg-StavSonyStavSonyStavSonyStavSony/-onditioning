using System;

namespace core
{
    public class IndoorUnit{
        //public bool On { get; set; }
       // public string Displey { get; set; }
        public int Ventilator { get; set; }
        public int TemperatureSensor { get; set; }
        public bool ModeVentilation { get; set; }
        public bool ModeCold { get; set; }
        public bool ModeWarmly { get; set; }
        public OutdoorUnit OutdoorUnit { get; set; }
        public IndoorUnit( int ventilator, int temperatuereSensor, bool modelVentelation, bool modeCold, bool modeWarmly) {
            //On = on;
            Ventilator = ventilator;
            TemperatureSensor = temperatuereSensor;
            ModeVentilation = modelVentelation;
            ModeCold = modeCold;
            ModeWarmly = modeWarmly;
        }
        public string OnWarmly()
        {
            OutdoorUnit outdoorUnit = new OutdoorUnit(true,5,30);
            string srrt = "Ventilator speed - " + Ventilator + "\n"+ "TemperatureSensor - " + TemperatureSensor + "\n" +
            "ModeWarmly - " + ModeWarmly + "\n" + "outside temperature - " + outdoorUnit.TemperatureSensor + " C" +"\n"+"\n";

            return srrt;
        }

        public string OnCold()
        {
            OutdoorUnit outdoorUnit = new OutdoorUnit(true, 5, 10);
            string srrt = "Ventilator speed - " + Ventilator + "\n" + "TemperatureSensor - " + TemperatureSensor + "\n" +
            "ModeWarmly - " + ModeCold + "\n" + "outside temperature - " + outdoorUnit.TemperatureSensor + " C" + "\n" + "\n";
            return srrt;
        }
        public string OnVentilation()
        {
            OutdoorUnit outdoorUnit = new OutdoorUnit(true, 5, 18);
            string srrt = "Ventilator speed - " + Ventilator + "\n" + "TemperatureSensor - " + TemperatureSensor + "\n" +
            "ModeWarmly - " + ModeVentilation + "\n" + "outside temperature - " + outdoorUnit.TemperatureSensor + " C" + "\n" + "\n";
            return srrt;
        }

    }
}