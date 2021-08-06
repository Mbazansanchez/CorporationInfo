using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    //MB needed to change class to interface
    interface PhoneBookItem
    {
        //MB removed public 
        string GetContactSummary();
    }
}
