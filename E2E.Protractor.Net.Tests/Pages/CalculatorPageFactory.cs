using E2E.Protractor.Net.Tests.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Protractor;
using System;

namespace E2E.Protractor.Net.Tests.Pages
{
    [Obsolete] //PageFactory approach is still not supported in .NET Core 2.0
    public class CalculatorPageFactory
    {        
        [FindsBy(How = How.Custom, CustomFinderType = typeof(NgByModel), Using = "first")]
        public IWebElement FirstValue { get; set; }

        [FindsBy(How = How.Custom, CustomFinderType = typeof(NgByModel), Using = "second")]
        public IWebElement SecondValue { get; set; }

        [FindsBy(How = How.Custom, CustomFinderType = typeof(NgByModel), Using = "operator")]
        public IWebElement Operator { get; set; }

        [FindsBy(How = How.Id, Using = "gobutton")]
        public IWebElement GoButton { get; set; }

        [FindsBy(How = How.Custom, CustomFinderType = typeof(NgByBinding), Using = "latest")]
        public IWebElement ResultValue { get; set; }

        [FindsBy(How = How.Custom, CustomFinderType = typeof(NgByRepeater), Using = "result in memory")]
        public IWebElement History { get; set; }

        public CalculatorPageFactory()
        {
            PageFactory.InitElements(DriverContext.NgDriver, this);
        }

        public void Calculate(decimal firstNumber, decimal secondNumber, string selectedOperator)
        {
            FirstValue.SendKeys(firstNumber.ToString());
            SecondValue.SendKeys(secondNumber.ToString());
            Operator.SendKeys(selectedOperator.ToString());
            GoButton.Click();
        }

        public string GetResult()
        {
            return ResultValue.Text;
        }
    }
}
