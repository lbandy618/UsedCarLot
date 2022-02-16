using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarLot
{
    internal class UsedCar : Car
    {
        double Milage { get; set; }

        public UsedCar(string _make, string _model, int _year, decimal _price, double _milage) : base(_make, _model, _year, _price)
        {
            Milage = _milage;
        }
        public override string ToString()
        {
            return base.ToString() + $" Miles: {Milage}";
        }
    }
}
