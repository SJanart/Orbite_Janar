using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Orbite_Janar
{
    class Objet
    {
        private double _x;
        private double _y;
        private double _weight;

        public Objet(double x, double y, double weight)
        {
            _x = x;
            _y = y;
            _weight = weight;
        }

        public double X // la variable est accessible depuis n'importe quelle autre partie du code
        {
            get { return _x; }
        }

        public double Y
        {
            get { return _y; }
        }

        public double Weight
        {
            get { return _weight; }
        }
    }
}
