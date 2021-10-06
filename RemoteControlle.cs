using System;

namespace core
{
    public class RemoteControlle{
       // public string Displey { get; set; }
        public int SetTemperature { get; set; }
        public bool  Battery { get; set; }
        public Button ButtonOfOn { get; set; } 
        public Button ButtonTempUp { get; set; }
        public Button ButtonTempDown { get; set; }
        
        public RemoteControlle () {
            SetTemperature = 22;
            Battery = true;
            ButtonOfOn = new Button  ("ButtonOfOn", false);
            ButtonTempUp = new Button("ButtonTempUp", false);
            ButtonTempDown = new Button("ButtonTempDown", false);
        }

        public void OnConditioning()
        {
            if(ButtonOfOn.Pressed == true)
            {



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