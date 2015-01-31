using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Model
{
    [Serializable]
    public class Tamagotchi
    {
        public  int Fuerza { get; set; }
        public int Destreza { get; set; }
        public int Inteligencia { get; set; }
        public int Carisma { get; set; }
        public int Suerte { get; set; }
    }
}
