using BusinessLogicLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PassengerTransport.Tests
{
    [TestClass]
    public class ElectricTrainTests
    {
        [TestMethod] // высокий пассажирообороот
        public void ProfitCalculationTest1()
        {
            Transport train = new ElectricTrain("ЭГ2Тв «Иволга»", 2015, "Е543ШР", "купе", 189);
            Assert.AreEqual(85.05, train.ProfitCalculation());
        }

        [TestMethod] // низкий пассажирообороот 
        public void ProfitCalculationTest2()
        {
            Transport train = new ElectricTrain("ЭГ2Тв «Иволга»", 2015, "Е543ШР", "плацкарт", 311);
            Assert.AreEqual(105.74, train.ProfitCalculation());
        }
    }
}
