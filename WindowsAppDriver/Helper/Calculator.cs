using System.Threading;
using WindowsAppDriver.Driver;

namespace WindowsAppDriver.Helper
{
    public class Calculator
    {
        private readonly WinAppDriver _driver;

        public Calculator(WinAppDriver driver)
        {
            _driver = driver;

        }

        public void EnterNumber(string number)
        {
            foreach (char c in number)
            {
                _driver.Current.FindElementByAccessibilityId("num" + c + "Button").Click();
            }
        }

        public void EnterSign(string sign)
        {
            _driver.Current.FindElementByAccessibilityId(sign + "Button").Click();
        }

        public void NavigateToStandard(string calculatorType)
        {
            _driver.Current.FindElementByName("Open Navigation").Click();
            _driver.Current.FindElementByName("Scientific Calculator").Click();
            Thread.Sleep(2000);
            //  _driver.Current.FindElementByAccessibilityId("num7Button").Click();
            //_driver.Current.FindElementByAccessibilityId("num7Button").Click();
            //_driver.Current.FindElementByAccessibilityId("NavButton").Click();
            // _driver.Current.FindElementByAccessibilityId("FlyoutNav").FindElementsByClassName("ListViewItem")[0].Click();
        }

        public string GetTitle()
        {
            return _driver.Current.FindElementByAccessibilityId("Header").Text.Trim();
        }


        public string GetResult()
        {
            return _driver.Current.FindElementByAccessibilityId("CalculatorResults").Text.Trim().Replace("Display is ", "");
        }
    }
}
