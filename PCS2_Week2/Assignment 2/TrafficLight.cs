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
        List<TColor> listOfColors = new List<TColor>()
        {
            new TColor(){ Name = "Green", Color = Color.Green },
            new TColor(){ Name = "Orange", Color = Color.Orange },
            new TColor(){ Name = "Red", Color = Color.Red }
        };

        private int size;

        public int Size {
            get { return size; }
            set
            {
                if (value >= 5 || value <= 75)
                {
                    value = size;
                }
            }
        }

        public string Name { get; set; }

        //Constructors
        public TrafficLight()
        {
        }

        //Methods
        public void Draw (Graphics gr)
        {
            foreach (TColor item in listOfColors)
            {
               var myBrush = new SolidBrush((Color.FromName(item.Color.ToString())));
               gr.FillEllipse(myBrush, 10, 10 + 2 * size, size, size);
            }
        }
    }
}
