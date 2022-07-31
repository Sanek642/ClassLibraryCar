using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCar
{
    public class LAuto : Auto
    {
        private int passager;
        public int Passager {
            get => passager;
            set => passager = value > 1 && value <= 9 ? value : throw new Exception("Число пассажиров может быть от 1 до 9!");
        }
        public LAuto() { }
        public LAuto(string type, double aFuel, int ftank, double sp, int pas)
        {
            this.TyprTS = type;
            this.AveFuelCon = aFuel;
            this.FuelTank = ftank;
            this.Speed = sp;
            this.Passager = pas;
        }

        public override void PotPath(double? curFuel = null, int? passeger = null, int? cargo = null)
        {
            if (passeger > this.Passager)
            {
                throw new Exception($"Количество пассажиров не может привышать {Passager}!");
            }
            else
            {
               base.PotPath(curFuel, passeger, cargo);
            }
        }
    }
}
