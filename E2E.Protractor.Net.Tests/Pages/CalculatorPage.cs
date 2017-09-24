using E2E.Protractor.Net.Tests.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Protractor;

namespace E2E.Protractor.Net.Tests.Pages
{
    public class CalculatorPage
    {    
        public void Calculate(decimal firstNumber, decimal secondNumber, string selectedOperator)
        {
            DriverContext.NgDriver.FindElement(NgBy.Model("first")).SendKeys(firstNumber.ToString());
            DriverContext.NgDriver.FindElement(NgBy.Model("second")).SendKeys(secondNumber.ToString());
            DriverContext.NgDriver.FindElement(NgBy.Model("operator")).SendKeys(selectedOperator);
            DriverContext.NgDriver.FindElement(By.Id("gobutton")).Click();
        }

        public string GetResult()
        {
            return DriverContext.NgDriver.FindElement(NgBy.Binding("latest")).Text;
        }
    }
}
