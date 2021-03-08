using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Company(string Name)
        {
            this.Name = Name;
        }
    }
}