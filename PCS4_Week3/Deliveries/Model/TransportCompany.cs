using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Deliveries.Model
{
    class TransportCompany
    {
        public TransportCompany()
        {
            People = new People();
            Deliverables = new Deliverables();
        }

        public People People { get; private set; }
        public Deliverables Deliverables { get; private set; }
        
        public Person FindPerson(int id)
        {
            foreach (Person p in People)
            {
                if (p.ID == id)
                {
                    return p;
                }
            }
            return null;
        }

        public void AddPerson(Person p)
        {
            if (FindPerson(p.ID) == null)
            {
                People.Add(p);
            }
            else
            {
                throw new Exception("Be aware: nothing is added!!!");
            }
        }

        public Deliverable FindDeliverable(int id)
        {
            foreach (Deliverable d in Deliverables)
            {
                if (d.ID == id)
                {
                    return d;
                }
            }
            return null;
        }

        public void AddDeliverable(Deliverable d)
        {
            if (FindDeliverable(d.ID) == null)
            {
                Deliverables.Add(d);
            }
            else
            {
                throw new Exception("Be aware: nothing is added!!!");
            }
        }

        public void LoadPersonsFromFile(string filename)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(new FileStream(filename, FileMode.Open, FileAccess.Read));
                this.People.Clear();
                String name, street, postalcode, city;
                int id, housenr;
                name = sr.ReadLine();
                while (name != null)
                {
                    street = sr.ReadLine();
                    housenr = Convert.ToInt32(sr.ReadLine());
                    postalcode = sr.ReadLine();
                    city = sr.ReadLine();
                    id = Convert.ToInt32(sr.ReadLine());
                    this.People.Add(new Person(id, name, street, housenr, postalcode, city));
                    name = sr.ReadLine();
                    name = sr.ReadLine(); //and again read a line, because of the delimiter between persons(line with the stars)
                }
            }
            catch (IOException) { }
            finally
            {
                if (sr != null) sr.Close();
            }
        }

        public void LoadDeliverablesFromFile(string filename)
        {
            foreach (var line in File.ReadAllLines(filename))
            {
                var fields = line.Split(' ');
                if (fields.Length == 3)
                {
                    var deliverable = new Deliverable(
                        Convert.ToInt32(fields[0]),
                        Convert.ToInt32(fields[1]),
                        People.FirstOrDefault(x => x.ID == Convert.ToInt32(fields[2]))
                    );
                    Deliverables.Add(deliverable);
                }
            };

            // Get all lines of text file
            // Loop over them ..
            //   -- split line in fields
            //   -- parse fields and create Deliverable
            //      -- find buyer in people collection
            //   -- add deliverable to collection
        }
    }
}
