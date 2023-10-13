using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    internal class User : Admin
    {
        public int Balance { get; set; }
        public string PhoneNumber { get; set; }
        

        public override string ToString()
        {
            return $"{Id} - {Name} - {LastName} - {PhoneNumber} - {Login} - {Password} - {Balance}";
        }

    }
}
