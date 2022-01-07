using System;
using System.Collections;

namespace PhoneBook.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }




        public Person(string f, string l, string pn, string ad)
        {
            string name = f;
            string family = l;
            string phone = pn;
            string address = ad;
        }

        public Person()
        {
        }

        internal static object Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }


   
}
