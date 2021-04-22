using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Contact
    {
        public Contact(string name, string number)
        {
            Name = name;
            Number = number;
        }
        
        public string Name { get; set; }
        
        [StringLength(9,
         ErrorMessage = "Number should have 9 numbers")]
        public string Number { get; set; }
    }
}
