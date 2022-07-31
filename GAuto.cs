using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCar
{
    public class GAuto:Auto
    {
        private int cargo;
        public int Cargo
        {
            get => cargo;
            set => cargo = value > 500 && value <= 5000 ? value : throw new Exception("Грузоподъемность может быть от 500 до 5000 кг.!");
        }
        public GAuto() { }
        public GAuto(string type, double aFuel, int ftank, double sp, int carg)
        {
            this.TyprTS = type;
            this.AveFuelCon = aFuel;
            this.FuelTank = ftank;
            this.Speed = sp;
            this.Cargo = carg;
        }

        public override void PotPath(double? curFuel = null, int? cargo = null, int? passeger = null)
        {
            if (cargo > this.Cargo)
            {
                throw new Exception($"Масса груза не может привышать {Cargo}!");
            }
            else
            {
                base.PotPath(curFuel, passeger, cargo);
            }
        }
    }
}
