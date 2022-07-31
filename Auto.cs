namespace ClassLibraryCar
{
    public abstract class Auto
    {
        private const int loadPas = 6;
        private const int loadCargo = 4;

        private double aveFuelCon;
        private int fuelTank;
        private double speed;

        public string? TyprTS { get; set; }
        public double AveFuelCon
        {
            get => aveFuelCon;
            set => aveFuelCon = value > 0 && value <= 50 ? value : throw new Exception("Средний расход топлива может быть в пределах от 0(не включая) до 50");
        }
        public int FuelTank
        {
            get => fuelTank;
            set => fuelTank = value >= 3 && value <= 2000 ? value : throw new Exception("Объем бака топлива может быть в пределах от 3 до 2000");
        }
        public double Speed
        {
            get => speed;
            set => speed = value >= 0 && value <= 1228 ? value : throw new Exception("Cкорость атомобиля может быть в пределах от 0 до 1228");
        }

        public double Path(double? curFuel=null)
        {
            if (curFuel > FuelTank)
            {
                throw new Exception($"Топлива в баке не может быть больше чем объем бака {FuelTank}!");
            }
            else
            {
                return Math.Round(((curFuel??FuelTank)/AveFuelCon)*100,2);
            }

        }

        virtual public void PotPath(double? curFuel = null, int ? passeger=null, int? cargo = null)
        {
            double path = this.Path(curFuel);
            double pathPas = (path / 100) * loadPas * (passeger??0);
            double pathCargo = (path / 100) * loadCargo * ((cargo??0)/200);
            Console.WriteLine("Запас хода: "+Math.Round(path - pathPas - pathCargo,2));
        }

        public void TimePath(double tpath = 0, double? curFuel = null)
        {
            double path = this.Path(curFuel);
            if (tpath > path)
            {
                throw new Exception($"Необходимо дополнительное топливо, с текущим запасом автомобиль проедет {path} км.!");
            }
            else
            {
                var time = TimeSpan.FromSeconds((tpath*1000)/(Speed*1000/3600));
                Console.WriteLine($"Автомобиль проедет расстояние {tpath} за {time.Hours} ч. {time.Minutes} м.");
            }

        }




    }
}