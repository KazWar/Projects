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
        public TrafficLight(string name, int size)
        {
            Size = size;
            Name = name;
        }

        //Methods
        public void Draw (Graphics graphics)
        {
            var x = 10;
            var y = 0;

            var myPenRed = new Pen(listOfColors.ElementAt(0).Color);
            var myPenOrange = new Pen(listOfColors.ElementAt(1).Color);
            var myPenGreen = new Pen(listOfColors.ElementAt(2).Color);

            var myBrush = new SolidBrush(listOfColors.ElementAt(StoplightsControl.activeLight).Color);

            switch (StoplightsControl.activeLight)
            {
                case 0:
                    graphics.FillEllipse(myBrush, x, y, size, size);
                    y += size + 10;
                    graphics.DrawEllipse(myPenOrange, x, y, size, size);
                    y += size + 10;
                    graphics.DrawEllipse(myPenGreen, x, y, size, size);
                    y += size + 10;
                    break;
                case 1:
                    graphics.DrawEllipse(myPenRed, x, y, size, size);
                    y += size + 10;
                    graphics.FillEllipse(myBrush, x, y, size, size);
                    y += size + 10;
                    graphics.DrawEllipse(myPenGreen, x, y, size, size);
                    y += size + 10;
                    break;
                case 2:
                    graphics.DrawEllipse(myPenRed, x, y, size, size);
                    y += size + 10;
                    graphics.DrawEllipse(myPenOrange, x, y, size, size);
                    y += size + 10;
                    graphics.FillEllipse(myBrush, x, y, size, size);
                    y += size + 10;
                    break;
                default:
                    break;
            }
        }
    }
}
