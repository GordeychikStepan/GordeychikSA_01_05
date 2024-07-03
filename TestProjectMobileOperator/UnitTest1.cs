using MobileOperatorApp.Models;

namespace TestProjectMobileOperator
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // ќбъ€вление экземпл€ра базового класса
            MobileOperator basicOperator = new MobileOperator("Test Operator", 2.0, 2000);

            // ќжидаемый результат
            double expectedQuality = 100 * 2000 / 2.0;

            // —равнение значений
            Assert.AreEqual(expectedQuality, basicOperator.Quality(), 0.01);
        }

        [Test]
        public void Test2()
        {
            // ќбъ€вление экземпл€ра класса-потомка
            MobileOperatorWithConnectionFee premiumOperator = new MobileOperatorWithConnectionFee("Test Operator", 2.0, 2000, true);

            // ќжидаемый результат
            double baseQoality = 100 * 2000 / 2.0;
            double expectedQuality = 0.7 * baseQoality;

            // —равнение значений
            Assert.AreEqual(expectedQuality, premiumOperator.Quality(), 0.01);
        }

        [Test]
        public void Test3()
        {
            // ќбъ€вление экземпл€ра класса-потомка
            MobileOperatorWithConnectionFee premiumOperator = new MobileOperatorWithConnectionFee("Test Operator", 2.0, 2000, false);

            // ќжидаемый результат
            double baseQoality = 100 * 2000 / 2.0;
            double expectedQuality = 1.5 * baseQoality;

            // —равнение значений
            Assert.AreEqual(expectedQuality, premiumOperator.Quality(), 0.01);
        }

        [Test]
        public void Test4()
        {
            // ќбъ€вление экземпл€ра класса-потомка
            MobileOperatorWithConnectionFee premiumOperator = new MobileOperatorWithConnectionFee("Test Operator", 4.0, 5200, true);

            // ќжидаемый результат
            double baseQoality = 100 * 5200 / 4.0;
            double expectedQuality = 0.7 * baseQoality;

            // —равнение значений
            Assert.AreEqual(expectedQuality, premiumOperator.Quality(), 0.01);
        }
    }
}
