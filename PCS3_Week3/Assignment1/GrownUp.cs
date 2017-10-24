using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class GrownUp : ISomeone
    {
        public string Name { get; set; }

        public GrownUp(string Name)
        {
            this.Name = Name;
        }

        string ISomeone.IntroduceYOurself()
        {
            return Name;
        }

        string ISomeone.SayGoodMorning(int weekday)
        {
            string text;
            if (weekday < 6)
            {
                text = "Oh no " + Name + " is late for work!.";
            } else
            {
                text = "Go away, " + Name + " wants to sleep some more!";
            }
            return text;
        }

        string ISomeone.SayGoodNight(int hour)
        {
            string text;
            if (hour > 23)
            {
                text = Name + " will have troubles getting up in the morning!";
            }
            else
            {
                text = Name + " managed for once to go to sleep on time!";
            }
            return text;
        }
    }
}
