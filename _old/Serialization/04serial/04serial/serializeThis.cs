using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04serial
{
    [Serializable]
    public class serializeThis
    {
        private string _name;
        private double _weight;
        private double _size;
        private string _color;

        public string Name { get => _name; set => _name = value; }
        public double Weight { get => _weight; set => _weight = value; }
        public double Size { get => _size; set => _size = value; }
        public string Color { get => _color; set => _color = value; }

        public serializeThis()
        {}
        public serializeThis(string name, double weight, double size, string color)
        {
            this.Name = name;
            this.Weight = weight;
            this.Size = size;
            this.Color = color;
        }       
    }
}
