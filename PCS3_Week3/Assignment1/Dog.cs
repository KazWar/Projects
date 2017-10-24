using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Dog : ISomeone
    {
        public int Age { get; set; }

        public Dog(int Age)
        {
            Age = this.Age;
        }

        string ISomeone.IntroduceYOurself()
        {
            string text = "Waf! I am  " + (Age * 7) + " years old!";
            return text;
        }

        string ISomeone.SayGoodMorning(int weekday)
        {
            string text = "Waf, wake up, take me out for a walk!";
            return text;
        }

        string ISomeone.SayGoodNight(int hour)
        {
            string text;
            if ( hour > 23)
            {
                text = "Waf, I want to sleep in your bed!";
            } else
            {
                text = "Waf, wake up, take me out for a walk!";
            }
            return text;
        }
    }
}
