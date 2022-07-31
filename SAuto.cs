using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCar
{
    public class SAuto:Auto
    {
        public SAuto() { }
        public SAuto(string type, double aFuel, int ftank, double sp)
        {
            this.TyprTS = type;
            this.AveFuelCon = aFuel;
            this.FuelTank = ftank;
            this.Speed = sp;
        }
    }
}
