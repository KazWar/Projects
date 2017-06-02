using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class TrafficLight
    {
        // Initiliaze list of traffic light colors
        List<ColorDefinition> listOfColors = new List<ColorDefinition>()
        {
            new ColorDefinition() { Name = "Green", Color = Color.Green },
            new ColorDefinition() { Name = "Orange", Color = Color.Orange },
            new ColorDefinition() { Name = "Red", Color = Color.Red }
        };

        private int size;

        public int Size {
            get { return size; }
            set
            {
                if (value >= 5 && value <= 75)
                {
                    size = value;
                }
            }
        }

        public string Name { get; set; }

        //Constructors
        public TrafficLight()
        {
        }

        //Methods
        public void Draw (Graphics graphics)
        {
            var x = 10;
            var y = 0;
            foreach (ColorDefinition item in listOfColors)
            {
               var myBrush = new SolidBrush(item.Color);
               graphics.FillEllipse(myBrush, x, y, size, size);
                y += size + 10;
            }
        }

    }
}
