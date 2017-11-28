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
        private People people;
        private Deliverables deliverables;

        public TransportCompany()
        {
            this.people = new People();
            this.deliverables = new Deliverables();
        }

        public People People { get { return this.people; } }
        public Deliverables Deliverables { get { return this.deliverables; } }
        
        public Person FindPerson(int id)
        {
            foreach (Person p in this.people)
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
            if (this.FindPerson(p.ID) == null)
            {
                this.people.Add(p);
            }
            else
            {
                throw new Exception("Be aware: nothing is added!!!");
            }
        }

        public Deliverable FindDeliverable(int id)
        {
            foreach (Deliverable d in this.deliverables)
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
                deliverables.Add(d);
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
                this.people.Clear();
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
                    this.people.Add(new Person(id, name, street, housenr, postalcode, city));
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
            List<string> Lines = new List<string>();

            using (var stream = new FileStream(filename, FileMode.Open))
            {
                using (var reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        int id, weight, buyerID;
                        var line = reader.ReadLine();
                        Lines.Add(line);

                        foreach (string dataLine in Lines)
                        {
                            string[] splitLines = dataLine.Split(' ');
                            
                            id = Convert.ToInt32(splitLines[0]);
                            weight = Convert.ToInt32(splitLines[1]);
                            buyerID = Convert.ToInt32(splitLines[2]);
                            Person selectedPerson = people.FirstOrDefault(x => x.ID == buyerID);

                            deliverables.Add(new Deliverable(id, weight, selectedPerson));   
                        }
                    }
                }
            }
        }



        /// <summary>
        /// SortByWeight sorts the elements of the deliverables-list from a low weight to a high weight.
        /// </summary>
        public void SortByWeight()
        {
        }

        /// <summary>
        /// SortByName sorts the elements of the deliverables-list alfabetically by buyer's name.
        /// </summary>
        public void SortByName()
        {
            //todo

        }

        /// <summary>
        /// SortById sorts the elements of the deliverables-list from a low id to a high id.
        /// </summary>
        public void SortById()
        {
            //todo

        }

        /// <summary>
        /// SortByAddress sorts the elements of the deliverables-list "alfabetically by street; then by increasing house-number".
        /// So elements with a different street are sorted alfabetically by street.
        /// Elements with the same street are sorted by increasing house-number. 
        /// </summary>
        public void SortByAddress()
        {
            //todo

        }

        /// <summary>
        /// SortForPostman sorts the elements of the deliverables-list alfabetically by street,
        /// then by postman-ordered house-numbers.
        /// The postman walks along the street, first the side of the street with the odd numbers (in an increasing order),
        /// then back on the other side of the street for the even house-numbers (in a decreasing order). 
        /// </summary>
        public void SortForPostman()
        {
            //todo

        }

        
    }
}
