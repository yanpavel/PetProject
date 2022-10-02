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
    public class ItemPage //Buy sneakers - step 3
    {
        private IWebDriver driver;
        public ItemPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public ItemPage AddToCart()
        {
            
            IWebElement element = driver.FindElement(By.XPath("//button[@type='button']"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", element);
            return new ItemPage(driver);
            
        }

        public string GetItemName()
        {
            return driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/div/h1")).Text;
        }

    }
}
