using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Övningar_26_28
{
   

    public class PersonClass
    {
        private string _FirstName;
        public string FirstName
        {
            get { return _FirstName; } set { _FirstName = value; }
        }

        private string _LastName;
        public string LastName
        {
            get { return _LastName; } set { _LastName = value; }
        }


        public readonly string Name;

        public readonly struct FullName
        {
            public readonly string Name;
            public FullName(string firstname, string lastname)
            {
                Name = firstname + " " + lastname;
            }
        }
    }

}

//public readonly struct Carstruct
//{
//    public readonly int TopSpeed;

//    public Carstruct(int topSpeed)
//    {
//        TopSpeed = topSpeed;
//    }
//}