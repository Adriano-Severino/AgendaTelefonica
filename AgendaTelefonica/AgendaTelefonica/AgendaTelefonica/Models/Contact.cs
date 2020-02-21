using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaTelefonica.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Tel { get; set; }
        public override string ToString()
        {
            return $"({Id}) {Name}, {Tel}";
        }
    }
}
