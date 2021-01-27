using System;

namespace CS1405_Lab
{
    public class Base
    {
        public string Name { get; set; }

        public override string Name                                         
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }

            set
            {
                FirstName = names[0];
                LastName = names[1];
            }
        }
    }
    public class Contact : Base
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Contact contact;
            Base item;

            contact = new Contact();
            item = contact;

            item.Name = "Billy Bob";

            Console.WriteLine($"{ contact.FirstName } { contact.LastName }");
        }
    }
}
