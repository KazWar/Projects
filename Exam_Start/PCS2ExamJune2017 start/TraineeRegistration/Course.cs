using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeRegistration
{
    public class Course
    {
        public string CourseCode { get; set; }
        public CourseLevels CourseLevel { get; set; }
        public enum CourseLevels
        {
            BEGINNER,
            INTERMEDIATE,
            ADVANCED
        }

        public Course(string courseCode, CourseLevels courseLevel)
        {
            CourseCode = courseCode;
            CourseLevel = courseLevel;
        }

        public decimal GetPrice(CourseLevels courseLevel)
        {
            decimal price;
            switch (courseLevel)
            {
                case CourseLevels.BEGINNER:
                    price = 400m;
                    return price;
                case CourseLevels.INTERMEDIATE:
                    price = 500m;
                    return price;
                case CourseLevels.ADVANCED:
                    price = 600m;
                    return price;
                default:
                    price = 0;
                    return price;
            }
        }

        public string AsString()
        {
            return this.CourseCode + " ,Level " + this.CourseLevel + " ,Price " + GetPrice(CourseLevel) + " Euros";
        }
    }
}
