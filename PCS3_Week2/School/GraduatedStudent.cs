using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class GraduatedStudent : Person
    {

        public int YearOfGraduation { get; set; }
        public double GraduationMark { get; set; }

        public GraduatedStudent(string name, int pcn, int age, string address, int yearOfGraduation, double graduationMark) :base(name, pcn, age, address)
        {
            YearOfGraduation = yearOfGraduation;
            GraduationMark = graduationMark;
        }
    }
}
