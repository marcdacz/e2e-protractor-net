using E2E.Protractor.Net.Tests.Config;
using E2E.Protractor.Net.Tests.Pages;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E2E.Protractor.Net.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private CalculatorPage calculatorPage;
        
        [TestInitialize]
        public void Initialize()
        {
            Browser.Initialise();
            calculatorPage = new CalculatorPage();
        }

        [TestCleanup]
        public void Cleanup()
        {
            Browser.Close();
        }

        [TestMethod]
        public void AddPositiveNumbers()
        {
            calculatorPage.Calculate(4, 25, "+");
            calculatorPage.GetResult().Should().Be("29");
        }
    }
}
