using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Bus : Transport
    {
        private double costTicket;
        private int countPassengers;

        public Bus() : base() { }

        public Bus(string model, int year, string number, double costTicket, int countPassengers)
            : base(model, year, number)
        {
            CostTicket = costTicket;
            CountPassengers = countPassengers;
        }

        public double CostTicket { get => costTicket; set => costTicket = value; }
        public int CountPassengers { get => countPassengers; set => countPassengers = value; }

        public override double ProfitCalculation()
        {
            return Math.Round(costTicket * countPassengers, 2);
        }
    }
}
