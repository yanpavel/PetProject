using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace JollyHeisenberg
{
    public class CartPage //Go to payments - Step 4 
    {
        private IWebDriver driver;
        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public CartPage FromCartToPay()
        {
            IWebElement element = driver.FindElement(By.XPath("//button[@type='button']"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", element);
            return new CartPage(driver);
        }

        public string CartItemName()
        {
            return driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div[1]/div/h6")).Text;
        }
    }
}
