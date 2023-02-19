using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool IsProtected { get; set; }
        public string Type { get; set; }
        public bool IsDiurnal { get; set; }
        public string FeatherType { get; set; }
        
        public Bird()
        {

        }

        public Bird(string name, int age, int legs, bool hasBackbone, bool isProtected, string type, bool isDiurnal, string featherType)
        {
            Name = name;
            Age = age;
            Legs = legs;
            HasBackbone = hasBackbone;
            Type = type;
            IsProtected = isProtected;
            FeatherType = featherType;
            IsDiurnal = isDiurnal;
        }
    }
}
