using BusinessLogicLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PassengerTransport.Tests
{
    [TestClass]
    public class TaxiTests
    {
        [TestMethod] // расстояние меньше 50
        public void ProfitCalculationTest1()
        {
            Transport taxi = new Taxi("Audi", 2012, "Е543ШР", 278, 15, 45);
            Assert.AreEqual(236.3, taxi.ProfitCalculation());
        }

        [TestMethod] // расстояние меньше 100
        public void ProfitCalculationTest2()
        {
            Transport taxi = new Taxi("Audi", 2012, "Е543ШР", 244, 20, 69);
            Assert.AreEqual(253.76, taxi.ProfitCalculation());
        }

        [TestMethod] // расстояние меньше 150
        public void ProfitCalculationTest3()
        {
            Transport taxi = new Taxi("Audi", 2012, "Е543ШР", 185, 18, 138);
            Assert.AreEqual(242.72, taxi.ProfitCalculation());
        }
    }
}
