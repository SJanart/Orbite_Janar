using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Orbite_Janar
{
    class Position
    {
        private double x;
        private double y;

        public Position(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double GetX()
        {
            return x;
        }

        public double GetY()
        {
            return y;
        }

        public string AffichePosition()
        {
            return "x:" + x + "km" + " y:" + y + "km";
        }
    }
}
