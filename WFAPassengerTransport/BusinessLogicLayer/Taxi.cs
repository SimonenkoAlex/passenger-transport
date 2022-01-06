using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Taxi : Transport
    {
        private double costOfFiling; // в рублях
        private int discount; // в процентах (%)
        private double mileage; // в километрах

        public double CostOfFiling { get => costOfFiling; set => costOfFiling = value; }
        public int Discount {
            get => discount;
            set {
                if (value > 0 && value < 100) discount = value;
                else throw new Exception("Не допустимое значение скидки");
            }
        }
        public double Mileage { get => mileage; set => mileage = value; }

        public Taxi() : base() { }

        public Taxi(string model, int year, string number,
            double costOfFiling, int discount, double mileage)
            : base(model, year, number)
        {
            CostOfFiling = costOfFiling;
            Discount = discount;
            Mileage = mileage;
        }

        public override double ProfitCalculation()
        {
            double temp = (double) discount / 100;
            if (mileage < 50)
            {
                return Math.Round(costOfFiling - costOfFiling * temp, 2);
            }
            else if (mileage < 100)
            {
                return Math.Round(costOfFiling * 1.3 - costOfFiling * 1.3 * temp, 2);
            }
            else if (mileage < 150)
            {
                return Math.Round(costOfFiling * 1.6 - costOfFiling * 1.6 * temp, 2);
            }
            else return Math.Round(costOfFiling * 2 - costOfFiling * 2 * temp, 2);
        }
    }
}
