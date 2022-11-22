using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningar_29_30
{
    public class Car
    {
        private ColorEnum _color;

        public ColorEnum Color
        {

            get { return _color; }
            set { _color = value; }
        }

        private LengthEnum _length;

        public LengthEnum Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public Car()
        {
            Color = ColorIntRand;
            Length = LengthIntRand;
        }

        // Skapar en random färg från ColorEnum
        static Array values = Enum.GetValues(typeof(ColorEnum));
        static Random random = new Random();
        public ColorEnum ColorIntRand = (ColorEnum)values.GetValue(random.Next(values.Length));

        // Skapar en random längd från LengthEnum
        static Array values1 = Enum.GetValues(typeof(LengthEnum));
        static Random random1 = new Random();
        public LengthEnum LengthIntRand = (LengthEnum)values1.GetValue(random.Next(values1.Length));



        public enum ColorEnum
        {
            RubyRed = 0,
            GrassGreen = 1,
            BabyBlue = 2,
            MellowYellow = 3,
            SpeedySilver = 4,
            PerlPink = 5,
            RadiantRouge = 6,

        };

        public enum LengthEnum
        {
            
            Three= 3,
            Four = 4,
            Five = 5,
        };


        


        // För övning 32
        public static void  CarArray(Car car, out Car silvercar)
        {
           
            Car[] silvercar = new Car[10];
           
            for (int i = 0; i < 10; i++)
            {
                
                car[i];

            }

            
        }

        
    }
}


/*  var distinktLista = CartList.Select(p => p.ProduktNamn).Distinct(); //Tar ut distinkta produktnamn.

        stringKundvagn += ("\nProdukter:\n");
        foreach (var prod in distinktLista)
        {
            var produkter = CartList.FirstOrDefault(p => p.ProduktNamn == prod);
            antProd = CartList.Where(p => p.ProduktNamn == prod).Sum(p => p.Antal);
*/