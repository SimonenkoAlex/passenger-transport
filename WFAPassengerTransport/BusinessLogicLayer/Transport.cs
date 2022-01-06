using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public abstract class Transport : ITransport
    {
        private string brand;
        private int productionYear;
        private string stateNumber;

        public Transport() { }

        public Transport(string model, int year, string number) {
            Brand = model;
            ProductionYear = year;
            StateNumber = number;
        }

        public string Brand { get => brand; set => brand = value; }
        public int ProductionYear { get => productionYear; set => productionYear = value; }
        public string StateNumber {
            get => stateNumber;
            set {
                string pattern = @"^[А-Я]{1}\d{3}[А-Я]{2}$";
                if (Regex.IsMatch(value, pattern, RegexOptions.IgnoreCase)) stateNumber = value;
                else throw new Exception("Не верное значение ГОС-НОМЕРА");
            }
        }

        public virtual double ProfitCalculation()
        {
            throw new Exception("Отсутствует разрешение на перевозку пассажиров!");
        }
    }
}
