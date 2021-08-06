using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    sealed class PhoneBook
    {
        public List<PhoneBookItem> PhoneBookEntries { get; set; }

        public PhoneBook()
        {
            PhoneBookEntries = new List<PhoneBookItem>();
        }
        public string GetPhoneBook()
        {
            string phonebook = "";
            // MB changed from string item to var item
            foreach (var item in PhoneBookEntries)
            {
                phonebook += item.GetContactSummary() + "\n\n";
            }
            return phonebook;
        }

    }
}
