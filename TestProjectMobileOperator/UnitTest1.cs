using MobileOperatorApp.Models;

namespace TestProjectMobileOperator
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // ���������� ���������� �������� ������
            MobileOperator basicOperator = new MobileOperator("Test Operator", 2.0, 2000);

            // ��������� ���������
            double expectedQuality = 100 * 2000 / 2.0;

            // ��������� ��������
            Assert.AreEqual(expectedQuality, basicOperator.Quality(), 0.01);
        }

        [Test]
        public void Test2()
        {
            // ���������� ���������� ������-�������
            MobileOperatorWithConnectionFee premiumOperator = new MobileOperatorWithConnectionFee("Test Operator", 2.0, 2000, true);

            // ��������� ���������
            double baseQoality = 100 * 2000 / 2.0;
            double expectedQuality = 0.7 * baseQoality;

            // ��������� ��������
            Assert.AreEqual(expectedQuality, premiumOperator.Quality(), 0.01);
        }

        [Test]
        public void Test3()
        {
            // ���������� ���������� ������-�������
            MobileOperatorWithConnectionFee premiumOperator = new MobileOperatorWithConnectionFee("Test Operator", 2.0, 2000, false);

            // ��������� ���������
            double baseQoality = 100 * 2000 / 2.0;
            double expectedQuality = 1.5 * baseQoality;

            // ��������� ��������
            Assert.AreEqual(expectedQuality, premiumOperator.Quality(), 0.01);
        }

        [Test]
        public void Test4()
        {
            // ���������� ���������� ������-�������
            MobileOperatorWithConnectionFee premiumOperator = new MobileOperatorWithConnectionFee("Test Operator", 4.0, 5200, true);

            // ��������� ���������
            double baseQoality = 100 * 5200 / 4.0;
            double expectedQuality = 0.7 * baseQoality;

            // ��������� ��������
            Assert.AreEqual(expectedQuality, premiumOperator.Quality(), 0.01);
        }
    }
}
