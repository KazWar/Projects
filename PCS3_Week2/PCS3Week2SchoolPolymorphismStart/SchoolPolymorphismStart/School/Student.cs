using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student : Person
    {
        public string Country { get; set; }
        public int EC { get; set; }

        public Student(string name, int pcn, int age, string country) : base(name, pcn, age)
        {
            Country = country;
            EC = 0;
        }


        public void AddOneModuleEC()
        {
            EC += 3;
        }

        public override string InfoString()
        {
            string TempString = string.Format($" Country: {Country} | EC's: {EC}");
            return base.InfoString() + TempString;
        }
    }
}
