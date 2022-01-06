using BusinessLogicLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PassengerTransport.Tests
{
    [TestClass]
    public class BusTests
    {
        [TestMethod] // высокий пассажирообороот
        public void ProfitCalculationTest1()
        {
            Transport bus = new Bus("Citroën", 2013, "Е543ШР", 30, 289);
            Assert.AreEqual(8670, bus.ProfitCalculation());
        }

        [TestMethod] // низкий пассажирообороот 
        public void ProfitCalculationTest2()
        {
            Transport bus = new Bus("Citroën", 2013, "Е543ШР", 25.6, 31);
            Assert.AreEqual(793.6, bus.ProfitCalculation());
        }
    }
}
