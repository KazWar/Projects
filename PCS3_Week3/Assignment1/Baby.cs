using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Baby : ISomeone
    {
        public string Name { get; set; }

        public Baby(string Name)
        {
            this.Name = Name;
        }

        string ISomeone.IntroduceYOurself()
        {
            return Name;
        }

        string ISomeone.SayGoodMorning(int weekday)
        {
            string text = "UUUU " + Name + " is hungry!";
            return text;
        }

        string ISomeone.SayGoodNight(int hour)
        {
            string text = "UUUU " + Name + " is hungry!";
            return text;
        }
    }

}
