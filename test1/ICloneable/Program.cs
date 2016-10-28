using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneable
{
        class Program
        {
            static void Main(string[] args)
            {
            Person p1 = new Person { Name = "Bill", Age = 34 };
            Person p2 = new Person { Name = "Tom", Age = 23 };
            Person p3 = new Person { Name = "Alice", Age = 21 };

            Person[] people = new Person[] { p1, p2, p3 };
            Array.Sort(people);

            foreach (Person p in people)
            {
                Console.WriteLine("{0} - {1}", p.Name, p.Age);
            }
           
            Console.Read();
            }
        }   
}
