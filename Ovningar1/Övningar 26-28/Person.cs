using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Övningar_26_28
{
    public class Person
    {
        string FirstName;
        string LastName;
        string Name;
    }

   public string FullName(string firstname, string lastName)
    {
        string Name = firstname + " " + lastName;
        return Name;
    }
}
