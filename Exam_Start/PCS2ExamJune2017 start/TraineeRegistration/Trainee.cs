using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeRegistration
{
    public class Trainee
    {
        public string Name { get; set; }
        private int age;
        private List<Course> MyCourses;

        // PROPERTIES
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 18)
                {
                    this.age = 18;
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public Trainee (string name, int age)
        {
            Name = name;
            if (age < 18)
            {
                Age = 18;
            } else
            {
                Age = age;
            }

            MyCourses = new List<Course>();
        }

        public List<Course> GetAllCourses()
        {
            return this.MyCourses;
        }

        public bool RegisterForCourse(string courseCode, Course.CourseLevels courseLevel)
        {
            if (MyCourses.Exists(x => x.CourseCode == courseCode))
            {
                return false;
            }
            else
            {
                var Course = new Course(courseCode, courseLevel);
                MyCourses.Add(Course);
                return true;
            }
        }

        public bool ChangeCourse(string courseCode, Course.CourseLevels courseLevel)
        {
            if (MyCourses.Exists(x => x.CourseCode == courseCode))
            {
                var course = MyCourses.Find(x => x.CourseCode == courseCode);
                course.CourseLevel = courseLevel;
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<Course> GetAllBeginnerCourses()
        {
            var BeginnerCourses = MyCourses.Where(x => x.CourseLevel == Course.CourseLevels.BEGINNER).ToList();
            return BeginnerCourses;
        }
    }
}
