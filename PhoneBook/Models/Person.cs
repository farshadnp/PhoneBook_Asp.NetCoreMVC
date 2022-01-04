using System.Collections;

namespace PhoneBook.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public Person(string f, string l)
        {
            Name = f;
            Family = l;
        }

        public Person(string f, string l, string pn, string add)
        {
            Name =f;
            Family = l;
            PhoneNumber = pn;
            Address = add;
        }

    }

}
