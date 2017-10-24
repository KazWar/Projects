using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Teacher : Person
    {
        public decimal Salary { get; set; }

        public Function Function{ get; set; }

        public Teacher(string name, int pcn, int age, decimal salary) : base(name, pcn, age)
        {
            Salary = salary;
            Function = Function.DOCENT_1;
        }

        public void MakePromotion()
        {
            if (Function != Function.DIRECTOR)
            { 
                Function++;
            }
        }

        public override void AnotherSchoolYear()
        {
            base.AnotherSchoolYear();
            if (base.YearsAtFontys % 3 == 0)
            {
                this.Salary *= 1.1m;
            }
        }

        public override string InfoString()
        {
            string TempString = string.Format($" Function: {Function} | Salary: {Math.Round(Salary,2)}");
            return base.InfoString() + TempString;
        }
    }
}
