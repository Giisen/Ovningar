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

        //private readonly string _Name;
        // public string Name { get {return _Name;} }

        private readonly string _Name; //Värdet på denna readonly kan bara sättas via en kontruktor
        public string Name
        {
            get { return _Name; }
            
        }
        public string SetFullName(string firstname, string lastname) // Hämtar värdena från kontruktorn och returnerar 
        {
            FirstName = firstname;
            LastName = lastname;
            return FirstName + " " + LastName; 
        }

        public PersonClass(string firstname, string lastname) //Denna för att instatiera direkt när jag skapar ett nytt objekt.
        {
            
            _Name= SetFullName(firstname,lastname);
            
        }

        //public string FullName()
        //{
        //    _Name = FirstName + " " + LastName;
        //    return _Name;
        //}

    }
}
