using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaibhav_assignment.Classes
{
    public class Exercise2Cls
    {
        public Exercise2Cls()
        {
        }


        public void CompareObjects()
        {
            try
            {
                person p1 = new person() { Age = 1 , Name="V"};
                person p2 = new person() { Age = 1 , Name="V"};

                Console.WriteLine("P1 and P2 are two new instance");
                Console.WriteLine(ReferenceEquals(p1, p2));
                Console.WriteLine(p1.Equals(p2));
                Console.WriteLine(p1 == p2);

                Console.WriteLine("P1=P2");
                p2 = p1;
                Console.WriteLine(ReferenceEquals(p1, p2)); //false

                Console.WriteLine(p1.Equals(p2)); //false

                Console.WriteLine(p1 == p2);

                Console.WriteLine("P1 is null");
                p1 = null;
                Console.WriteLine(ReferenceEquals(p1, p2)); //false

                Console.WriteLine(p1 == p2);

                Console.WriteLine(p2.Equals(p1)); //false

                Console.WriteLine(p1.Equals(p2)); //false

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
    public class person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
