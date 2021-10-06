using System;

namespace core
{
   public class Button{
        public string  Name { get; set; }
        public bool Pressed { get; set; }
        public Button(string name, bool pressed) {
            Name = name;
            Pressed = pressed;
        }
    }
    
}