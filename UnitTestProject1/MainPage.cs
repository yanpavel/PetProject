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
    public class MainPage //Main page flow - step 2
    {
        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public MainPage SelectRedSneaker()
        {
            IWebElement element = driver.FindElement(By.XPath("//div[@id='__layout']/div/div/div[2]/div/div[2]/div[2]/div/div/div"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", element);
            return new MainPage(driver);
            
        }

        public MainPage GoToCart()
        {
            driver.FindElement(By.XPath("//div[@id='__layout']/div/header/div/div[2]/a[2]/span")).Click();
            return this;
        }

    }
}
