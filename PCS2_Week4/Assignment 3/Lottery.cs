using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Lottery
    {

        public List<int> listOfDrawnNumbers = new List<int>();

        Random random = new Random();

        public int MaxValue { get; set; }

        public int NrOfDrawnNumbers { get; set; }

        public int NrOfWantedNumbers { get; set; }

        public bool DrawingIsOver { get; set; }

        int[] array;

        public Lottery(int maxValue, int nrOfWantedNumbers)
        {
            array = new int[maxValue];
            for (int i = 0; i < maxValue; i++)
            {
                array[i] = random.Next(1, 100);
            }
        }

        public void DrawAllNumbers() 
        {
            for (int i = 0; i < NrOfWantedNumbers; i++)
            {
                listOfDrawnNumbers.Add(array.ElementAt(random.Next(0, MaxValue)));
            }
        } 

        public void Draw1Number()
        {
            int result = array.ElementAt(random.Next(0, MaxValue + 1));
            listOfDrawnNumbers.Add(result);
        }
    }
}
