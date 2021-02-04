using System;

namespace Aula_123.Entities
{
    class Client
    {
        //Attributes
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        //Constructors
        public Client()
        {
        }

        public Client(string name, string email, DateTime birthdate)
        {
            Name = name;
            Email = email;
            BirthDate = birthdate;
        }

        //Methods

        public override string ToString()
        {
            return Name
                +" ("
                +BirthDate
                +") - "
                +Email;
        }
    }
}
