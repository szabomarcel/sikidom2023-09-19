using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidom
{
    abstract class Kor : Sikidom
    {
        public double Sugar;        
        public Kor(double parameter1) : base("Kör", parameter1, 0)
        {
            this.Sugar = parameter1;
        }
        public double korTerulet() { return (2 * this.Sugar) * Math.PI; }
        public double korKerulet() { return (this.Sugar * this.Sugar) * Math.PI; }
    }
}
