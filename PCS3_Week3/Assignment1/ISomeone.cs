using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public interface ISomeone
    {
        string IntroduceYOurself();
        string SayGoodMorning(int weekDay);
        string SayGoodNight(int hour);
    }
}
