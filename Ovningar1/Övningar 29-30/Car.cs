using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningar_29_30
{
    public class Car
    {
        private int _color;
        public int Color
        {
            get { return _color; }
            set { _color = value; }
        }

        private int _lenght;
        public int Lenght
        {
            get { return _lenght; }
            set { _lenght = value; }
        }

      static Array values = Enum.GetValues(typeof(ColorEnum));
       static Random random = new Random();
       public int ColorRand = (int)values.GetValue(random.Next(values.Length));

        public enum ColorEnum
        {
            White,
            Black,
            Red,
            Green,
            Blue,
            Yellow,
            Silver,
            PerlPink,
            RadientRouege,

        };

        public enum LenghtEnum
        {
            Three,
            ThreeHalf,
            four,
            fourHalf,
            five,
        };

        public Car(int ColorRand, int lenght)
        {
            
            Color=ColorRand;
            Lenght = lenght;
        }

    }
}
