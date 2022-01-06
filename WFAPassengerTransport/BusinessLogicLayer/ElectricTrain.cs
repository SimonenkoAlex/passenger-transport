using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ElectricTrain : Transport
    {
        private string passengerCategory;
        private double basicPrice;

        public string PassengerCategory { get => passengerCategory; set => passengerCategory = value; }
        public double BasicPrice { get => basicPrice; set => basicPrice = value; }

        public ElectricTrain() : base() { }

        public ElectricTrain(string model, int year, string number,
            string passengerCategory, double basicPrice)
            : base(model, year, number)
        {
            PassengerCategory = passengerCategory;
            BasicPrice = basicPrice;
        }

        public override double ProfitCalculation()
        {
            if (passengerCategory == "student")
            {
                return basicPrice * 0.34;
            }
            else if (passengerCategory == "pensioner")
            {
                return basicPrice * 0.45;
            }
            else return basicPrice * 1.23;
        }
    }
}
