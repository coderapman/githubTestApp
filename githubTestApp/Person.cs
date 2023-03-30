using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace githubTestApp
{
    internal class Person
    {
        public string Name { get; set; }
        public string City { get; set; }

        public Person() 
        {
            this.Name = "Anja";
            this.City = "Herning";
        } 
    }
}
