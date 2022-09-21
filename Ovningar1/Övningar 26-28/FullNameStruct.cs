using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningar_26_28
{

    public readonly struct FullNameStruct
    {
        public readonly string Name;

        public FullNameStruct(string FirstName, string LastName)
        {
            Name = (FirstName + " " + LastName);

        }
    }
}
