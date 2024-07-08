using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10._1
{
    internal class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Phone {  get; set; }
        public int ID { get; set; }

        public Customer(string firstName, string lastName, string email, int phone, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            ID = id;
            Console.WriteLine($"{firstName} {lastName} added");
        }

    }
}
