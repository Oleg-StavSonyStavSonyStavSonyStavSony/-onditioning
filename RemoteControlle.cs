using System;

namespace core
{
    public class RemoteControlle{
       // public string Displey { get; set; }
        public int SetTemperature { get; set; }
        public IndoorUnit IndoorUnit { get; set; }
        public bool  Battery { get; set; }
        public Button ButtonOfOn { get; set; } 
        public Button ButtonTempUp { get; set; }
        public Button ButtonTempDown { get; set; }
        
        public RemoteControlle () {
            SetTemperature = 22;
            IndoorUnit = new IndoorUnit( 0, 0, false, false, false) ;
            Battery = true;
            ButtonOfOn = new Button  ("ButtonOfOn", false);
            ButtonTempUp = new Button("ButtonTempUp", false);
            ButtonTempDown = new Button("ButtonTempDown", false);
        }


        public void OnConditioningHot()
        {
            if (ButtonOfOn.Pressed == true)
            {
                IndoorUnit warmly = new IndoorUnit(3, 20, false, false, true);
                Console.WriteLine(warmly.OnWarmly());

            }
            else
            {
                if (Battery == true)
                {
                    Console.WriteLine("check the power 220v");
                }
                else
                {
                    Console.WriteLine("replace batteries AAA");
                }
            }
        }
        public void OnConditioningCold()
        {
            if (ButtonOfOn.Pressed == true)
            {
                IndoorUnit cold = new IndoorUnit(5, 25, false, true, false);
                Console.WriteLine(cold.OnCold());
            }
            else
            {
                if (Battery == true)
                {
                    Console.WriteLine("check the power 220v");
                }
                else
                {
                    Console.WriteLine("replace batteries AAA");
                }
            }
        }
    }
}