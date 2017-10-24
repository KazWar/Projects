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

        public Student(string name, int pcn, int age, string country, string address) : base(name, pcn, age, address)
        {
            Country = country;
        }

        public void AddOneModuleEC()
        {
            EC += 3;
        }

        public override string InfoString()
        {
            string TempString = string.Format($"Country: {Country} | EC's: {EC}");
            return base.InfoString() + TempString;
        }
    }
}

// SERIALIZATION EXPLAINED:
// Object in memory in C# native format => serialization => XML => send over HTTP => XML => deserialization => Object in memory in Java native format
// Object in memory in C# native format => serialization => JSON => save to disk => load from disk => JSON => deserialization => Object in memory in C# native format

