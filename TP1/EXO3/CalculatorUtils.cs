using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO3
{
    internal class CalculatorUtils
    {
        public static List<double> listPrix = new List<double>(3);
        
        public CalculatorUtils() {
            listPrix.Clear();

            listPrix.Add(0.5);
            listPrix.Add(0.25);
            listPrix.Add(0.1);
        }

        public double CalculerPrixAvecRemises(int nbrCoupies)
        {
            if( nbrCoupies <= 0)
                return 0;

            if (nbrCoupies <= 10)
                return listPrix[0] + CalculerPrixAvecRemises(nbrCoupies - 1);

            if (nbrCoupies <= 10 + 20)
                return listPrix[1] + CalculerPrixAvecRemises(nbrCoupies - 1);

            return listPrix[2] + CalculerPrixAvecRemises(nbrCoupies - 1);
        }
    }
}
