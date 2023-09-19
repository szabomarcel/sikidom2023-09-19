using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidom
{
    internal class Kor : Sikidom
    {
        public double Sugar;        
        public Kor( double parameter1) : base("Kör", parameter1, 0)
        {
            this.Sugar = parameter1;
        }
        public double Terulet() { return (2 * Sugar) * Math.PI; }
        public double Kerulet() { return (Sugar * Sugar) * Math.PI; }
    }
}
