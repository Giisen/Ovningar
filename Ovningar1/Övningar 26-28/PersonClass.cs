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
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public PersonClass(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        public PersonClass()
        {
            _Name = FirstName + " " + LastName;
            

        }
    }
}
