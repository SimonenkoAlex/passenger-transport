﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ElectricTrain : Transport
    {
        private string typeOfWagons;
        private double basicPrice;

        public double BasicPrice { get => basicPrice; set => basicPrice = value; }
        public string TypeOfWagons { get => typeOfWagons; set => typeOfWagons = value; }

        public ElectricTrain() : base() { }

        public ElectricTrain(string model, int year, string number,
            string typeOfWagons, double basicPrice)
            : base(model, year, number)
        {
            TypeOfWagons = typeOfWagons;
            BasicPrice = basicPrice;
        }

        public override double ProfitCalculation()
        {
            if (typeOfWagons == "купе")
            {
                return basicPrice * 0.34;
            }
            else if (typeOfWagons == "плацкарт")
            {
                return basicPrice * 0.45;
            }
            else return basicPrice * 1.23;
        }
    }
}
