using Microsoft.VisualStudio.TestTools.UnitTesting;
using IncomeTaxCalculator;


namespace UnitTestProject1
{
    [TestClass]
    public class TaxCalculatorTest
    {
        
        double actual=0;
        TaxCalculator taxCalculator;

        [TestMethod]
        public void AgeNegative()
        {
            taxCalculator = new TaxCalculator(600000,-22);
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => taxCalculator.IsAgeValid(-22));
        }

        [TestMethod]
        public void SalaryNegative()
        {
            taxCalculator = new TaxCalculator(-450, 22);
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => taxCalculator.IsSalaryValid(-450));
        }

        [TestMethod]
        public void AgeZero()
        {
            taxCalculator = new TaxCalculator(600000,0);
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => taxCalculator.IsAgeValid(0));
        }

        [TestMethod]
        public void SalaryZero()
        {
            taxCalculator = new TaxCalculator(0,22);
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => taxCalculator.IsSalaryValid(0));
        }

        [TestMethod]
        public void GroupATax1()
        {
            
            taxCalculator = new TaxCalculator(180000,22);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void GroupATax2()
        {
            
            taxCalculator = new TaxCalculator(250000,22);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void GroupATax3()
        {
            taxCalculator = new TaxCalculator(300000,22);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(15000,actual);
        }

        [TestMethod]
        public void GroupATax4()
        {
            taxCalculator = new TaxCalculator(500000, 22);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(25000, actual);
        }

        [TestMethod]
        public void GroupATax5()
        {
            taxCalculator = new TaxCalculator(650000, 22);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(42500, actual);
        }

        [TestMethod]
        public void GroupATax6()
        {
            taxCalculator = new TaxCalculator(1000000, 22);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(112500, actual);
        }

        [TestMethod]
        public void GroupATax7()
        {
            taxCalculator = new TaxCalculator(1100000, 22);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(142500, actual);
        }

        [TestMethod]
        public void GroupBTax1()
        {
            taxCalculator = new TaxCalculator(275000, 71);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void GroupBTax2()
        {
            taxCalculator = new TaxCalculator(300000, 71);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void GroupBTax3()
        {
            taxCalculator = new TaxCalculator(350000, 71);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(17500, actual);
        }

        [TestMethod]
        public void GroupBTax4()
        {
            taxCalculator = new TaxCalculator(500000, 71);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(25000, actual);
        }

        [TestMethod]
        public void GroupBTax5()
        {
            taxCalculator = new TaxCalculator(750000, 71);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(60000, actual);
        }

        [TestMethod]
        public void GroupBTax6()
        {
            taxCalculator = new TaxCalculator(1000000, 71);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(110000, actual);
        }

        [TestMethod]
        public void GroupBTax7()
        {
            taxCalculator = new TaxCalculator(1200000, 71);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(170000, actual);
        }

        [TestMethod]
        public void GroupCTax1()
        {
            taxCalculator = new TaxCalculator(275000, 83);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void GroupCTax2()
        {
            taxCalculator = new TaxCalculator(500000, 83);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void GroupCTax3()
        {
            taxCalculator = new TaxCalculator(650000, 83);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(130000, actual);
        }

        [TestMethod]
        public void GroupCTax4()
        {
            taxCalculator = new TaxCalculator(1000000, 83);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(200000, actual);
        }

        [TestMethod]
        public void GroupCTax5()
        {
            taxCalculator = new TaxCalculator(1100000, 83);
            actual = taxCalculator.CalculateTax();
            Assert.AreEqual(130000, actual);
        }
    }
}
