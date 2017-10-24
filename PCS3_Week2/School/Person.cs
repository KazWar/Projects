using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int PCN { get; set; }
        public int Age { get; set; }

        private int yearsAtFontys;
        public int YearsAtFontys
        {
            get { return yearsAtFontys; }
            private set
            {
                if (value >= 0)
                {
                    yearsAtFontys = value;
                }
                else
                {
                    yearsAtFontys = 0;
                }
            }
        }

        public Person(string name, int pcn, int age, string address)
        {
            Name = name;
            PCN = pcn;
            Age = age;
            Address = address;
        }

        public virtual void StartAnotherSchoolYear()
        {
            YearsAtFontys++;
        }

        public void CelebrateBirthday()
        {
            Age++;
        }
        public virtual string InfoString()
        {
            string information = string.Format($"{Name} | ({PCN}) | Age {Age} | {YearsAtFontys} years at Fontys |");
            return information;
        }
    }
}
