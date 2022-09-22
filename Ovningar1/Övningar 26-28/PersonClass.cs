using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public string Name { get; set; }

        //private string _Name;
        //public string Name
        //{
        //    get { return _Name; }
        //    set { _Name = value; }
        //}

        public PersonClass(string firstname, string lastname) //Denna för att instatiera direkt när jag skapar ett nytt objekt.
        {
            FirstName = firstname;
            LastName = lastname;
        }

        public string FullName()
        {
            Name = FirstName + " " + LastName;
            return Name;
        }

    }
}
